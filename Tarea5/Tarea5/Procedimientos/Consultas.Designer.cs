namespace Tarea5.Procedimientos
{
    partial class Consultas
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
            this.btnConsulta1 = new System.Windows.Forms.Button();
            this.btnConsulta2 = new System.Windows.Forms.Button();
            this.btnConsulta3 = new System.Windows.Forms.Button();
            this.btnConsulta4 = new System.Windows.Forms.Button();
            this.tP4CONSULTA4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new Tarea5.ds();
            this.tP4CONSULTA1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tP4CONSULTA1TableAdapter = new Tarea5.dsTableAdapters.TP4CONSULTA1TableAdapter();
            this.tP4CONSULTA2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tP4CONSULTA2TableAdapter = new Tarea5.dsTableAdapters.TP4CONSULTA2TableAdapter();
            this.tP4CONSULTA3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tP4CONSULTA3TableAdapter = new Tarea5.dsTableAdapters.TP4CONSULTA3TableAdapter();
            this.tP4CONSULTA4TableAdapter = new Tarea5.dsTableAdapters.TP4CONSULTA4TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tP4CONSULTA4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tP4CONSULTA1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tP4CONSULTA2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tP4CONSULTA3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(146, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnConsulta1
            // 
            this.btnConsulta1.Location = new System.Drawing.Point(25, 291);
            this.btnConsulta1.Name = "btnConsulta1";
            this.btnConsulta1.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta1.TabIndex = 1;
            this.btnConsulta1.Text = "Consulta 1";
            this.btnConsulta1.UseVisualStyleBackColor = true;
            this.btnConsulta1.Click += new System.EventHandler(this.btnConsulta1_Click);
            // 
            // btnConsulta2
            // 
            this.btnConsulta2.Location = new System.Drawing.Point(146, 291);
            this.btnConsulta2.Name = "btnConsulta2";
            this.btnConsulta2.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta2.TabIndex = 2;
            this.btnConsulta2.Text = "Consulta 2";
            this.btnConsulta2.UseVisualStyleBackColor = true;
            this.btnConsulta2.Click += new System.EventHandler(this.btnConsulta2_Click);
            // 
            // btnConsulta3
            // 
            this.btnConsulta3.Location = new System.Drawing.Point(269, 291);
            this.btnConsulta3.Name = "btnConsulta3";
            this.btnConsulta3.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta3.TabIndex = 3;
            this.btnConsulta3.Text = "Consulta 3";
            this.btnConsulta3.UseVisualStyleBackColor = true;
            this.btnConsulta3.Click += new System.EventHandler(this.btnConsulta3_Click);
            // 
            // btnConsulta4
            // 
            this.btnConsulta4.Location = new System.Drawing.Point(416, 291);
            this.btnConsulta4.Name = "btnConsulta4";
            this.btnConsulta4.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta4.TabIndex = 4;
            this.btnConsulta4.Text = "Consulta 4";
            this.btnConsulta4.UseVisualStyleBackColor = true;
            this.btnConsulta4.Click += new System.EventHandler(this.btnConsulta4_Click);
            // 
            // tP4CONSULTA4BindingSource
            // 
            this.tP4CONSULTA4BindingSource.DataMember = "TP4CONSULTA4";
            this.tP4CONSULTA4BindingSource.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tP4CONSULTA1BindingSource
            // 
            this.tP4CONSULTA1BindingSource.DataMember = "TP4CONSULTA1";
            this.tP4CONSULTA1BindingSource.DataSource = this.ds;
            // 
            // tP4CONSULTA1TableAdapter
            // 
            this.tP4CONSULTA1TableAdapter.ClearBeforeFill = true;
            // 
            // tP4CONSULTA2BindingSource
            // 
            this.tP4CONSULTA2BindingSource.DataMember = "TP4CONSULTA2";
            this.tP4CONSULTA2BindingSource.DataSource = this.ds;
            // 
            // tP4CONSULTA2TableAdapter
            // 
            this.tP4CONSULTA2TableAdapter.ClearBeforeFill = true;
            // 
            // tP4CONSULTA3BindingSource
            // 
            this.tP4CONSULTA3BindingSource.DataMember = "TP4CONSULTA3";
            this.tP4CONSULTA3BindingSource.DataSource = this.ds;
            // 
            // tP4CONSULTA3TableAdapter
            // 
            this.tP4CONSULTA3TableAdapter.ClearBeforeFill = true;
            // 
            // tP4CONSULTA4TableAdapter
            // 
            this.tP4CONSULTA4TableAdapter.ClearBeforeFill = true;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 432);
            this.Controls.Add(this.btnConsulta4);
            this.Controls.Add(this.btnConsulta3);
            this.Controls.Add(this.btnConsulta2);
            this.Controls.Add(this.btnConsulta1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tP4CONSULTA4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tP4CONSULTA1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tP4CONSULTA2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tP4CONSULTA3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ds ds;
        private System.Windows.Forms.BindingSource tP4CONSULTA1BindingSource;
        private dsTableAdapters.TP4CONSULTA1TableAdapter tP4CONSULTA1TableAdapter;
        private System.Windows.Forms.BindingSource tP4CONSULTA2BindingSource;
        private dsTableAdapters.TP4CONSULTA2TableAdapter tP4CONSULTA2TableAdapter;
        private System.Windows.Forms.BindingSource tP4CONSULTA3BindingSource;
        private dsTableAdapters.TP4CONSULTA3TableAdapter tP4CONSULTA3TableAdapter;
        private System.Windows.Forms.BindingSource tP4CONSULTA4BindingSource;
        private dsTableAdapters.TP4CONSULTA4TableAdapter tP4CONSULTA4TableAdapter;
        private System.Windows.Forms.Button btnConsulta1;
        private System.Windows.Forms.Button btnConsulta2;
        private System.Windows.Forms.Button btnConsulta3;
        private System.Windows.Forms.Button btnConsulta4;
    }
}