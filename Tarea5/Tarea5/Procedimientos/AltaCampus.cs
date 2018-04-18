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
    public partial class AltaCampus : Form
    {
        //variables de la clase
        private GestorBD.GestorBD GestorBD;
        private DataSet dsInstituciones = new DataSet(), dsTemp = new DataSet();
        private DataSet dsCarreras = new DataSet(), dsServicios = new DataSet();
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

            //3. Llena el Combo Box de Carreras
            cadSql = "select * from t4Carrera";
            GestorBD.consBD(cadSql, dsCarreras, "Carreras");
            comunes.cargaCombo(cmbCarreras, dsCarreras, "Carreras", "nomcarr");

            //3. Llena el Combo Box de Servicios
            cadSql = "select * from t4Servicio";
            GestorBD.consBD(cadSql, dsServicios, "Servicios");
            comunes.cargaCombo(cmbServicios, dsServicios, "Servicios", "nomserv");

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
            label8.Visible = true;
            label9.Visible = true;

            txtNom.Visible = txtNom.Enabled = true;
            txtDomicilio.Visible = txtDomicilio.Enabled = true;
            txtTelefono.Visible = txtTelefono.Enabled = true;
            txtCiudad.Visible = txtCiudad.Enabled = true;
            txtEstado.Visible = txtEstado.Enabled = true;
            txtProfesores.Visible = txtProfesores.Enabled = true;

            cmbInstituciones.Visible = cmbInstituciones.Enabled = true;
            cmbCarreras.Visible = cmbCarreras.Enabled = true;
            cmbServicios.Visible = cmbServicios.Enabled = true;
            btnRegistrar.Visible = btnRegistrar.Enabled = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        //oculta los botones y campos que no se necesitan
        private void oculta() {
            btnAlta.Enabled = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;

            txtNom.Visible = txtNom.Enabled = false;
            txtDomicilio.Visible = txtDomicilio.Enabled = false;
            txtTelefono.Visible = txtTelefono.Enabled = false;
            txtCiudad.Visible = txtCiudad.Enabled = false;
            txtEstado.Visible = txtEstado.Enabled = false;
            txtProfesores.Visible = txtProfesores.Enabled = false;

            cmbInstituciones.Visible = cmbInstituciones.Enabled = false;
            cmbCarreras.Visible = cmbCarreras.Enabled = false;
            cmbServicios.Visible = cmbServicios.Enabled = false;
            btnRegistrar.Visible = btnRegistrar.Enabled = false;
        }

        //Da de alta el campos que se describió en la ventana
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DataRow fila;
            OleDbTransaction t;

            //variables necesarias para dar de alta
            string nomcamp = txtNom.Text;
            string domicilio = txtDomicilio.Text;
            string telefono = txtTelefono.Text;
            string ciudad = txtCiudad.Text;
            string estado = txtEstado.Text;
            string nomins = cmbInstituciones.Text;
            string nomserv = cmbServicios.Text;
            string nomcarr = cmbCarreras.Text;
            int prof = txtProfesores.Text != "" ? Convert.ToInt16 (txtProfesores.Text) : 0;
            int idInst, idCampus;
            int idServ, idCarr;
            int result;


            try
            {
                GestorBD.conex.Open(); // se abre la conexión a la BD.

                //se crea el objeto de transacción y se especifica el nivel de aislamiento
                t = GestorBD.conex.BeginTransaction(IsolationLevel.Serializable);

                //obtiene el nuevo id
                cadSql = "select max(idcamp) as maxid from t4campus";
                GestorBD.consBD(t, cadSql, "Temp", dsTemp);
                fila = dsTemp.Tables["Temp"].Rows[0];
                idCampus = Convert.ToInt16(fila["maxid"]) + 1;

                //obtiene el id de la institucion seleccionada
                cadSql = "select idInst from t4institución where nomins = '" + nomins + "'";
                GestorBD.consBD(t, cadSql, "Temp1", dsTemp);
                fila = dsTemp.Tables["Temp1"].Rows[0];
                idInst = Convert.ToInt16(fila[0]);

                //insertamos el campus en la tabla
                try
                {
                    cadSql = "insert into t4Campus values ( " + idCampus + ",'" + nomcamp + "','" + domicilio + "','"
                           + telefono + "','" + ciudad + "','" + estado + "'," + prof + "," + idInst + ")";
                    result = GestorBD.altaBD(t, cadSql);
                    if (result == OK)
                    {
                        MessageBox.Show("El campus se dio de alta exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al intentar dar de alta el campus");
                    }
                }
                catch (OleDbException err) {
                    MessageBox.Show(err.Message);       
                }

                //si se agregó un servicio inicial al campus, se añade el servicio

                if (nomserv != "")
                {
                    try
                    {
                        //recupera el id del servicio
                        cadSql = "select ids from t4servicio where nomserv = '" + nomserv + "'";
                        GestorBD.consBD(t, cadSql, "Temp2", dsTemp);
                        fila = dsTemp.Tables["Temp2"].Rows[0];
                        idServ = Convert.ToInt16(fila[0]);

                        cadSql = "insert into t4campservicio values (" + idCampus + "," + idServ + ",'NO','NO'" + ')';
                        result = GestorBD.altaBD(t, cadSql);

                        if (result == OK)
                        {
                            MessageBox.Show("El servicio se dio de alta exitosamente");
                        }
                        else
                        {
                            MessageBox.Show("Error al intentar dar de alta el servicio");
                        }
                    } catch (OleDbException err) {
                        MessageBox.Show(err.Message);
                    }
                }

                //si se agregó una carrera inicial al campus, se añade la carrera
                if (nomcarr != "")
                {
                    try
                    {
                        //recupera el id de la carrera
                        cadSql = "select idcar from t4Carrera where nomcarr = '" + nomcarr + "'";
                        GestorBD.consBD(t, cadSql, "Temp3", dsTemp);
                        fila = dsTemp.Tables["Temp3"].Rows[0];
                        idCarr = Convert.ToInt16(fila[0]);

                        cadSql = "insert into t4campcarr values (" + idCampus + "," + idCarr + ')';
                        result = GestorBD.altaBD(t, cadSql);

                        if (result == OK)
                        {
                            MessageBox.Show("La carrera se dio de alta exitosamente");
                        }
                        else
                        {
                            MessageBox.Show("Error al intentar dar de alta la carrera");
                        }
                    }
                    catch (OleDbException err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }

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
                MessageBox.Show("Transacción finalizada");

                oculta();

            }
            catch (OleDbException err) {
                MessageBox.Show(err.Message);
            }

        }
    }
}
