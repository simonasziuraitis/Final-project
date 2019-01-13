namespace ApsipirkimoSkaiciuokle
{
    partial class NaujasReceptas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bIrasyti = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPavadinimas = new System.Windows.Forms.TextBox();
            this.receptaiDataSet2 = new ApsipirkimoSkaiciuokle.ReceptaiDataSet2();
            this.receptaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receptaiTableAdapter = new ApsipirkimoSkaiciuokle.ReceptaiDataSet2TableAdapters.ReceptaiTableAdapter();
            this.Ingridientas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kiekis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vienetas = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bIrasyti);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPavadinimas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 558);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Naujas receptas";
            // 
            // bIrasyti
            // 
            this.bIrasyti.Location = new System.Drawing.Point(299, 493);
            this.bIrasyti.Name = "bIrasyti";
            this.bIrasyti.Size = new System.Drawing.Size(126, 42);
            this.bIrasyti.TabIndex = 3;
            this.bIrasyti.Text = "Irasyti";
            this.bIrasyti.UseVisualStyleBackColor = true;
            this.bIrasyti.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ingridientas,
            this.Kiekis,
            this.Vienetas});
            this.dataGridView1.Location = new System.Drawing.Point(18, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(407, 372);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pavadinimas";
            // 
            // tbPavadinimas
            // 
            this.tbPavadinimas.Location = new System.Drawing.Point(135, 61);
            this.tbPavadinimas.Name = "tbPavadinimas";
            this.tbPavadinimas.Size = new System.Drawing.Size(290, 26);
            this.tbPavadinimas.TabIndex = 0;
            // 
            // receptaiDataSet2
            // 
            this.receptaiDataSet2.DataSetName = "ReceptaiDataSet2";
            this.receptaiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receptaiBindingSource
            // 
            this.receptaiBindingSource.DataMember = "Receptai";
            this.receptaiBindingSource.DataSource = this.receptaiDataSet2;
            // 
            // receptaiTableAdapter
            // 
            this.receptaiTableAdapter.ClearBeforeFill = true;
            // 
            // Ingridientas
            // 
            this.Ingridientas.HeaderText = "Ingridientas";
            this.Ingridientas.Name = "Ingridientas";
            // 
            // Kiekis
            // 
            this.Kiekis.HeaderText = "Kiekis";
            this.Kiekis.Name = "Kiekis";
            // 
            // Vienetas
            // 
            this.Vienetas.HeaderText = "Vienetas";
            this.Vienetas.Items.AddRange(new object[] {
            "Vnt",
            "Kg",
            "L"});
            this.Vienetas.Name = "Vienetas";
            this.Vienetas.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Vienetas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NaujasReceptas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 594);
            this.Controls.Add(this.groupBox1);
            this.Name = "NaujasReceptas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naujas Receptas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPavadinimas;
        private System.Windows.Forms.Button bIrasyti;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ReceptaiDataSet2 receptaiDataSet2;
        private System.Windows.Forms.BindingSource receptaiBindingSource;
        private ReceptaiDataSet2TableAdapters.ReceptaiTableAdapter receptaiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingridientas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kiekis;
        private System.Windows.Forms.DataGridViewComboBoxColumn Vienetas;
    }
}