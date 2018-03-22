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
    public partial class FrmCarreras : Form
    {
        public FrmCarreras()
        {
            InitializeComponent();
        }

        //Llena el Grid View con la información de la tabla correspondiente
        private void FrmCarreras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ds.T4CARRERA' Puede moverla o quitarla según sea necesario.
            this.t4CARRERATableAdapter.Fill(this.ds.T4CARRERA);

        }

        //Actualiza los cambios en la tabla
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.t4CARRERATableAdapter.Fill(this.ds.T4CARRERA);
        }
    }
}
