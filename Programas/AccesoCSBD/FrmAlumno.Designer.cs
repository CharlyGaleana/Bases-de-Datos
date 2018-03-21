﻿namespace AccesoCSBD {
    partial class FrmAlumno {
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dSAlumno = new AccesoCSBD.DSAlumno();
            this.aLUMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aLUMTableAdapter = new AccesoCSBD.DSAlumnoTableAdapters.ALUMTableAdapter();
            this.cUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUDataGridViewTextBoxColumn,
            this.nOMALDataGridViewTextBoxColumn,
            this.cARRDataGridViewTextBoxColumn,
            this.pROMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aLUMBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(72, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(487, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // dSAlumno
            // 
            this.dSAlumno.DataSetName = "DSAlumno";
            this.dSAlumno.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLUMBindingSource
            // 
            this.aLUMBindingSource.DataMember = "ALUM";
            this.aLUMBindingSource.DataSource = this.dSAlumno;
            // 
            // aLUMTableAdapter
            // 
            this.aLUMTableAdapter.ClearBeforeFill = true;
            // 
            // cUDataGridViewTextBoxColumn
            // 
            this.cUDataGridViewTextBoxColumn.DataPropertyName = "CU";
            this.cUDataGridViewTextBoxColumn.HeaderText = "CU";
            this.cUDataGridViewTextBoxColumn.Name = "cUDataGridViewTextBoxColumn";
            // 
            // nOMALDataGridViewTextBoxColumn
            // 
            this.nOMALDataGridViewTextBoxColumn.DataPropertyName = "NOMAL";
            this.nOMALDataGridViewTextBoxColumn.HeaderText = "NOMAL";
            this.nOMALDataGridViewTextBoxColumn.Name = "nOMALDataGridViewTextBoxColumn";
            // 
            // cARRDataGridViewTextBoxColumn
            // 
            this.cARRDataGridViewTextBoxColumn.DataPropertyName = "CARR";
            this.cARRDataGridViewTextBoxColumn.HeaderText = "CARR";
            this.cARRDataGridViewTextBoxColumn.Name = "cARRDataGridViewTextBoxColumn";
            // 
            // pROMDataGridViewTextBoxColumn
            // 
            this.pROMDataGridViewTextBoxColumn.DataPropertyName = "PROM";
            this.pROMDataGridViewTextBoxColumn.HeaderText = "PROM";
            this.pROMDataGridViewTextBoxColumn.Name = "pROMDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmAlumno";
            this.Text = "Datos de los alumnos";
            this.Load += new System.EventHandler(this.FrmAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DSAlumno dSAlumno;
        private System.Windows.Forms.BindingSource aLUMBindingSource;
        private DSAlumnoTableAdapters.ALUMTableAdapter aLUMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROMDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}