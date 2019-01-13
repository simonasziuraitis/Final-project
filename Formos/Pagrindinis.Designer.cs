namespace ApsipirkimoSkaiciuokle
{
    partial class Pagrindinis
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
            this.buttonMitybosPlanas = new System.Windows.Forms.Button();
            this.groupBoxReceptai = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxReceptaiReceptoPavadinimas = new System.Windows.Forms.ComboBox();
            this.buttonReceptaiIstrinti = new System.Windows.Forms.Button();
            this.buttonReceptaiAtnaujinti = new System.Windows.Forms.Button();
            this.buttonReceptaiNaujas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.receptaiDataSet = new ApsipirkimoSkaiciuokle.ReceptaiDataSet();
            this.receptaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receptaiTableAdapter = new ApsipirkimoSkaiciuokle.ReceptaiDataSetTableAdapters.ReceptaiTableAdapter();
            this.buttonReceptai = new System.Windows.Forms.Button();
            this.groupBoxMitybosPlanas = new System.Windows.Forms.GroupBox();
            this.buttonMitybosPlanasIstrinti = new System.Windows.Forms.Button();
            this.buttonMitybosPlanasIstrintiPlana = new System.Windows.Forms.Button();
            this.buttonMitybosPlanasSkaiciuoti = new System.Windows.Forms.Button();
            this.dataGridViewMitybosPlanas = new System.Windows.Forms.DataGridView();
            this.groupBoxNustatymai = new System.Windows.Forms.GroupBox();
            this.buttonAtnaujintiNustatymus = new System.Windows.Forms.Button();
            this.textBoxNustatymaiPorcijuKiekis = new System.Windows.Forms.TextBox();
            this.textBoxNustatymaiDienuSkaicius = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.receptaiDataSet1 = new ApsipirkimoSkaiciuokle.ReceptaiDataSet1();
            this.receptaiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.receptaiTableAdapter1 = new ApsipirkimoSkaiciuokle.ReceptaiDataSet1TableAdapters.ReceptaiTableAdapter();
            this.buttonNustatymai = new System.Windows.Forms.Button();
            this.receptaiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receptaiDataSet3 = new ApsipirkimoSkaiciuokle.ReceptaiDataSet3();
            this.mitybosPlanasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mitybosPlanasTableAdapter = new ApsipirkimoSkaiciuokle.ReceptaiDataSet3TableAdapters.MitybosPlanasTableAdapter();
            this.receptaiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.receptaiDataSet4 = new ApsipirkimoSkaiciuokle.ReceptaiDataSet4();
            this.nustatymaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nustatymaiTableAdapter = new ApsipirkimoSkaiciuokle.ReceptaiDataSet4TableAdapters.NustatymaiTableAdapter();
            this.ingridientasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiekisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matavimoVienetasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.buttonReceptaiIstrintiEilute = new System.Windows.Forms.Button();
            this.groupBoxReceptai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiBindingSource)).BeginInit();
            this.groupBoxMitybosPlanas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMitybosPlanas)).BeginInit();
            this.groupBoxNustatymai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitybosPlanasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nustatymaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMitybosPlanas
            // 
            this.buttonMitybosPlanas.Location = new System.Drawing.Point(25, 23);
            this.buttonMitybosPlanas.Name = "buttonMitybosPlanas";
            this.buttonMitybosPlanas.Size = new System.Drawing.Size(162, 106);
            this.buttonMitybosPlanas.TabIndex = 2;
            this.buttonMitybosPlanas.Text = "Mitybos Planas";
            this.buttonMitybosPlanas.UseVisualStyleBackColor = true;
            this.buttonMitybosPlanas.Click += new System.EventHandler(this.buttonMitybosPlanas_Click);
            // 
            // groupBoxReceptai
            // 
            this.groupBoxReceptai.Controls.Add(this.buttonReceptaiIstrintiEilute);
            this.groupBoxReceptai.Controls.Add(this.dataGridView1);
            this.groupBoxReceptai.Controls.Add(this.comboBoxReceptaiReceptoPavadinimas);
            this.groupBoxReceptai.Controls.Add(this.buttonReceptaiIstrinti);
            this.groupBoxReceptai.Controls.Add(this.buttonReceptaiAtnaujinti);
            this.groupBoxReceptai.Controls.Add(this.buttonReceptaiNaujas);
            this.groupBoxReceptai.Controls.Add(this.label1);
            this.groupBoxReceptai.Location = new System.Drawing.Point(206, 23);
            this.groupBoxReceptai.Name = "groupBoxReceptai";
            this.groupBoxReceptai.Size = new System.Drawing.Size(612, 529);
            this.groupBoxReceptai.TabIndex = 0;
            this.groupBoxReceptai.TabStop = false;
            this.groupBoxReceptai.Text = "Receptai";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ingridientasDataGridViewTextBoxColumn,
            this.kiekisDataGridViewTextBoxColumn,
            this.matavimoVienetasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.receptaiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(551, 351);
            this.dataGridView1.TabIndex = 8;
            // 
            // comboBoxReceptaiReceptoPavadinimas
            // 
            this.comboBoxReceptaiReceptoPavadinimas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxReceptaiReceptoPavadinimas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReceptaiReceptoPavadinimas.FormattingEnabled = true;
            this.comboBoxReceptaiReceptoPavadinimas.Location = new System.Drawing.Point(219, 37);
            this.comboBoxReceptaiReceptoPavadinimas.Name = "comboBoxReceptaiReceptoPavadinimas";
            this.comboBoxReceptaiReceptoPavadinimas.Size = new System.Drawing.Size(370, 28);
            this.comboBoxReceptaiReceptoPavadinimas.TabIndex = 7;
            this.comboBoxReceptaiReceptoPavadinimas.SelectedIndexChanged += new System.EventHandler(this.comboBoxReceptaiReceptoPavadinimas_SelectedIndexChanged);
            this.comboBoxReceptaiReceptoPavadinimas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxReceptaiReceptoPavadinimas_MouseClick);
            // 
            // buttonReceptaiIstrinti
            // 
            this.buttonReceptaiIstrinti.Location = new System.Drawing.Point(378, 449);
            this.buttonReceptaiIstrinti.Name = "buttonReceptaiIstrinti";
            this.buttonReceptaiIstrinti.Size = new System.Drawing.Size(104, 60);
            this.buttonReceptaiIstrinti.TabIndex = 5;
            this.buttonReceptaiIstrinti.Text = "Istrinti recepta";
            this.buttonReceptaiIstrinti.UseVisualStyleBackColor = true;
            this.buttonReceptaiIstrinti.Click += new System.EventHandler(this.buttonReceptaiIstrinti_Click);
            // 
            // buttonReceptaiAtnaujinti
            // 
            this.buttonReceptaiAtnaujinti.Location = new System.Drawing.Point(158, 449);
            this.buttonReceptaiAtnaujinti.Name = "buttonReceptaiAtnaujinti";
            this.buttonReceptaiAtnaujinti.Size = new System.Drawing.Size(104, 60);
            this.buttonReceptaiAtnaujinti.TabIndex = 4;
            this.buttonReceptaiAtnaujinti.Text = "Atnaujinti";
            this.buttonReceptaiAtnaujinti.UseVisualStyleBackColor = true;
            this.buttonReceptaiAtnaujinti.Click += new System.EventHandler(this.buttonReceptaiAtnaujinti_Click);
            // 
            // buttonReceptaiNaujas
            // 
            this.buttonReceptaiNaujas.Location = new System.Drawing.Point(488, 449);
            this.buttonReceptaiNaujas.Name = "buttonReceptaiNaujas";
            this.buttonReceptaiNaujas.Size = new System.Drawing.Size(104, 60);
            this.buttonReceptaiNaujas.TabIndex = 3;
            this.buttonReceptaiNaujas.Text = "Naujas receptas";
            this.buttonReceptaiNaujas.UseVisualStyleBackColor = true;
            this.buttonReceptaiNaujas.Click += new System.EventHandler(this.buttonReceptaiNaujas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recepto pavadinimas";
            // 
            // receptaiDataSet
            // 
            this.receptaiDataSet.DataSetName = "ReceptaiDataSet";
            this.receptaiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receptaiBindingSource
            // 
            this.receptaiBindingSource.DataMember = "Receptai";
            this.receptaiBindingSource.DataSource = this.receptaiDataSet;
            // 
            // receptaiTableAdapter
            // 
            this.receptaiTableAdapter.ClearBeforeFill = true;
            // 
            // buttonReceptai
            // 
            this.buttonReceptai.Location = new System.Drawing.Point(25, 135);
            this.buttonReceptai.Name = "buttonReceptai";
            this.buttonReceptai.Size = new System.Drawing.Size(162, 106);
            this.buttonReceptai.TabIndex = 1;
            this.buttonReceptai.Text = "Receptai";
            this.buttonReceptai.UseVisualStyleBackColor = true;
            this.buttonReceptai.Click += new System.EventHandler(this.buttonReceptai_Click);
            // 
            // groupBoxMitybosPlanas
            // 
            this.groupBoxMitybosPlanas.Controls.Add(this.buttonMitybosPlanasIstrinti);
            this.groupBoxMitybosPlanas.Controls.Add(this.buttonMitybosPlanasIstrintiPlana);
            this.groupBoxMitybosPlanas.Controls.Add(this.buttonMitybosPlanasSkaiciuoti);
            this.groupBoxMitybosPlanas.Controls.Add(this.dataGridViewMitybosPlanas);
            this.groupBoxMitybosPlanas.Location = new System.Drawing.Point(206, 23);
            this.groupBoxMitybosPlanas.Name = "groupBoxMitybosPlanas";
            this.groupBoxMitybosPlanas.Size = new System.Drawing.Size(612, 529);
            this.groupBoxMitybosPlanas.TabIndex = 3;
            this.groupBoxMitybosPlanas.TabStop = false;
            this.groupBoxMitybosPlanas.Text = "Mitybos planas";
            this.groupBoxMitybosPlanas.Visible = false;
            // 
            // buttonMitybosPlanasIstrinti
            // 
            this.buttonMitybosPlanasIstrinti.Location = new System.Drawing.Point(357, 475);
            this.buttonMitybosPlanasIstrinti.Name = "buttonMitybosPlanasIstrinti";
            this.buttonMitybosPlanasIstrinti.Size = new System.Drawing.Size(113, 39);
            this.buttonMitybosPlanasIstrinti.TabIndex = 10;
            this.buttonMitybosPlanasIstrinti.Text = "Istrinti";
            this.buttonMitybosPlanasIstrinti.UseVisualStyleBackColor = true;
            this.buttonMitybosPlanasIstrinti.Click += new System.EventHandler(this.buttonMitybosPlanasIstrinti_Click);
            // 
            // buttonMitybosPlanasIstrintiPlana
            // 
            this.buttonMitybosPlanasIstrintiPlana.Location = new System.Drawing.Point(476, 475);
            this.buttonMitybosPlanasIstrintiPlana.Name = "buttonMitybosPlanasIstrintiPlana";
            this.buttonMitybosPlanasIstrintiPlana.Size = new System.Drawing.Size(113, 39);
            this.buttonMitybosPlanasIstrintiPlana.TabIndex = 9;
            this.buttonMitybosPlanasIstrintiPlana.Text = "Istrinti plana";
            this.buttonMitybosPlanasIstrintiPlana.UseVisualStyleBackColor = true;
            this.buttonMitybosPlanasIstrintiPlana.Click += new System.EventHandler(this.buttonMitybosPlanasIstrintiPlana_Click);
            // 
            // buttonMitybosPlanasSkaiciuoti
            // 
            this.buttonMitybosPlanasSkaiciuoti.Location = new System.Drawing.Point(238, 475);
            this.buttonMitybosPlanasSkaiciuoti.Name = "buttonMitybosPlanasSkaiciuoti";
            this.buttonMitybosPlanasSkaiciuoti.Size = new System.Drawing.Size(113, 39);
            this.buttonMitybosPlanasSkaiciuoti.TabIndex = 8;
            this.buttonMitybosPlanasSkaiciuoti.Text = "Skaiciuoti";
            this.buttonMitybosPlanasSkaiciuoti.UseVisualStyleBackColor = true;
            this.buttonMitybosPlanasSkaiciuoti.Click += new System.EventHandler(this.buttonMitybosPlanasSkaiciuoti_Click);
            // 
            // dataGridViewMitybosPlanas
            // 
            this.dataGridViewMitybosPlanas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMitybosPlanas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMitybosPlanas.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewMitybosPlanas.Name = "dataGridViewMitybosPlanas";
            this.dataGridViewMitybosPlanas.RowTemplate.Height = 28;
            this.dataGridViewMitybosPlanas.Size = new System.Drawing.Size(583, 423);
            this.dataGridViewMitybosPlanas.TabIndex = 0;
            // 
            // groupBoxNustatymai
            // 
            this.groupBoxNustatymai.Controls.Add(this.buttonAtnaujintiNustatymus);
            this.groupBoxNustatymai.Controls.Add(this.textBoxNustatymaiPorcijuKiekis);
            this.groupBoxNustatymai.Controls.Add(this.textBoxNustatymaiDienuSkaicius);
            this.groupBoxNustatymai.Controls.Add(this.label6);
            this.groupBoxNustatymai.Controls.Add(this.label5);
            this.groupBoxNustatymai.Location = new System.Drawing.Point(206, 23);
            this.groupBoxNustatymai.Name = "groupBoxNustatymai";
            this.groupBoxNustatymai.Size = new System.Drawing.Size(612, 529);
            this.groupBoxNustatymai.TabIndex = 8;
            this.groupBoxNustatymai.TabStop = false;
            this.groupBoxNustatymai.Text = "Nustatymai";
            this.groupBoxNustatymai.Visible = false;
            // 
            // buttonAtnaujintiNustatymus
            // 
            this.buttonAtnaujintiNustatymus.Location = new System.Drawing.Point(406, 472);
            this.buttonAtnaujintiNustatymus.Name = "buttonAtnaujintiNustatymus";
            this.buttonAtnaujintiNustatymus.Size = new System.Drawing.Size(183, 41);
            this.buttonAtnaujintiNustatymus.TabIndex = 4;
            this.buttonAtnaujintiNustatymus.Text = "Atnaujinti nustatymus";
            this.buttonAtnaujintiNustatymus.UseVisualStyleBackColor = true;
            this.buttonAtnaujintiNustatymus.Click += new System.EventHandler(this.buttonAtnaujintiNustatymus_Click);
            // 
            // textBoxNustatymaiPorcijuKiekis
            // 
            this.textBoxNustatymaiPorcijuKiekis.Location = new System.Drawing.Point(489, 91);
            this.textBoxNustatymaiPorcijuKiekis.Name = "textBoxNustatymaiPorcijuKiekis";
            this.textBoxNustatymaiPorcijuKiekis.Size = new System.Drawing.Size(100, 26);
            this.textBoxNustatymaiPorcijuKiekis.TabIndex = 3;
            // 
            // textBoxNustatymaiDienuSkaicius
            // 
            this.textBoxNustatymaiDienuSkaicius.Location = new System.Drawing.Point(489, 37);
            this.textBoxNustatymaiDienuSkaicius.Name = "textBoxNustatymaiDienuSkaicius";
            this.textBoxNustatymaiDienuSkaicius.Size = new System.Drawing.Size(100, 26);
            this.textBoxNustatymaiDienuSkaicius.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Porciju kiekis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dienu skaicius naudojamas mitybos planui";
            // 
            // receptaiDataSet1
            // 
            this.receptaiDataSet1.DataSetName = "ReceptaiDataSet1";
            this.receptaiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receptaiBindingSource1
            // 
            this.receptaiBindingSource1.DataMember = "Receptai";
            this.receptaiBindingSource1.DataSource = this.receptaiDataSet1;
            // 
            // receptaiTableAdapter1
            // 
            this.receptaiTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonNustatymai
            // 
            this.buttonNustatymai.Location = new System.Drawing.Point(25, 247);
            this.buttonNustatymai.Name = "buttonNustatymai";
            this.buttonNustatymai.Size = new System.Drawing.Size(162, 106);
            this.buttonNustatymai.TabIndex = 4;
            this.buttonNustatymai.Text = "Nustatymai";
            this.buttonNustatymai.UseVisualStyleBackColor = true;
            this.buttonNustatymai.Click += new System.EventHandler(this.buttonNustatymai_Click);
            // 
            // receptaiDataSetBindingSource
            // 
            this.receptaiDataSetBindingSource.DataSource = this.receptaiDataSet;
            this.receptaiDataSetBindingSource.Position = 0;
            // 
            // receptaiDataSet3
            // 
            this.receptaiDataSet3.DataSetName = "ReceptaiDataSet3";
            this.receptaiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mitybosPlanasBindingSource
            // 
            this.mitybosPlanasBindingSource.DataMember = "MitybosPlanas";
            this.mitybosPlanasBindingSource.DataSource = this.receptaiDataSet3;
            // 
            // mitybosPlanasTableAdapter
            // 
            this.mitybosPlanasTableAdapter.ClearBeforeFill = true;
            // 
            // receptaiBindingSource2
            // 
            this.receptaiBindingSource2.DataMember = "Receptai";
            this.receptaiBindingSource2.DataSource = this.receptaiDataSetBindingSource;
            // 
            // receptaiDataSet4
            // 
            this.receptaiDataSet4.DataSetName = "ReceptaiDataSet4";
            this.receptaiDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nustatymaiBindingSource
            // 
            this.nustatymaiBindingSource.DataMember = "Nustatymai";
            this.nustatymaiBindingSource.DataSource = this.receptaiDataSet4;
            // 
            // nustatymaiTableAdapter
            // 
            this.nustatymaiTableAdapter.ClearBeforeFill = true;
            // 
            // ingridientasDataGridViewTextBoxColumn
            // 
            this.ingridientasDataGridViewTextBoxColumn.DataPropertyName = "Ingridientas";
            this.ingridientasDataGridViewTextBoxColumn.HeaderText = "Ingridientas";
            this.ingridientasDataGridViewTextBoxColumn.Name = "ingridientasDataGridViewTextBoxColumn";
            // 
            // kiekisDataGridViewTextBoxColumn
            // 
            this.kiekisDataGridViewTextBoxColumn.DataPropertyName = "Kiekis";
            this.kiekisDataGridViewTextBoxColumn.HeaderText = "Kiekis";
            this.kiekisDataGridViewTextBoxColumn.Name = "kiekisDataGridViewTextBoxColumn";
            // 
            // matavimoVienetasDataGridViewTextBoxColumn
            // 
            this.matavimoVienetasDataGridViewTextBoxColumn.DataPropertyName = "Vienetas";
            this.matavimoVienetasDataGridViewTextBoxColumn.HeaderText = "Vienetas";
            this.matavimoVienetasDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Vnt",
            "Kg",
            "L"});
            this.matavimoVienetasDataGridViewTextBoxColumn.Name = "matavimoVienetasDataGridViewTextBoxColumn";
            this.matavimoVienetasDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.matavimoVienetasDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // buttonReceptaiIstrintiEilute
            // 
            this.buttonReceptaiIstrintiEilute.Location = new System.Drawing.Point(268, 449);
            this.buttonReceptaiIstrintiEilute.Name = "buttonReceptaiIstrintiEilute";
            this.buttonReceptaiIstrintiEilute.Size = new System.Drawing.Size(104, 60);
            this.buttonReceptaiIstrintiEilute.TabIndex = 9;
            this.buttonReceptaiIstrintiEilute.Text = "Istrinti eilute";
            this.buttonReceptaiIstrintiEilute.UseVisualStyleBackColor = true;
            this.buttonReceptaiIstrintiEilute.Click += new System.EventHandler(this.buttonReceptaiIstrintiEilute_Click);
            // 
            // Pagrindinis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 586);
            this.Controls.Add(this.groupBoxReceptai);
            this.Controls.Add(this.buttonNustatymai);
            this.Controls.Add(this.buttonMitybosPlanas);
            this.Controls.Add(this.buttonReceptai);
            this.Controls.Add(this.groupBoxMitybosPlanas);
            this.Controls.Add(this.groupBoxNustatymai);
            this.Name = "Pagrindinis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagrindinis";
            this.groupBoxReceptai.ResumeLayout(false);
            this.groupBoxReceptai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiBindingSource)).EndInit();
            this.groupBoxMitybosPlanas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMitybosPlanas)).EndInit();
            this.groupBoxNustatymai.ResumeLayout(false);
            this.groupBoxNustatymai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitybosPlanasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nustatymaiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNustatymai;
        private System.Windows.Forms.GroupBox groupBoxReceptai;
        private System.Windows.Forms.Label label1;
        private ReceptaiDataSet receptaiDataSet;
        private System.Windows.Forms.BindingSource receptaiBindingSource;
        private ReceptaiDataSetTableAdapters.ReceptaiTableAdapter receptaiTableAdapter;
        private System.Windows.Forms.Button buttonReceptaiIstrinti;
        private System.Windows.Forms.Button buttonReceptaiAtnaujinti;
        private System.Windows.Forms.Button buttonReceptaiNaujas;
        private System.Windows.Forms.Button buttonReceptai;
        private System.Windows.Forms.ComboBox comboBoxReceptaiReceptoPavadinimas;
        private System.Windows.Forms.Button buttonMitybosPlanas;
        private System.Windows.Forms.GroupBox groupBoxMitybosPlanas;
        private System.Windows.Forms.DataGridView dataGridViewMitybosPlanas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ReceptaiDataSet1 receptaiDataSet1;
        private System.Windows.Forms.BindingSource receptaiBindingSource1;
        private ReceptaiDataSet1TableAdapters.ReceptaiTableAdapter receptaiTableAdapter1;
        private System.Windows.Forms.GroupBox groupBoxNustatymai;
        private System.Windows.Forms.TextBox textBoxNustatymaiPorcijuKiekis;
        private System.Windows.Forms.TextBox textBoxNustatymaiDienuSkaicius;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAtnaujintiNustatymus;
        private System.Windows.Forms.BindingSource receptaiDataSetBindingSource;
        private ReceptaiDataSet3 receptaiDataSet3;
        private System.Windows.Forms.BindingSource mitybosPlanasBindingSource;
        private ReceptaiDataSet3TableAdapters.MitybosPlanasTableAdapter mitybosPlanasTableAdapter;
        private System.Windows.Forms.BindingSource receptaiBindingSource2;
        private System.Windows.Forms.Button buttonMitybosPlanasIstrintiPlana;
        private System.Windows.Forms.Button buttonMitybosPlanasSkaiciuoti;
        private ReceptaiDataSet4 receptaiDataSet4;
        private System.Windows.Forms.BindingSource nustatymaiBindingSource;
        private ReceptaiDataSet4TableAdapters.NustatymaiTableAdapter nustatymaiTableAdapter;
        private System.Windows.Forms.Button buttonMitybosPlanasIstrinti;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingridientasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiekisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn matavimoVienetasDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonReceptaiIstrintiEilute;
    }
}

