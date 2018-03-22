using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void institucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tablas.FrmInstituciones c = new Tablas.FrmInstituciones();
            c.Show();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tablas.FrmCarreras c = new Tablas.FrmCarreras();
            c.Show();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tablas.FrmServicios c = new Tablas.FrmServicios();
            c.Show();
        }

        private void campusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tablas.FrmCampus c = new Tablas.FrmCampus();
            c.Show();
        }

        private void subProgramasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Procedimientos.Subprogramas c = new Procedimientos.Subprogramas();
            c.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Procedimientos.Consultas c = new Procedimientos.Consultas();
            c.Show();
        }

        private void altaCampusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Procedimientos.AltaCampus c = new Procedimientos.AltaCampus();
            c.Show();
        }
    }
}
