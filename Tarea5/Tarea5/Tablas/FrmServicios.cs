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
    public partial class FrmServicios : Form
    {
        public FrmServicios()
        {
            InitializeComponent();
        }

        //Llena el Grid View con la información de la tabla
        private void FrmServicios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ds.T4SERVICIO' Puede moverla o quitarla según sea necesario.
            this.t4SERVICIOTableAdapter.Fill(this.ds.T4SERVICIO);

        }

        //Actualiza los cambios en la tabla
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.t4SERVICIOTableAdapter.Update(this.ds.T4SERVICIO);
        }
    }
}
