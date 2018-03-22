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
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        //Llena los Table Adapter con las vistas correspondientes.
        //Inicialmente no hay una fuente de datos para el Grid View
        private void Consultas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ds.TP4CONSULTA4' Puede moverla o quitarla según sea necesario.
            this.tP4CONSULTA4TableAdapter.Fill(this.ds.TP4CONSULTA4);
            // TODO: esta línea de código carga datos en la tabla 'ds.TP4CONSULTA3' Puede moverla o quitarla según sea necesario.
            this.tP4CONSULTA3TableAdapter.Fill(this.ds.TP4CONSULTA3);
            // TODO: esta línea de código carga datos en la tabla 'ds.TP4CONSULTA2' Puede moverla o quitarla según sea necesario.
            this.tP4CONSULTA2TableAdapter.Fill(this.ds.TP4CONSULTA2);
            // TODO: esta línea de código carga datos en la tabla 'ds.TP4CONSULTA1' Puede moverla o quitarla según sea necesario
            this.tP4CONSULTA1TableAdapter.Fill(this.ds.TP4CONSULTA1);
        }


        //Ejecuta las consulta 1 de la tarea 4.
        //Consulta: para cada ciudad, listar las instituciones, y sus campus, que se localizan en la misma. 
        private void btnConsulta1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tP4CONSULTA1BindingSource;
        }

        //Ejecuta las consulta 2 de la tarea 4.
        //Consulta: obtener el nombre de las instituciones, sin importar el campus, 
        //donde se imparten las carreras de Ing. en Compu
        //tación, Ing. en Telemática y Lic. en Matemáticas (o sea, todas ellas). 
        private void btnConsulta2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tP4CONSULTA2BindingSource;
        }

        //Ejecuta las consulta 3 de la tarea 4.
        //Consulta: Consulta: escribir los campus, y su institución,
        //que tienen más de dos servicios adicionales en el mismo sitio del campus.  
        private void btnConsulta3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tP4CONSULTA3BindingSource;
        }

        //Ejecuta las consulta 4 de la tarea 4.
        //Consulta: mostrar el nombre de las instituciones
        //que ofrezcan todas las carreras registradas en la base de datos, 
        //sin importar en que campus se impartan.
        private void btnConsulta4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tP4CONSULTA4BindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
