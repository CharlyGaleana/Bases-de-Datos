using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5.Procedimientos
{
    public partial class AltaCampus : Form
    {
        //variables de la clase
        private GestorBD.GestorBD GestorBD;
        private DataSet dsInstituciones = new DataSet(), dsTemp = new DataSet();
        //private DataSet dsAlum = new DataSet(), dsMater = new DataSet(), dsCalifs = new DataSet();
        private Comunes.Comunes comunes = new Comunes.Comunes();
        private const int OK = 1;
        private string cadSql;

        public AltaCampus()
        {
            InitializeComponent();
        }

        //Acciones iniciales
        private void AltaCampus_Load(object sender, EventArgs e)
        {
            //1. Crea la conexión a la base de datos
            GestorBD = new GestorBD.GestorBD("MSDAORA", "bd12", "lircar", "oracle");

            //2. Llena el Combo Box de Instituciones
            cadSql = "select * from t4institución";
            GestorBD.consBD(cadSql, dsInstituciones, "Instituciones");
            comunes.cargaCombo(cmbInstituciones, dsInstituciones, "Instituciones", "nomins");

        }

        //Acciones iniciales para dar de alta un campus
        private void btnAlta_Click(object sender, EventArgs e)
        {
            //hace visibles los elementos necesarios
            btnAlta.Enabled = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;

            txtNom.Visible = txtNom.Enabled = true;
            txtDomicilio.Visible = txtDomicilio.Enabled = true;
            txtTelefono.Visible = txtTelefono.Enabled = true;
            txtCiudad.Visible = txtCiudad.Enabled = true;
            txtEstado.Visible = txtEstado.Enabled = true;
            txtProfesores.Visible = txtProfesores.Enabled = true;

            cmbInstituciones.Visible = cmbInstituciones.Enabled = true;
            btnRegistrar.Visible = btnRegistrar.Enabled = true;
        }

        //Da de alta el campos que se describió en la ventana
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DataRow fila;

            //variables necesarias para dar de alta
            string nomcamp = txtNom.Text;
            string domicilio = txtDomicilio.Text;
            string telefono = txtTelefono.Text;
            string ciuadad = txtCiudad.Text;
            string estado = txtEstado.Text;
            string nomins = cmbInstituciones.Text;
            int prof = Convert.ToInt16 (txtProfesores.Text);
            int idInst, idCampus;


            //obtiene el nuevo id
            cadSql = "select max(idcamp) as maxid from t4campus";
            GestorBD.consBD(cadSql, dsTemp, "Temp");
            fila = dsTemp.Tables["Temp"].Rows[0];
            idCampus = Convert.ToInt16(fila["maxid"]) + 1;

            //obtiene el id de la institucion seleccionada
            cadSql = "select idInst from t4institución where nomins + '" + nomins + "'";
            GestorBD.consBD(cadSql, dsTemp, "Temp1");
            fila = dsT
        }
    }
}
