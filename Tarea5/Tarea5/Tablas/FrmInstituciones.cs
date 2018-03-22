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
    public partial class FrmInstituciones : Form
    {
        public FrmInstituciones()
        {
            InitializeComponent();
        }

        //Llena el Grid View con la información de la tabla
        private void FrmInstituciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ds.T4INSTITUCIÓN' Puede moverla o quitarla según sea necesario.
            this.t4INSTITUCIÓNTableAdapter.Fill(this.ds.T4INSTITUCIÓN);

        }

        //Actualiza los cambios en la tabla
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.t4INSTITUCIÓNTableAdapter.Fill(this.ds.T4INSTITUCIÓN);
        }
    }
}
