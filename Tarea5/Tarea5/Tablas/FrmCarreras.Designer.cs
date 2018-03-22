namespace Tarea5.Tablas
{
    partial class FrmCarreras
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
            this.ds = new Tarea5.ds();
            this.t4CARRERABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t4CARRERATableAdapter = new Tarea5.dsTableAdapters.T4CARRERATableAdapter();
            this.iDCARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMCARRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t4CARRERABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCARDataGridViewTextBoxColumn,
            this.iDADataGridViewTextBoxColumn,
            this.nOMCARRDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.t4CARRERABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t4CARRERABindingSource
            // 
            this.t4CARRERABindingSource.DataMember = "T4CARRERA";
            this.t4CARRERABindingSource.DataSource = this.ds;
            // 
            // t4CARRERATableAdapter
            // 
            this.t4CARRERATableAdapter.ClearBeforeFill = true;
            // 
            // iDCARDataGridViewTextBoxColumn
            // 
            this.iDCARDataGridViewTextBoxColumn.DataPropertyName = "IDCAR";
            this.iDCARDataGridViewTextBoxColumn.HeaderText = "IDCAR";
            this.iDCARDataGridViewTextBoxColumn.Name = "iDCARDataGridViewTextBoxColumn";
            // 
            // iDADataGridViewTextBoxColumn
            // 
            this.iDADataGridViewTextBoxColumn.DataPropertyName = "IDA";
            this.iDADataGridViewTextBoxColumn.HeaderText = "IDA";
            this.iDADataGridViewTextBoxColumn.Name = "iDADataGridViewTextBoxColumn";
            // 
            // nOMCARRDataGridViewTextBoxColumn
            // 
            this.nOMCARRDataGridViewTextBoxColumn.DataPropertyName = "NOMCARR";
            this.nOMCARRDataGridViewTextBoxColumn.HeaderText = "NOMCARR";
            this.nOMCARRDataGridViewTextBoxColumn.Name = "nOMCARRDataGridViewTextBoxColumn";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(237, 250);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FrmCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 361);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmCarreras";
            this.Text = "FrmCarreras";
            this.Load += new System.EventHandler(this.FrmCarreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t4CARRERABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ds ds;
        private System.Windows.Forms.BindingSource t4CARRERABindingSource;
        private dsTableAdapters.T4CARRERATableAdapter t4CARRERATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMCARRDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnActualizar;
    }
}