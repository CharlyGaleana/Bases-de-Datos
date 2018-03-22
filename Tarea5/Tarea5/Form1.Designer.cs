namespace Tarea5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.institucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procedientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subProgramasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.tablasToolStripMenuItem,
            this.procedientosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(408, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tablasToolStripMenuItem
            // 
            this.tablasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.institucionesToolStripMenuItem,
            this.carrerasToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.campusToolStripMenuItem});
            this.tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            this.tablasToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.tablasToolStripMenuItem.Text = "Tablas";
            // 
            // institucionesToolStripMenuItem
            // 
            this.institucionesToolStripMenuItem.Name = "institucionesToolStripMenuItem";
            this.institucionesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.institucionesToolStripMenuItem.Text = "Instituciones";
            this.institucionesToolStripMenuItem.Click += new System.EventHandler(this.institucionesToolStripMenuItem_Click);
            // 
            // carrerasToolStripMenuItem
            // 
            this.carrerasToolStripMenuItem.Name = "carrerasToolStripMenuItem";
            this.carrerasToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.carrerasToolStripMenuItem.Text = "Carreras";
            this.carrerasToolStripMenuItem.Click += new System.EventHandler(this.carrerasToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            this.serviciosToolStripMenuItem.Click += new System.EventHandler(this.serviciosToolStripMenuItem_Click);
            // 
            // campusToolStripMenuItem
            // 
            this.campusToolStripMenuItem.Name = "campusToolStripMenuItem";
            this.campusToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.campusToolStripMenuItem.Text = "Campus";
            this.campusToolStripMenuItem.Click += new System.EventHandler(this.campusToolStripMenuItem_Click);
            // 
            // procedientosToolStripMenuItem
            // 
            this.procedientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem,
            this.subProgramasToolStripMenuItem});
            this.procedientosToolStripMenuItem.Name = "procedientosToolStripMenuItem";
            this.procedientosToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.procedientosToolStripMenuItem.Text = "Procedientos";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // subProgramasToolStripMenuItem
            // 
            this.subProgramasToolStripMenuItem.Name = "subProgramasToolStripMenuItem";
            this.subProgramasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.subProgramasToolStripMenuItem.Text = "SubProgramas";
            this.subProgramasToolStripMenuItem.Click += new System.EventHandler(this.subProgramasToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 317);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem institucionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procedientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subProgramasToolStripMenuItem;
    }
}

