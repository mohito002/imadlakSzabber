namespace hozott
{
    partial class UCReceptModositas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxFogas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxFogas = new System.Windows.Forms.ListBox();
            this.listBoxNyersanyag = new System.Windows.Forms.ListBox();
            this.textBoxNyersanyag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMennyiség = new System.Windows.Forms.TextBox();
            this.labelMennyEgys = new System.Windows.Forms.Label();
            this.buttonHozzaadas = new System.Windows.Forms.Button();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nyersanyagNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyiseg4foDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egysegNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.árDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hozzavaloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzavaloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFogas
            // 
            this.textBoxFogas.Location = new System.Drawing.Point(12, 35);
            this.textBoxFogas.Name = "textBoxFogas";
            this.textBoxFogas.Size = new System.Drawing.Size(125, 27);
            this.textBoxFogas.TabIndex = 0;
            this.textBoxFogas.TextChanged += new System.EventHandler(this.textBoxFogas_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fogás:";
            // 
            // listBoxFogas
            // 
            this.listBoxFogas.FormattingEnabled = true;
            this.listBoxFogas.ItemHeight = 20;
            this.listBoxFogas.Location = new System.Drawing.Point(12, 65);
            this.listBoxFogas.Name = "listBoxFogas";
            this.listBoxFogas.Size = new System.Drawing.Size(125, 324);
            this.listBoxFogas.TabIndex = 2;
            this.listBoxFogas.SelectedIndexChanged += new System.EventHandler(this.listBoxFogas_SelectedIndexChanged);
            // 
            // listBoxNyersanyag
            // 
            this.listBoxNyersanyag.FormattingEnabled = true;
            this.listBoxNyersanyag.ItemHeight = 20;
            this.listBoxNyersanyag.Location = new System.Drawing.Point(703, 65);
            this.listBoxNyersanyag.Name = "listBoxNyersanyag";
            this.listBoxNyersanyag.Size = new System.Drawing.Size(125, 324);
            this.listBoxNyersanyag.TabIndex = 3;
            this.listBoxNyersanyag.SelectedIndexChanged += new System.EventHandler(this.listBoxNyersanyag_SelectedIndexChanged);
            // 
            // textBoxNyersanyag
            // 
            this.textBoxNyersanyag.Location = new System.Drawing.Point(703, 32);
            this.textBoxNyersanyag.Name = "textBoxNyersanyag";
            this.textBoxNyersanyag.Size = new System.Drawing.Size(125, 27);
            this.textBoxNyersanyag.TabIndex = 4;
            this.textBoxNyersanyag.TextChanged += new System.EventHandler(this.textBoxNyersanyag_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(703, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nyersanyag:";
            // 
            // textBoxMennyiség
            // 
            this.textBoxMennyiség.Location = new System.Drawing.Point(703, 405);
            this.textBoxMennyiség.Name = "textBoxMennyiség";
            this.textBoxMennyiség.Size = new System.Drawing.Size(37, 27);
            this.textBoxMennyiség.TabIndex = 6;
            // 
            // labelMennyEgys
            // 
            this.labelMennyEgys.AutoSize = true;
            this.labelMennyEgys.Location = new System.Drawing.Point(746, 412);
            this.labelMennyEgys.Name = "labelMennyEgys";
            this.labelMennyEgys.Size = new System.Drawing.Size(50, 20);
            this.labelMennyEgys.TabIndex = 7;
            this.labelMennyEgys.Text = "label3";
            // 
            // buttonHozzaadas
            // 
            this.buttonHozzaadas.Location = new System.Drawing.Point(647, 189);
            this.buttonHozzaadas.Name = "buttonHozzaadas";
            this.buttonHozzaadas.Size = new System.Drawing.Size(50, 50);
            this.buttonHozzaadas.TabIndex = 8;
            this.buttonHozzaadas.Text = "+";
            this.buttonHozzaadas.UseVisualStyleBackColor = true;
            this.buttonHozzaadas.Click += new System.EventHandler(this.buttonHozzaadas_Click);
            // 
            // buttonTorles
            // 
            this.buttonTorles.Location = new System.Drawing.Point(647, 245);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(50, 50);
            this.buttonTorles.TabIndex = 9;
            this.buttonTorles.Text = "-";
            this.buttonTorles.UseVisualStyleBackColor = true;
            this.buttonTorles.Click += new System.EventHandler(this.buttonTorles_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nyersanyagNevDataGridViewTextBoxColumn,
            this.mennyiseg4foDataGridViewTextBoxColumn,
            this.egysegNevDataGridViewTextBoxColumn,
            this.árDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hozzavaloBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(160, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(481, 324);
            this.dataGridView1.TabIndex = 10;
            // 
            // nyersanyagNevDataGridViewTextBoxColumn
            // 
            this.nyersanyagNevDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagNev";
            this.nyersanyagNevDataGridViewTextBoxColumn.HeaderText = "NyersanyagNev";
            this.nyersanyagNevDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nyersanyagNevDataGridViewTextBoxColumn.Name = "nyersanyagNevDataGridViewTextBoxColumn";
            this.nyersanyagNevDataGridViewTextBoxColumn.Width = 125;
            // 
            // mennyiseg4foDataGridViewTextBoxColumn
            // 
            this.mennyiseg4foDataGridViewTextBoxColumn.DataPropertyName = "Mennyiseg_4fo";
            this.mennyiseg4foDataGridViewTextBoxColumn.HeaderText = "Mennyiseg_4fo";
            this.mennyiseg4foDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mennyiseg4foDataGridViewTextBoxColumn.Name = "mennyiseg4foDataGridViewTextBoxColumn";
            this.mennyiseg4foDataGridViewTextBoxColumn.Width = 125;
            // 
            // egysegNevDataGridViewTextBoxColumn
            // 
            this.egysegNevDataGridViewTextBoxColumn.DataPropertyName = "EgysegNev";
            this.egysegNevDataGridViewTextBoxColumn.HeaderText = "EgysegNev";
            this.egysegNevDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.egysegNevDataGridViewTextBoxColumn.Name = "egysegNevDataGridViewTextBoxColumn";
            this.egysegNevDataGridViewTextBoxColumn.Width = 125;
            // 
            // árDataGridViewTextBoxColumn
            // 
            this.árDataGridViewTextBoxColumn.DataPropertyName = "Ár";
            this.árDataGridViewTextBoxColumn.HeaderText = "Ár";
            this.árDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.árDataGridViewTextBoxColumn.Name = "árDataGridViewTextBoxColumn";
            this.árDataGridViewTextBoxColumn.Width = 125;
            // 
            // hozzavaloBindingSource
            // 
            this.hozzavaloBindingSource.DataSource = typeof(hozott.Hozzavalo);
            // 
            // UCReceptModositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonTorles);
            this.Controls.Add(this.buttonHozzaadas);
            this.Controls.Add(this.labelMennyEgys);
            this.Controls.Add(this.textBoxMennyiség);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNyersanyag);
            this.Controls.Add(this.listBoxNyersanyag);
            this.Controls.Add(this.listBoxFogas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFogas);
            this.Name = "UCReceptModositas";
            this.Size = new System.Drawing.Size(878, 470);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzavaloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxFogas;
        private Label label1;
        private ListBox listBoxFogas;
        private ListBox listBoxNyersanyag;
        private TextBox textBoxNyersanyag;
        private Label label2;
        private TextBox textBoxMennyiség;
        private Label labelMennyEgys;
        private Button buttonHozzaadas;
        private Button buttonTorles;
        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private BindingSource hozzavaloBindingSource;
        private DataGridViewTextBoxColumn nyersanyagNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyiseg4foDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egysegNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn árDataGridViewTextBoxColumn;
    }
}
