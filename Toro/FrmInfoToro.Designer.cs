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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfoToro));
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
            label7 = new Label();
            LnkIcon = new LinkLabel();
            label8 = new Label();
            lnkduckduckgo = new LinkLabel();
            lkluxwing = new LinkLabel();
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
            BtnChiudi.Image = (Image)resources.GetObject("BtnChiudi.Image");
            BtnChiudi.ImageAlign = ContentAlignment.MiddleRight;
            BtnChiudi.Location = new Point(689, 415);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(75, 23);
            BtnChiudi.TabIndex = 6;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.TextAlign = ContentAlignment.MiddleLeft;
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
            LblDescrizione.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblDescrizione.Location = new Point(281, 43);
            LblDescrizione.Name = "LblDescrizione";
            LblDescrizione.Size = new Size(507, 65);
            LblDescrizione.TabIndex = 17;
            LblDescrizione.Text = "Programma gratuito per rilevare informazioni del sistema operativo Windows e vari strumenti di utilità - Free program to detect information about the Windows operating system and various utility tools";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(281, 183);
            label6.Name = "label6";
            label6.Size = new Size(496, 63);
            label6.TabIndex = 22;
            label6.Text = "Per informazioni o altro contattare Emanuele al numeo di telefono 339.1980065 oppure  tramite email - For info or anything else, get in touch with Emanuele at 339.1980065 or by email:\r\n";
            // 
            // lnlEmail
            // 
            lnlEmail.AutoSize = true;
            lnlEmail.Location = new Point(601, 255);
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
            label5.Location = new Point(281, 166);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 20;
            label5.Text = "Contatti:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(281, 120);
            label3.Name = "label3";
            label3.Size = new Size(519, 44);
            label3.TabIndex = 19;
            label3.Text = "Realizzato da Emanuele Mattei con amore - Made with love by Emanuele Mattei";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(281, 105);
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
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(281, 284);
            label7.Name = "label7";
            label7.Size = new Size(496, 37);
            label7.TabIndex = 23;
            label7.Text = "Le icone e le immagini utilizzate in questo programma provengono dai siti elencati di seguito, che le mettono gratuitamente a disposizione dei propri utenti.";
            // 
            // LnkIcon
            // 
            LnkIcon.AutoSize = true;
            LnkIcon.Location = new Point(290, 369);
            LnkIcon.Name = "LnkIcon";
            LnkIcon.Size = new Size(474, 15);
            LnkIcon.TabIndex = 24;
            LnkIcon.TabStop = true;
            LnkIcon.Text = "Alcune icone utilizzate in questo programma sono fornite da Icons8. by https://icons8.it/";
            LnkIcon.LinkClicked += LnkIcon_LinkClicked;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(285, 321);
            label8.Name = "label8";
            label8.Size = new Size(58, 22);
            label8.TabIndex = 25;
            label8.Text = "Crediti";
            // 
            // lnkduckduckgo
            // 
            lnkduckduckgo.AutoSize = true;
            lnkduckduckgo.Location = new Point(290, 343);
            lnkduckduckgo.Name = "lnkduckduckgo";
            lnkduckduckgo.Size = new Size(451, 15);
            lnkduckduckgo.TabIndex = 26;
            lnkduckduckgo.TabStop = true;
            lnkduckduckgo.Text = "L'immagine del toro creata tramite Duckduckgo AI Image Generator https://duck.ai/";
            lnkduckduckgo.LinkClicked += lnkduckduckgo_LinkClicked;
            // 
            // lkluxwing
            // 
            lkluxwing.AutoSize = true;
            lkluxwing.Location = new Point(290, 397);
            lkluxwing.Name = "lkluxwing";
            lkluxwing.Size = new Size(483, 15);
            lkluxwing.TabIndex = 27;
            lkluxwing.TabStop = true;
            lkluxwing.Text = "Alcune icone utilizzate in questo programma sono fornite da  uxwing https://uxwing.com/";
            lkluxwing.LinkClicked += lkluxwing_LinkClicked;
            // 
            // FrmInfoToro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lkluxwing);
            Controls.Add(lnkduckduckgo);
            Controls.Add(label8);
            Controls.Add(LnkIcon);
            Controls.Add(label7);
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
            Load += FrmInfoToro_Load;
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
        private Label label7;
        private LinkLabel LnkIcon;
        private Label label8;
        private LinkLabel lnkduckduckgo;
        private LinkLabel lkluxwing;
    }
}