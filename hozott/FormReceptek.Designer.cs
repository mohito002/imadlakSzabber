namespace hozott
{
    partial class FormReceptek
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
            this.buttonReceptModositas = new System.Windows.Forms.Button();
            this.buttonUjFogasFelvetele = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonReceptModositas
            // 
            this.buttonReceptModositas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonReceptModositas.Location = new System.Drawing.Point(27, 100);
            this.buttonReceptModositas.Name = "buttonReceptModositas";
            this.buttonReceptModositas.Size = new System.Drawing.Size(160, 107);
            this.buttonReceptModositas.TabIndex = 0;
            this.buttonReceptModositas.Text = "Recept módosítása";
            this.buttonReceptModositas.UseVisualStyleBackColor = true;
            this.buttonReceptModositas.Click += new System.EventHandler(this.buttonReceptModositas_Click);
            // 
            // buttonUjFogasFelvetele
            // 
            this.buttonUjFogasFelvetele.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonUjFogasFelvetele.Location = new System.Drawing.Point(27, 234);
            this.buttonUjFogasFelvetele.Name = "buttonUjFogasFelvetele";
            this.buttonUjFogasFelvetele.Size = new System.Drawing.Size(160, 102);
            this.buttonUjFogasFelvetele.TabIndex = 2;
            this.buttonUjFogasFelvetele.Text = "Új fogás felvétele";
            this.buttonUjFogasFelvetele.UseVisualStyleBackColor = true;
            this.buttonUjFogasFelvetele.Click += new System.EventHandler(this.buttonUjFogasFelvetele_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(241, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 510);
            this.panel1.TabIndex = 3;
            // 
            // FormReceptek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonUjFogasFelvetele);
            this.Controls.Add(this.buttonReceptModositas);
            this.Name = "FormReceptek";
            this.Text = "FormReceptek";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonReceptModositas;
        private Button buttonUjFogasFelvetele;
        private Panel panel1;
    }
}