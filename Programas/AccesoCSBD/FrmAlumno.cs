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
    public partial class FrmAlumno : Form {
        public FrmAlumno() {
            InitializeComponent();
        }

        private void FrmAlumno_Load(object sender, EventArgs e) {
            // TODO: esta línea de código carga datos en la tabla 'dSAlumno.ALUM' Puede moverla o quitarla según sea necesario.
            this.aLUMTableAdapter.Fill(this.dSAlumno.ALUM);

        }

        //actualiza la tabla de alumnos
        private void button1_Click(object sender, EventArgs e) {
            this.aLUMTableAdapter.Update(this.dSAlumno.ALUM);
        }
    }
}
