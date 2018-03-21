using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoCSBD.Procesos {
    public partial class FrmGestorBD : Form {
        public FrmGestorBD() {
            InitializeComponent();
        }
        //variables de la clase
        private GestorBD.GestorBD GestorBD;
        private DataSet dsAlum = new DataSet(), dsMater = new DataSet(), dsCalifs = new DataSet();
        private Comunes.Comunes comunes = new Comunes.Comunes();
        private const int OK = 1;
        private string cadSql;

        //para cambiar calif.
        private void button3_Click(object sender, EventArgs e) {
            cmbCalificacion.Visible = true; cmbCalificacion.Text = "Calificación:";
            btnRegistrarCambio.Visible = true; btnAlta.Enabled = false;
            btnBaja.Enabled = false; comboAlumnos.Enabled = false;
        }

        //Habilita y visualiza controles
        private void btnAlta_Click(object sender, EventArgs e) {
            //Habilita/deshabilita controles (de esta manera se puede guiar lo que el usuario
            //debe hacer).
            cmbMateria.Visible = true; cmbCalificacion.Visible = true; dtpFecha.Visible = true;
            btnRegistrar.Visible = true; btnAlta.Enabled = false;
            btnBaja.Enabled = false; btnCambio.Enabled = false;
        }

        //Prepara y envía la cadena de inserción de la nueva calificación.
        private void btnRegistrar_Click(object sender, EventArgs e) {
            DataRow[] filasAlum; DataRow[] filasMater; DataRow fila;
            DataSet dsTemp = new DataSet();
            int folio, calif; String fecha;
            int cu, clavem;

            //Obtiene el nuevo folio
            cadSql = "select max(folio) as maxFolio from historial";
            GestorBD.consBD(cadSql, dsTemp, "Temp");
            fila = dsTemp.Tables["Temp"].Rows[0];
            folio = Convert.ToInt32(fila["maxFolio"]) + 1;

            //obtiene la calificación
            calif = Convert.ToInt32(cmbCalificacion.Text);

            //obtiene la fecha.
            fecha = "date '" + dtpFecha.Value.Year + "-" + dtpFecha.Value.Month + "-" + dtpFecha.Value.Day + "'";

            //obtiene la clave del alumno y materiad elegidas usando los ds.
            filasAlum = dsAlum.Tables["Alumnos"].Select("NomAl ='" + comboAlumnos.Text + "'");
            filasMater = dsMater.Tables["Materias"].Select("nommat ='" + cmbMateria.Text + "'");
            cu = Convert.ToInt32( filasAlum[0][0] );
            clavem = Convert.ToInt32(filasMater[0][0]);

            //inserta la nueva calificación a la tabla de historial
            cadSql = "insert into historial values(" + folio + "," + calif + "," + fecha + "," + cu + "," + clavem + ")";
            int result = GestorBD.altaBD(cadSql);
            if (result == OK)
                MessageBox.Show("Calificación insertado");
            else
                MessageBox.Show("Error al insertar");

            //Habilita/deshabilita controles.
            cmbMateria.Visible = false; cmbMateria.Text = "Materias:";
            cmbCalificacion.Visible = false; cmbCalificacion.Text = "Calificación:";
            dtpFecha.Visible = false;
            btnRegistrar.Visible = false; btnAlta.Enabled = true;
            btnBaja.Enabled = true; btnCambio.Enabled = true;
        }


        //Para obtener el valor de la celda seleccionada al darle clic en el DataGrid
        //existen tres maneras (necesariamente hay que dar clic en la celda elegida):
        //1) nombreDataGrid.CurrentCell.Value;
        //2) nombreDataGrid[ÍndiceColumna, ÍndiceFila].Value;
        //3) nombreDataGrid[NombreColumna, ÍndiceFila].Value
        private void dtgGeneral_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            int fila, col; Object valor;

            //Obtiene fila, columna y valor de la celda elegida.
            fila = dtgGeneral.CurrentCell.RowIndex; col = dtgGeneral.CurrentCell.ColumnIndex;
            valor = dtgGeneral.CurrentCell.Value;
            MessageBox.Show("Fila: " + fila + " Columna: " + col + " Valor: " + valor);

            //Obtiene sólo el valor.
            MessageBox.Show("Valor: " + dtgGeneral[col, fila].Value.ToString());
        }

        //acciones iniciales
        private void FrmGestorBD_Load(object sender, EventArgs e) {
            //1. Crea la conexión a la base de datos
            GestorBD = new GestorBD.GestorBD("MSDAORA", "bd12", "lircar", "oracle");

            //2. Lee los datos de los alumnos y los despliega.
            cadSql = "select * from alum";
            GestorBD.consBD(cadSql, dsAlum, "Alumnos");
            dtgGeneral.DataSource = dsAlum.Tables["Alumnos"];

            //3. Lee los datos de las materias y los despliega.
            cadSql = "select * from mater";
            GestorBD.consBD(cadSql, dsMater, "Materias");
            //dtgGeneral.DataSource = dsMater.Tables["Materias"];

            comunes.cargaCombo(comboAlumnos, dsAlum, "Alumnos", "NomAl");
            comunes.cargaCombo(cmbMateria, dsMater, "Materias", "Nommat");
        }

        private void btnRegistrarCambio_Click(object sender, EventArgs e) {
            int folio, nuevaCalif; String cadSql;

            //Toma el folio de la calificación seleccionada en el data grid.
            folio = Convert.ToInt16(dtgGeneral["Folio", dtgGeneral.CurrentRow.Index].Value);

            //Construye la cadena de cambio.
            dtgGeneral["Calif", dtgGeneral.CurrentRow.Index].Value = cmbCalificacion.Text;
            nuevaCalif = Convert.ToInt16(cmbCalificacion.Text);

            // y la envía para su ejecución.
            cadSql = "update Historial set Calif=" + nuevaCalif + " where Folio=" + folio;
            if (GestorBD.cambiaBD(cadSql) == OK)
                MessageBox.Show("Se actualizó Historial exitosamente");
            else
                MessageBox.Show("No se pudo actualizar Historial");
            cmbCalificacion.Visible = false; cmbCalificacion.Text = "Calificación:";
            btnRegistrarCambio.Visible = false; btnAlta.Enabled = true;
            btnBaja.Enabled = true; comboAlumnos.Enabled = true;
        }

        //Muestra las calificacinoes del alumno seleccionado en el combo.
        private void comboAlumnos_SelectedIndexChanged(object sender, EventArgs e) {
            cadSql = "select folio, nomal, nommat, calif, fecha from alum a, historial h, mater m " +
                "where a.cu = h.cu and h.clavem = m.clavem and nomal = '" + comboAlumnos.Text + "'";
            GestorBD.consBD(cadSql, dsCalifs, "Calificaciones");
            dtgGeneral.DataSource = dsCalifs.Tables["Calificaciones"];  
        }

        //Elimina una calificación del historial
        //utiliza el folio de la fila seleccionado.
        private void button2_Click(object sender, EventArgs e) {
            int fila, folio;

            fila = dtgGeneral.CurrentCell.RowIndex;
            folio = Convert.ToInt32( dtgGeneral[0, fila].Value.ToString() ) ;
            MessageBox.Show(folio + "");
            cadSql = "delete from historial where folio = " + folio;

            int result = GestorBD.bajaBD(cadSql);
            if (result == OK) {
                MessageBox.Show("calificación eliminada");
            }
            else {
                MessageBox.Show("error al eliminar calificación");
            }
        }
    }
}
