namespace Tarea5.Procedimientos
{
    partial class Subprogramas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEjecutaFuncion = new System.Windows.Forms.Button();
            this.btnEjecutaProcedimiento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEjecutaFuncion
            // 
            this.btnEjecutaFuncion.Location = new System.Drawing.Point(38, 69);
            this.btnEjecutaFuncion.Name = "btnEjecutaFuncion";
            this.btnEjecutaFuncion.Size = new System.Drawing.Size(205, 23);
            this.btnEjecutaFuncion.TabIndex = 0;
            this.btnEjecutaFuncion.Text = "Ejecutar Función Almacenada";
            this.btnEjecutaFuncion.UseVisualStyleBackColor = true;
            this.btnEjecutaFuncion.Click += new System.EventHandler(this.btnEjecutaFuncion_Click);
            // 
            // btnEjecutaProcedimiento
            // 
            this.btnEjecutaProcedimiento.Location = new System.Drawing.Point(38, 135);
            this.btnEjecutaProcedimiento.Name = "btnEjecutaProcedimiento";
            this.btnEjecutaProcedimiento.Size = new System.Drawing.Size(205, 23);
            this.btnEjecutaProcedimiento.TabIndex = 1;
            this.btnEjecutaProcedimiento.Text = "Ejecutar Procedimiento Almacenado";
            this.btnEjecutaProcedimiento.UseVisualStyleBackColor = true;
            this.btnEjecutaProcedimiento.Click += new System.EventHandler(this.btnEjecutaProcedimiento_Click);
            // 
            // Subprogramas
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnEjecutaProcedimiento);
            this.Controls.Add(this.btnEjecutaFuncion);
            this.Name = "Subprogramas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFuncion;
        private System.Windows.Forms.Button btnEjecutaFuncion;
        private System.Windows.Forms.Button btnEjecutaProcedimiento;
    }
}