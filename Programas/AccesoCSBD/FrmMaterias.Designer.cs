namespace AccesoCSBD {
    partial class FrmMaterias {
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
            this.dSAlumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AccesoCSBD.DataSet1();
            this.mATERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mATERTableAdapter = new AccesoCSBD.DataSet1TableAdapters.MATERTableAdapter();
            this.cLAVEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMMATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREDSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAlumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLAVEMDataGridViewTextBoxColumn,
            this.nOMMATDataGridViewTextBoxColumn,
            this.cREDSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mATERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dSAlumno
            // 
            this.dSAlumno.DataSetName = "DSAlumno";
            this.dSAlumno.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSAlumnoBindingSource
            // 
            this.dSAlumnoBindingSource.DataSource = this.dSAlumno;
            this.dSAlumnoBindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mATERBindingSource
            // 
            this.mATERBindingSource.DataMember = "MATER";
            this.mATERBindingSource.DataSource = this.dataSet1;
            // 
            // mATERTableAdapter
            // 
            this.mATERTableAdapter.ClearBeforeFill = true;
            // 
            // cLAVEMDataGridViewTextBoxColumn
            // 
            this.cLAVEMDataGridViewTextBoxColumn.DataPropertyName = "CLAVEM";
            this.cLAVEMDataGridViewTextBoxColumn.HeaderText = "CLAVEM";
            this.cLAVEMDataGridViewTextBoxColumn.Name = "cLAVEMDataGridViewTextBoxColumn";
            // 
            // nOMMATDataGridViewTextBoxColumn
            // 
            this.nOMMATDataGridViewTextBoxColumn.DataPropertyName = "NOMMAT";
            this.nOMMATDataGridViewTextBoxColumn.HeaderText = "NOMMAT";
            this.nOMMATDataGridViewTextBoxColumn.Name = "nOMMATDataGridViewTextBoxColumn";
            // 
            // cREDSDataGridViewTextBoxColumn
            // 
            this.cREDSDataGridViewTextBoxColumn.DataPropertyName = "CREDS";
            this.cREDSDataGridViewTextBoxColumn.HeaderText = "CREDS";
            this.cREDSDataGridViewTextBoxColumn.Name = "cREDSDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmMaterias";
            this.Text = "Datos de las Materias";
            this.Load += new System.EventHandler(this.FrmMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAlumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DSAlumno dSAlumno;
        private System.Windows.Forms.BindingSource dSAlumnoBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource mATERBindingSource;
        private DataSet1TableAdapters.MATERTableAdapter mATERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLAVEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMMATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREDSDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}