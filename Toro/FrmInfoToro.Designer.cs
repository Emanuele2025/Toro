namespace Toro
{
    partial class FrmInfoToro
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
            label1 = new Label();
            BtnChiudi = new Button();
            pctLogo = new PictureBox();
            LblDescrizione = new Label();
            label6 = new Label();
            lnlEmail = new LinkLabel();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pctLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Highlight;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 22);
            label1.TabIndex = 1;
            label1.Text = "Informazioni sul programma gratuito Toro - Strumenti per Windows";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Location = new Point(689, 415);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(75, 23);
            BtnChiudi.TabIndex = 6;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.UseVisualStyleBackColor = true;
            BtnChiudi.Click += BtnChiudi_Click;
            // 
            // pctLogo
            // 
            pctLogo.Image = Properties.Resources.toro;
            pctLogo.Location = new Point(0, 23);
            pctLogo.Name = "pctLogo";
            pctLogo.Size = new Size(279, 220);
            pctLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pctLogo.TabIndex = 7;
            pctLogo.TabStop = false;
            // 
            // LblDescrizione
            // 
            LblDescrizione.Location = new Point(285, 43);
            LblDescrizione.Name = "LblDescrizione";
            LblDescrizione.Size = new Size(436, 65);
            LblDescrizione.TabIndex = 17;
            // 
            // label6
            // 
            label6.Location = new Point(281, 172);
            label6.Name = "label6";
            label6.Size = new Size(322, 63);
            label6.TabIndex = 22;
            label6.Text = "Per informazioni o altro contattare Emanuele al numeo di telefono 339.1980065 oppure  tramite email - For info or anything else, get in touch with Emanuele at 339.1980065 or by email:\r\n";
            // 
            // lnlEmail
            // 
            lnlEmail.AutoSize = true;
            lnlEmail.Location = new Point(601, 224);
            lnlEmail.Name = "lnlEmail";
            lnlEmail.Size = new Size(176, 15);
            lnlEmail.TabIndex = 21;
            lnlEmail.TabStop = true;
            lnlEmail.Text = "emanuelemattei@tutanota.com";
            lnlEmail.LinkClicked += lnlEmail_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(281, 155);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 20;
            label5.Text = "Contatti:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 128);
            label3.Name = "label3";
            label3.Size = new Size(427, 15);
            label3.TabIndex = 19;
            label3.Text = "Realizzato da Emanuele Mattei con amore - Made with love by Emanuele Mattei";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(281, 108);
            label4.Name = "label4";
            label4.Size = new Size(63, 17);
            label4.TabIndex = 18;
            label4.Text = "Ideatore:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(281, 26);
            label2.Name = "label2";
            label2.Size = new Size(83, 17);
            label2.TabIndex = 16;
            label2.Text = "Descrizione:";
            // 
            // FrmInfoToro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblDescrizione);
            Controls.Add(label6);
            Controls.Add(lnlEmail);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pctLogo);
            Controls.Add(BtnChiudi);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInfoToro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informazoini sul programma Toro";
            ((System.ComponentModel.ISupportInitialize)pctLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnChiudi;
        private PictureBox pctLogo;
        private Label LblDescrizione;
        private Label label6;
        private LinkLabel lnlEmail;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
    }
}