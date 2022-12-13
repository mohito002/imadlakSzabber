namespace hozott
{
    partial class UCUjFogas
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFogasNev = new System.Windows.Forms.TextBox();
            this.buttonHozzaadas = new System.Windows.Forms.Button();
            this.textBoxLeiras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új fogás neve:";
            // 
            // textBoxFogasNev
            // 
            this.textBoxFogasNev.Location = new System.Drawing.Point(33, 60);
            this.textBoxFogasNev.Name = "textBoxFogasNev";
            this.textBoxFogasNev.Size = new System.Drawing.Size(125, 27);
            this.textBoxFogasNev.TabIndex = 1;
            this.textBoxFogasNev.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxFogasNev_Validating);
            this.textBoxFogasNev.Validated += new System.EventHandler(this.textBoxFogasNev_Validated);
            // 
            // buttonHozzaadas
            // 
            this.buttonHozzaadas.Location = new System.Drawing.Point(281, 37);
            this.buttonHozzaadas.Name = "buttonHozzaadas";
            this.buttonHozzaadas.Size = new System.Drawing.Size(160, 66);
            this.buttonHozzaadas.TabIndex = 2;
            this.buttonHozzaadas.Text = "Hozzáadás";
            this.buttonHozzaadas.UseVisualStyleBackColor = true;
            this.buttonHozzaadas.Click += new System.EventHandler(this.buttonHozzaadas_Click);
            // 
            // textBoxLeiras
            // 
            this.textBoxLeiras.Location = new System.Drawing.Point(33, 128);
            this.textBoxLeiras.Multiline = true;
            this.textBoxLeiras.Name = "textBoxLeiras";
            this.textBoxLeiras.Size = new System.Drawing.Size(408, 196);
            this.textBoxLeiras.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Leírás:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UCUjFogas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLeiras);
            this.Controls.Add(this.buttonHozzaadas);
            this.Controls.Add(this.textBoxFogasNev);
            this.Controls.Add(this.label1);
            this.Name = "UCUjFogas";
            this.Size = new System.Drawing.Size(486, 344);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxFogasNev;
        private Button buttonHozzaadas;
        private TextBox textBoxLeiras;
        private Label label2;
        private ErrorProvider errorProvider1;
    }
}
