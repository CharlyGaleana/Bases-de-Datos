using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoCSBD {
    public partial class FrmMenú : Form {
        public FrmMenú() {
            InitializeComponent();
        }

        //Termina la aplicación.
        private void mnuSalir_Click(object sender, EventArgs e) {

            Application.Exit();
        }

        //Muestra la tabla alumnos.
        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e) {

            FrmAlumno fa = new FrmAlumno();
            fa.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmMaterias fm = new FrmMaterias();
            fm.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e) {
            Procesos.FrmAlumCalifs fac = new Procesos.FrmAlumCalifs();
            fac.ShowDialog();
        }

        private void subprogramasToolStripMenuItem_Click(object sender, EventArgs e) {
            Procesos.FrmSubprogsAlms sp = new Procesos.FrmSubprogsAlms();
            sp.Show();
        }

        //para probar los métodos de Gestor BD.
        private void gestorBDToolStripMenuItem_Click(object sender, EventArgs e) {
            Procesos.FrmGestorBD fg = new Procesos.FrmGestorBD();
            fg.Show();
        }
    }
}
