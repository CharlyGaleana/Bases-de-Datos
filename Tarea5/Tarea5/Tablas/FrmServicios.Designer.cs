namespace Tarea5.Tablas
{
    partial class FrmServicios
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
            this.iDSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMSERVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t4SERVICIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new Tarea5.ds();
            this.t4SERVICIOTableAdapter = new Tarea5.dsTableAdapters.T4SERVICIOTableAdapter();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t4SERVICIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSDataGridViewTextBoxColumn,
            this.nOMSERVDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.t4SERVICIOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDSDataGridViewTextBoxColumn
            // 
            this.iDSDataGridViewTextBoxColumn.DataPropertyName = "IDS";
            this.iDSDataGridViewTextBoxColumn.HeaderText = "IDS";
            this.iDSDataGridViewTextBoxColumn.Name = "iDSDataGridViewTextBoxColumn";
            // 
            // nOMSERVDataGridViewTextBoxColumn
            // 
            this.nOMSERVDataGridViewTextBoxColumn.DataPropertyName = "NOMSERV";
            this.nOMSERVDataGridViewTextBoxColumn.HeaderText = "NOMSERV";
            this.nOMSERVDataGridViewTextBoxColumn.Name = "nOMSERVDataGridViewTextBoxColumn";
            // 
            // t4SERVICIOBindingSource
            // 
            this.t4SERVICIOBindingSource.DataMember = "T4SERVICIO";
            this.t4SERVICIOBindingSource.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t4SERVICIOTableAdapter
            // 
            this.t4SERVICIOTableAdapter.ClearBeforeFill = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(236, 258);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FrmServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 320);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmServicios";
            this.Text = "Tabla Servicios";
            this.Load += new System.EventHandler(this.FrmServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t4SERVICIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ds ds;
        private System.Windows.Forms.BindingSource t4SERVICIOBindingSource;
        private dsTableAdapters.T4SERVICIOTableAdapter t4SERVICIOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMSERVDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnActualizar;
    }
}