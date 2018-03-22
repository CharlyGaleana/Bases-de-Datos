namespace Tarea5.Tablas
{
    partial class FrmCampus
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDCAMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMCAMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOMICILIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFENODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIUDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROFESORESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDINSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t4CAMPUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new Tarea5.ds();
            this.t4CAMPUSTableAdapter = new Tarea5.dsTableAdapters.T4CAMPUSTableAdapter();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t4CAMPUSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCAMPDataGridViewTextBoxColumn,
            this.nOMCAMPDataGridViewTextBoxColumn,
            this.dOMICILIODataGridViewTextBoxColumn,
            this.tELEFENODataGridViewTextBoxColumn,
            this.cIUDADDataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn,
            this.pROFESORESDataGridViewTextBoxColumn,
            this.iDINSTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.t4CAMPUSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(48, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDCAMPDataGridViewTextBoxColumn
            // 
            this.iDCAMPDataGridViewTextBoxColumn.DataPropertyName = "IDCAMP";
            this.iDCAMPDataGridViewTextBoxColumn.HeaderText = "IDCAMP";
            this.iDCAMPDataGridViewTextBoxColumn.Name = "iDCAMPDataGridViewTextBoxColumn";
            // 
            // nOMCAMPDataGridViewTextBoxColumn
            // 
            this.nOMCAMPDataGridViewTextBoxColumn.DataPropertyName = "NOMCAMP";
            this.nOMCAMPDataGridViewTextBoxColumn.HeaderText = "NOMCAMP";
            this.nOMCAMPDataGridViewTextBoxColumn.Name = "nOMCAMPDataGridViewTextBoxColumn";
            // 
            // dOMICILIODataGridViewTextBoxColumn
            // 
            this.dOMICILIODataGridViewTextBoxColumn.DataPropertyName = "DOMICILIO";
            this.dOMICILIODataGridViewTextBoxColumn.HeaderText = "DOMICILIO";
            this.dOMICILIODataGridViewTextBoxColumn.Name = "dOMICILIODataGridViewTextBoxColumn";
            // 
            // tELEFENODataGridViewTextBoxColumn
            // 
            this.tELEFENODataGridViewTextBoxColumn.DataPropertyName = "TELEFENO";
            this.tELEFENODataGridViewTextBoxColumn.HeaderText = "TELEFENO";
            this.tELEFENODataGridViewTextBoxColumn.Name = "tELEFENODataGridViewTextBoxColumn";
            // 
            // cIUDADDataGridViewTextBoxColumn
            // 
            this.cIUDADDataGridViewTextBoxColumn.DataPropertyName = "CIUDAD";
            this.cIUDADDataGridViewTextBoxColumn.HeaderText = "CIUDAD";
            this.cIUDADDataGridViewTextBoxColumn.Name = "cIUDADDataGridViewTextBoxColumn";
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            // 
            // pROFESORESDataGridViewTextBoxColumn
            // 
            this.pROFESORESDataGridViewTextBoxColumn.DataPropertyName = "PROFESORES";
            this.pROFESORESDataGridViewTextBoxColumn.HeaderText = "PROFESORES";
            this.pROFESORESDataGridViewTextBoxColumn.Name = "pROFESORESDataGridViewTextBoxColumn";
            // 
            // iDINSTDataGridViewTextBoxColumn
            // 
            this.iDINSTDataGridViewTextBoxColumn.DataPropertyName = "IDINST";
            this.iDINSTDataGridViewTextBoxColumn.HeaderText = "IDINST";
            this.iDINSTDataGridViewTextBoxColumn.Name = "iDINSTDataGridViewTextBoxColumn";
            // 
            // t4CAMPUSBindingSource
            // 
            this.t4CAMPUSBindingSource.DataMember = "T4CAMPUS";
            this.t4CAMPUSBindingSource.DataSource = this.dsBindingSource;
            // 
            // dsBindingSource
            // 
            this.dsBindingSource.DataSource = this.ds;
            this.dsBindingSource.Position = 0;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t4CAMPUSTableAdapter
            // 
            this.t4CAMPUSTableAdapter.ClearBeforeFill = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(289, 247);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FrmCampus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 312);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmCampus";
            this.Text = "Tabla Campus";
            this.Load += new System.EventHandler(this.FrmCampus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t4CAMPUSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dsBindingSource;
        private ds ds;
        private System.Windows.Forms.BindingSource t4CAMPUSBindingSource;
        private dsTableAdapters.T4CAMPUSTableAdapter t4CAMPUSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCAMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMCAMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOMICILIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFENODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIUDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROFESORESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDINSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnActualizar;
    }
}