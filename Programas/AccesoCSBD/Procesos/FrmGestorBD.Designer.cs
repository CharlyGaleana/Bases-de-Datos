namespace AccesoCSBD.Procesos {
    partial class FrmGestorBD {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dtgGeneral = new System.Windows.Forms.DataGridView();
            this.comboAlumnos = new System.Windows.Forms.ComboBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnCambio = new System.Windows.Forms.Button();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.cmbCalificacion = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnRegistrarCambio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgGeneral
            // 
            this.dtgGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGeneral.Location = new System.Drawing.Point(43, 42);
            this.dtgGeneral.Name = "dtgGeneral";
            this.dtgGeneral.Size = new System.Drawing.Size(406, 150);
            this.dtgGeneral.TabIndex = 0;
            this.dtgGeneral.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgGeneral_CellContentClick);
            // 
            // comboAlumnos
            // 
            this.comboAlumnos.FormattingEnabled = true;
            this.comboAlumnos.Location = new System.Drawing.Point(77, 239);
            this.comboAlumnos.Name = "comboAlumnos";
            this.comboAlumnos.Size = new System.Drawing.Size(121, 21);
            this.comboAlumnos.TabIndex = 2;
            this.comboAlumnos.Text = "Alumnos";
            this.comboAlumnos.SelectedIndexChanged += new System.EventHandler(this.comboAlumnos_SelectedIndexChanged);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(43, 287);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(121, 23);
            this.btnAlta.TabIndex = 3;
            this.btnAlta.Text = "Alta Calif";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(187, 287);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(121, 23);
            this.btnBaja.TabIndex = 4;
            this.btnBaja.Text = "Baja de Calif";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCambio
            // 
            this.btnCambio.Location = new System.Drawing.Point(328, 287);
            this.btnCambio.Name = "btnCambio";
            this.btnCambio.Size = new System.Drawing.Size(121, 23);
            this.btnCambio.TabIndex = 5;
            this.btnCambio.Text = "Cambio de Cali";
            this.btnCambio.UseVisualStyleBackColor = true;
            this.btnCambio.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmbMateria
            // 
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(43, 344);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(121, 21);
            this.cmbMateria.TabIndex = 7;
            this.cmbMateria.Text = "Materia";
            this.cmbMateria.Visible = false;
            // 
            // cmbCalificacion
            // 
            this.cmbCalificacion.FormattingEnabled = true;
            this.cmbCalificacion.Items.AddRange(new object[] {
            "10",
            "9",
            "8",
            "7",
            "6",
            "5"});
            this.cmbCalificacion.Location = new System.Drawing.Point(187, 343);
            this.cmbCalificacion.Name = "cmbCalificacion";
            this.cmbCalificacion.Size = new System.Drawing.Size(121, 21);
            this.cmbCalificacion.TabIndex = 8;
            this.cmbCalificacion.Text = "Calificaciòn";
            this.cmbCalificacion.Visible = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(328, 344);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 20);
            this.dtpFecha.TabIndex = 10;
            this.dtpFecha.Visible = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(43, 391);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(121, 23);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrar Alta";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Visible = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnRegistrarCambio
            // 
            this.btnRegistrarCambio.Location = new System.Drawing.Point(328, 391);
            this.btnRegistrarCambio.Name = "btnRegistrarCambio";
            this.btnRegistrarCambio.Size = new System.Drawing.Size(121, 23);
            this.btnRegistrarCambio.TabIndex = 12;
            this.btnRegistrarCambio.Text = "Registrar Cambio";
            this.btnRegistrarCambio.UseVisualStyleBackColor = true;
            this.btnRegistrarCambio.Click += new System.EventHandler(this.btnRegistrarCambio_Click);
            // 
            // FrmGestorBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 440);
            this.Controls.Add(this.btnRegistrarCambio);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cmbCalificacion);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.btnCambio);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.comboAlumnos);
            this.Controls.Add(this.dtgGeneral);
            this.Name = "FrmGestorBD";
            this.Text = "Prueba Gestor BD definido con .dll";
            this.Load += new System.EventHandler(this.FrmGestorBD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGeneral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgGeneral;
        private System.Windows.Forms.ComboBox comboAlumnos;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnCambio;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.ComboBox cmbCalificacion;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnRegistrarCambio;
    }
}