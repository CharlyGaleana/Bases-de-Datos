using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5.Procedimientos
{
    public partial class CampusCiudad : Form
    {

        //variables de la clase
        private GestorBD.GestorBD GestorBD;
        private DataSet dsCarreras = new DataSet(), dsCiudades = new DataSet(), dsCons = new DataSet();
        private Comunes.Comunes comunes = new Comunes.Comunes();
        private const int OK = 1;
        private string cadSql;

        public CampusCiudad()
        {
            InitializeComponent();
        }

        //consulta los campues que ofrecen la carrera seleccionada en la ciudad seleccionada
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            OleDbTransaction t;

            try
            {
                GestorBD.conex.Open();

                //se creal el objeto de transacción con el nivel de aislamiento deseado
                t = GestorBD.conex.BeginTransaction(IsolationLevel.ReadCommitted);
                string ciudad = cmbCiudades.Text;
                string carrera = cmbCarreras.Text;

                //consulta los campus / instituciones que ofrecen la carrera en la ciudad dada
                cadSql = "select cp.nomcamp, i.nomins, ic.semestres, ic.créditos from t4institución i, t4instcarr ic, t4carrera cr, t4campus cp, t4campcarr cc where ic.idinst = i.idinst and ic.idcar = cr.idcar and i.idinst = cp.idinst and cc.idcamp = cp.idcamp and cc.idcarr = cr.idcar and cp.ciudad = '"
                    + ciudad + "' and cr.nomcarr = '" + carrera + "'";
                GestorBD.consBD(t, cadSql, "Resultado", dsCons);
                dgvConsulta.DataSource = dsCons.Tables["Resultado"];

                //finaliza la transacción
                try
                {
                    t.Commit();        //Confirma la transacción.
                }
                catch (OleDbException err)
                {
                    MessageBox.Show(err.Message);
                    t.Rollback();      //Si hay error, revierte la transacción.
                }
                GestorBD.conex.Close();      //Cierra la conexión a la BD.
                t = null;                       //Destruye el objeto de transacción.
                
            }
            catch(OleDbException err) {
                MessageBox.Show(err.Message);
            }

        }

        //Acciones iniciales
        private void CampusCiudad_Load(object sender, EventArgs e)
        {
            //1. Crea la conexión a la base de datos
            GestorBD = new GestorBD.GestorBD("MSDAORA", "bd12", "lircar", "oracle");

            //2. Llena el Combo Box de Carreras
            cadSql = "select * from t4Carrera";
            GestorBD.consBD(cadSql, dsCarreras, "Carreras");
            comunes.cargaCombo(cmbCarreras, dsCarreras, "Carreras", "nomcarr");

            //3. Llena el Combo Box de Servicios
            cadSql = "select * from t4Campus";
            GestorBD.consBD(cadSql, dsCiudades, "Ciudades");
            comunes.cargaCombo(cmbCiudades, dsCiudades, "Ciudades", "ciudad");
        }
    }
}
