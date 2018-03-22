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


        private void btnConsulta1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tP4CONSULTA1BindingSource;
        }

        private void btnConsulta2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tP4CONSULTA2BindingSource;
        }

        private void btnConsulta3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tP4CONSULTA3BindingSource;
        }

        private void btnConsulta4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tP4CONSULTA4BindingSource;
        }
    }
}
