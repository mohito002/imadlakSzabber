namespace hozott
{
    partial class FormUjRecept
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
            this.receptIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fogasIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nyersanyagNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyiseg4foDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egysegNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.árDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hozzavaloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonTorles = new System.Windows.Forms.Button();
            this.buttonHozzaadas = new System.Windows.Forms.Button();
            this.labelMennyEgys = new System.Windows.Forms.Label();
            this.textBoxMennyiség = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNyersanyag = new System.Windows.Forms.TextBox();
            this.listBoxNyersanyag = new System.Windows.Forms.ListBox();
            this.labelUjFogas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzavaloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receptIDDataGridViewTextBoxColumn,
            this.fogasIDDataGridViewTextBoxColumn,
            this.nyersanyagNevDataGridViewTextBoxColumn,
            this.mennyiseg4foDataGridViewTextBoxColumn,
            this.egysegNevDataGridViewTextBoxColumn,
            this.árDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hozzavaloBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(66, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(481, 324);
            this.dataGridView1.TabIndex = 27;
            // 
            // receptIDDataGridViewTextBoxColumn
            // 
            this.receptIDDataGridViewTextBoxColumn.DataPropertyName = "ReceptID";
            this.receptIDDataGridViewTextBoxColumn.HeaderText = "ReceptID";
            this.receptIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receptIDDataGridViewTextBoxColumn.Name = "receptIDDataGridViewTextBoxColumn";
            this.receptIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // fogasIDDataGridViewTextBoxColumn
            // 
            this.fogasIDDataGridViewTextBoxColumn.DataPropertyName = "FogasID";
            this.fogasIDDataGridViewTextBoxColumn.HeaderText = "FogasID";
            this.fogasIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fogasIDDataGridViewTextBoxColumn.Name = "fogasIDDataGridViewTextBoxColumn";
            this.fogasIDDataGridViewTextBoxColumn.Width = 125;
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
            // buttonTorles
            // 
            this.buttonTorles.Location = new System.Drawing.Point(553, 193);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(50, 50);
            this.buttonTorles.TabIndex = 26;
            this.buttonTorles.Text = "-";
            this.buttonTorles.UseVisualStyleBackColor = true;
            this.buttonTorles.Click += new System.EventHandler(this.buttonTorles_Click);
            // 
            // buttonHozzaadas
            // 
            this.buttonHozzaadas.Location = new System.Drawing.Point(553, 137);
            this.buttonHozzaadas.Name = "buttonHozzaadas";
            this.buttonHozzaadas.Size = new System.Drawing.Size(50, 50);
            this.buttonHozzaadas.TabIndex = 25;
            this.buttonHozzaadas.Text = "+";
            this.buttonHozzaadas.UseVisualStyleBackColor = true;
            this.buttonHozzaadas.Click += new System.EventHandler(this.buttonHozzaadas_Click);
            // 
            // labelMennyEgys
            // 
            this.labelMennyEgys.AutoSize = true;
            this.labelMennyEgys.Location = new System.Drawing.Point(652, 411);
            this.labelMennyEgys.Name = "labelMennyEgys";
            this.labelMennyEgys.Size = new System.Drawing.Size(50, 20);
            this.labelMennyEgys.TabIndex = 24;
            this.labelMennyEgys.Text = "label3";
            // 
            // textBoxMennyiség
            // 
            this.textBoxMennyiség.Location = new System.Drawing.Point(609, 404);
            this.textBoxMennyiség.Name = "textBoxMennyiség";
            this.textBoxMennyiség.Size = new System.Drawing.Size(37, 27);
            this.textBoxMennyiség.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nyersanyag:";
            // 
            // textBoxNyersanyag
            // 
            this.textBoxNyersanyag.Location = new System.Drawing.Point(609, 42);
            this.textBoxNyersanyag.Name = "textBoxNyersanyag";
            this.textBoxNyersanyag.Size = new System.Drawing.Size(125, 27);
            this.textBoxNyersanyag.TabIndex = 21;
            // 
            // listBoxNyersanyag
            // 
            this.listBoxNyersanyag.FormattingEnabled = true;
            this.listBoxNyersanyag.ItemHeight = 20;
            this.listBoxNyersanyag.Location = new System.Drawing.Point(609, 74);
            this.listBoxNyersanyag.Name = "listBoxNyersanyag";
            this.listBoxNyersanyag.Size = new System.Drawing.Size(125, 324);
            this.listBoxNyersanyag.TabIndex = 20;
            this.listBoxNyersanyag.SelectedIndexChanged += new System.EventHandler(this.listBoxNyersanyag_SelectedIndexChanged);
            // 
            // labelUjFogas
            // 
            this.labelUjFogas.AutoSize = true;
            this.labelUjFogas.Location = new System.Drawing.Point(66, 45);
            this.labelUjFogas.Name = "labelUjFogas";
            this.labelUjFogas.Size = new System.Drawing.Size(50, 20);
            this.labelUjFogas.TabIndex = 19;
            this.labelUjFogas.Text = "label1";
            // 
            // FormUjRecept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonTorles);
            this.Controls.Add(this.buttonHozzaadas);
            this.Controls.Add(this.labelMennyEgys);
            this.Controls.Add(this.textBoxMennyiség);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNyersanyag);
            this.Controls.Add(this.listBoxNyersanyag);
            this.Controls.Add(this.labelUjFogas);
            this.Name = "FormUjRecept";
            this.Text = "FormDiagram";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzavaloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonTorles;
        private Button buttonHozzaadas;
        private Label labelMennyEgys;
        private TextBox textBoxMennyiség;
        private Label label2;
        private TextBox textBoxNyersanyag;
        private ListBox listBoxNyersanyag;
        private Label labelUjFogas;
        private DataGridViewTextBoxColumn receptIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fogasIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nyersanyagNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyiseg4foDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egysegNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn árDataGridViewTextBoxColumn;
        private BindingSource hozzavaloBindingSource;
    }
}