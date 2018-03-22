using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5.Tablas
{
    public partial class FrmCampus : Form
    {
        public FrmCampus()
        {
            InitializeComponent();
        }


        //Llena el Grid View con la información de la tabla
        private void FrmCampus_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ds.T4CAMPUS' Puede moverla o quitarla según sea necesario.
            this.t4CAMPUSTableAdapter.Fill(this.ds.T4CAMPUS);

        }

        //Actualiza los cambios en la tabla
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.t4CAMPUSTableAdapter.Update(this.ds.T4CAMPUS);
        }
    }
}
