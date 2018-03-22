namespace Tarea5.Tablas
{
    partial class FrmInstituciones
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
            this.iDINSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMINSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIGLASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t4INSTITUCIÓNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new Tarea5.ds();
            this.t4INSTITUCIÓNTableAdapter = new Tarea5.dsTableAdapters.T4INSTITUCIÓNTableAdapter();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t4INSTITUCIÓNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDINSTDataGridViewTextBoxColumn,
            this.nOMINSDataGridViewTextBoxColumn,
            this.sIGLASDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.t4INSTITUCIÓNBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDINSTDataGridViewTextBoxColumn
            // 
            this.iDINSTDataGridViewTextBoxColumn.DataPropertyName = "IDINST";
            this.iDINSTDataGridViewTextBoxColumn.HeaderText = "IDINST";
            this.iDINSTDataGridViewTextBoxColumn.Name = "iDINSTDataGridViewTextBoxColumn";
            // 
            // nOMINSDataGridViewTextBoxColumn
            // 
            this.nOMINSDataGridViewTextBoxColumn.DataPropertyName = "NOMINS";
            this.nOMINSDataGridViewTextBoxColumn.HeaderText = "NOMINS";
            this.nOMINSDataGridViewTextBoxColumn.Name = "nOMINSDataGridViewTextBoxColumn";
            // 
            // sIGLASDataGridViewTextBoxColumn
            // 
            this.sIGLASDataGridViewTextBoxColumn.DataPropertyName = "SIGLAS";
            this.sIGLASDataGridViewTextBoxColumn.HeaderText = "SIGLAS";
            this.sIGLASDataGridViewTextBoxColumn.Name = "sIGLASDataGridViewTextBoxColumn";
            // 
            // t4INSTITUCIÓNBindingSource
            // 
            this.t4INSTITUCIÓNBindingSource.DataMember = "T4INSTITUCIÓN";
            this.t4INSTITUCIÓNBindingSource.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t4INSTITUCIÓNTableAdapter
            // 
            this.t4INSTITUCIÓNTableAdapter.ClearBeforeFill = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(191, 220);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FrmInstituciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 304);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmInstituciones";
            this.Text = "Tabla Instituciones";
            this.Load += new System.EventHandler(this.FrmInstituciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t4INSTITUCIÓNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ds ds;
        private System.Windows.Forms.BindingSource t4INSTITUCIÓNBindingSource;
        private dsTableAdapters.T4INSTITUCIÓNTableAdapter t4INSTITUCIÓNTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDINSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMINSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIGLASDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnActualizar;
    }
}