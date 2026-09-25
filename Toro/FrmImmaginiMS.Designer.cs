namespace Toro
{
    partial class FrmImmaginiMS
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            tbcImmaginiMS = new TabControl();
            tbpImmagineBing = new TabPage();
            BtnScaricaSfondoBing = new Button();
            BtnCercaCartella = new Button();
            lblEtichetta = new Label();
            TxtPercorsoCartella = new TextBox();
            tbpImmaginiBlocco = new TabPage();
            labelInfo = new Label();
            BtnCopiaSfondo = new Button();
            BtnCercaCartellaPerSfondo = new Button();
            label4 = new Label();
            TxtPercorsoFileSfondo = new TextBox();
            label2 = new Label();
            pcbAnteprima = new PictureBox();
            CmsImpostaComeSfondo = new ContextMenuStrip(components);
            MniImpostaSfondo = new ToolStripMenuItem();
            lstboxFile = new ListBox();
            CmsMenu = new ContextMenuStrip(components);
            MniSalva = new ToolStripMenuItem();
            MniApri = new ToolStripMenuItem();
            tbpContenuti = new TabPage();
            BtnCopiaContenuti = new Button();
            BtnContenutiSuggeriti = new Button();
            label5 = new Label();
            TxtContenutiSuggeriti = new TextBox();
            label3 = new Label();
            PctAnteprimaContenuti = new PictureBox();
            LstNomeFileContenuti = new ListBox();
            BtnChiudi = new Button();
            tbcImmaginiMS.SuspendLayout();
            tbpImmagineBing.SuspendLayout();
            tbpImmaginiBlocco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbAnteprima).BeginInit();
            CmsImpostaComeSfondo.SuspendLayout();
            CmsMenu.SuspendLayout();
            tbpContenuti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PctAnteprimaContenuti).BeginInit();
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
            label1.Size = new Size(813, 22);
            label1.TabIndex = 1;
            label1.Text = "Toro- Strumenti e funzionalità per Windows - Gestione  Immagini  Microsoft";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbcImmaginiMS
            // 
            tbcImmaginiMS.Controls.Add(tbpImmagineBing);
            tbcImmaginiMS.Controls.Add(tbpImmaginiBlocco);
            tbcImmaginiMS.Controls.Add(tbpContenuti);
            tbcImmaginiMS.Dock = DockStyle.Top;
            tbcImmaginiMS.Location = new Point(0, 22);
            tbcImmaginiMS.Name = "tbcImmaginiMS";
            tbcImmaginiMS.SelectedIndex = 0;
            tbcImmaginiMS.Size = new Size(813, 400);
            tbcImmaginiMS.TabIndex = 2;
            tbcImmaginiMS.SelectedIndexChanged += tbcImmaginiMS_SelectedIndexChanged;
            // 
            // tbpImmagineBing
            // 
            tbpImmagineBing.Controls.Add(BtnScaricaSfondoBing);
            tbpImmagineBing.Controls.Add(BtnCercaCartella);
            tbpImmagineBing.Controls.Add(lblEtichetta);
            tbpImmagineBing.Controls.Add(TxtPercorsoCartella);
            tbpImmagineBing.Location = new Point(4, 24);
            tbpImmagineBing.Name = "tbpImmagineBing";
            tbpImmagineBing.Padding = new Padding(3);
            tbpImmagineBing.Size = new Size(805, 372);
            tbpImmagineBing.TabIndex = 0;
            tbpImmagineBing.Text = "Immagini da Bing";
            tbpImmagineBing.UseVisualStyleBackColor = true;
            // 
            // BtnScaricaSfondoBing
            // 
            BtnScaricaSfondoBing.Location = new Point(8, 70);
            BtnScaricaSfondoBing.Name = "BtnScaricaSfondoBing";
            BtnScaricaSfondoBing.Size = new Size(75, 23);
            BtnScaricaSfondoBing.TabIndex = 7;
            BtnScaricaSfondoBing.Text = "Scarica";
            BtnScaricaSfondoBing.UseVisualStyleBackColor = true;
            BtnScaricaSfondoBing.Click += BtnScaricaSfondoBing_Click;
            // 
            // BtnCercaCartella
            // 
            BtnCercaCartella.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnCercaCartella.Location = new Point(319, 30);
            BtnCercaCartella.Name = "BtnCercaCartella";
            BtnCercaCartella.Size = new Size(30, 29);
            BtnCercaCartella.TabIndex = 6;
            BtnCercaCartella.Text = "...";
            BtnCercaCartella.TextAlign = ContentAlignment.TopLeft;
            BtnCercaCartella.UseVisualStyleBackColor = true;
            BtnCercaCartella.Click += BtnCercaCartella_Click;
            // 
            // lblEtichetta
            // 
            lblEtichetta.AutoSize = true;
            lblEtichetta.Location = new Point(13, 12);
            lblEtichetta.Name = "lblEtichetta";
            lblEtichetta.Size = new Size(152, 15);
            lblEtichetta.TabIndex = 5;
            lblEtichetta.Text = "Percorso dove salvare il file:";
            // 
            // TxtPercorsoCartella
            // 
            TxtPercorsoCartella.Location = new Point(8, 30);
            TxtPercorsoCartella.Name = "TxtPercorsoCartella";
            TxtPercorsoCartella.ReadOnly = true;
            TxtPercorsoCartella.Size = new Size(305, 23);
            TxtPercorsoCartella.TabIndex = 4;
            // 
            // tbpImmaginiBlocco
            // 
            tbpImmaginiBlocco.Controls.Add(labelInfo);
            tbpImmaginiBlocco.Controls.Add(BtnCopiaSfondo);
            tbpImmaginiBlocco.Controls.Add(BtnCercaCartellaPerSfondo);
            tbpImmaginiBlocco.Controls.Add(label4);
            tbpImmaginiBlocco.Controls.Add(TxtPercorsoFileSfondo);
            tbpImmaginiBlocco.Controls.Add(label2);
            tbpImmaginiBlocco.Controls.Add(pcbAnteprima);
            tbpImmaginiBlocco.Controls.Add(lstboxFile);
            tbpImmaginiBlocco.Location = new Point(4, 24);
            tbpImmaginiBlocco.Name = "tbpImmaginiBlocco";
            tbpImmaginiBlocco.Padding = new Padding(3);
            tbpImmaginiBlocco.Size = new Size(805, 372);
            tbpImmaginiBlocco.TabIndex = 1;
            tbpImmaginiBlocco.Text = "Immagini di blocco di Windows";
            tbpImmaginiBlocco.UseVisualStyleBackColor = true;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(9, 350);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(0, 15);
            labelInfo.TabIndex = 12;
            // 
            // BtnCopiaSfondo
            // 
            BtnCopiaSfondo.Location = new Point(10, 274);
            BtnCopiaSfondo.Name = "BtnCopiaSfondo";
            BtnCopiaSfondo.Size = new Size(109, 23);
            BtnCopiaSfondo.TabIndex = 11;
            BtnCopiaSfondo.Text = "Copia e rileva file";
            BtnCopiaSfondo.UseVisualStyleBackColor = true;
            BtnCopiaSfondo.Click += BtnCopiaSfondo_Click;
            // 
            // BtnCercaCartellaPerSfondo
            // 
            BtnCercaCartellaPerSfondo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnCercaCartellaPerSfondo.Location = new Point(321, 234);
            BtnCercaCartellaPerSfondo.Name = "BtnCercaCartellaPerSfondo";
            BtnCercaCartellaPerSfondo.Size = new Size(30, 29);
            BtnCercaCartellaPerSfondo.TabIndex = 10;
            BtnCercaCartellaPerSfondo.Text = "...";
            BtnCercaCartellaPerSfondo.TextAlign = ContentAlignment.TopLeft;
            BtnCercaCartellaPerSfondo.UseVisualStyleBackColor = true;
            BtnCercaCartellaPerSfondo.Click += BtnCercaCartellaPerSfondo_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 216);
            label4.Name = "label4";
            label4.Size = new Size(152, 15);
            label4.TabIndex = 9;
            label4.Text = "Percorso dove salvare il file:";
            // 
            // TxtPercorsoFileSfondo
            // 
            TxtPercorsoFileSfondo.Location = new Point(10, 234);
            TxtPercorsoFileSfondo.Name = "TxtPercorsoFileSfondo";
            TxtPercorsoFileSfondo.ReadOnly = true;
            TxtPercorsoFileSfondo.Size = new Size(305, 23);
            TxtPercorsoFileSfondo.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 3);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // pcbAnteprima
            // 
            pcbAnteprima.ContextMenuStrip = CmsImpostaComeSfondo;
            pcbAnteprima.Location = new Point(387, 9);
            pcbAnteprima.Name = "pcbAnteprima";
            pcbAnteprima.Size = new Size(397, 330);
            pcbAnteprima.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbAnteprima.TabIndex = 1;
            pcbAnteprima.TabStop = false;
            // 
            // CmsImpostaComeSfondo
            // 
            CmsImpostaComeSfondo.Items.AddRange(new ToolStripItem[] { MniImpostaSfondo });
            CmsImpostaComeSfondo.Name = "contextMenuStrip1";
            CmsImpostaComeSfondo.Size = new Size(191, 48);
            CmsImpostaComeSfondo.Opening += CmsImpostaComeSfondo_Opening;
            // 
            // MniImpostaSfondo
            // 
            MniImpostaSfondo.Name = "MniImpostaSfondo";
            MniImpostaSfondo.Size = new Size(190, 22);
            MniImpostaSfondo.Text = "Imposta come sfondo";
            MniImpostaSfondo.Click += MniImpostaSfondo_Click;
            // 
            // lstboxFile
            // 
            lstboxFile.ContextMenuStrip = CmsMenu;
            lstboxFile.FormattingEnabled = true;
            lstboxFile.Location = new Point(10, 21);
            lstboxFile.Name = "lstboxFile";
            lstboxFile.Size = new Size(271, 184);
            lstboxFile.TabIndex = 0;
            lstboxFile.SelectedIndexChanged += ListBoxImages_SelectedIndexChanged;
            // 
            // CmsMenu
            // 
            CmsMenu.Items.AddRange(new ToolStripItem[] { MniSalva, MniApri });
            CmsMenu.Name = "CmsMenu";
            CmsMenu.Size = new Size(140, 48);
            // 
            // MniSalva
            // 
            MniSalva.Name = "MniSalva";
            MniSalva.Size = new Size(139, 22);
            MniSalva.Text = "Salva";
            MniSalva.Click += MniSalva_Click;
            // 
            // MniApri
            // 
            MniApri.Name = "MniApri";
            MniApri.Size = new Size(139, 22);
            MniApri.Text = "Apri Cartella";
            MniApri.Click += MniApri_Click;
            // 
            // tbpContenuti
            // 
            tbpContenuti.Controls.Add(BtnCopiaContenuti);
            tbpContenuti.Controls.Add(BtnContenutiSuggeriti);
            tbpContenuti.Controls.Add(label5);
            tbpContenuti.Controls.Add(TxtContenutiSuggeriti);
            tbpContenuti.Controls.Add(label3);
            tbpContenuti.Controls.Add(PctAnteprimaContenuti);
            tbpContenuti.Controls.Add(LstNomeFileContenuti);
            tbpContenuti.Location = new Point(4, 24);
            tbpContenuti.Name = "tbpContenuti";
            tbpContenuti.Padding = new Padding(3);
            tbpContenuti.Size = new Size(805, 372);
            tbpContenuti.TabIndex = 2;
            tbpContenuti.Text = "Contenuti suggeriti";
            tbpContenuti.UseVisualStyleBackColor = true;
            // 
            // BtnCopiaContenuti
            // 
            BtnCopiaContenuti.Location = new Point(9, 282);
            BtnCopiaContenuti.Name = "BtnCopiaContenuti";
            BtnCopiaContenuti.Size = new Size(109, 23);
            BtnCopiaContenuti.TabIndex = 15;
            BtnCopiaContenuti.Text = "Copia e rileva file";
            BtnCopiaContenuti.UseVisualStyleBackColor = true;
            BtnCopiaContenuti.Click += BtnCopiaContenuti_Click;
            // 
            // BtnContenutiSuggeriti
            // 
            BtnContenutiSuggeriti.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnContenutiSuggeriti.Location = new Point(320, 242);
            BtnContenutiSuggeriti.Name = "BtnContenutiSuggeriti";
            BtnContenutiSuggeriti.Size = new Size(30, 29);
            BtnContenutiSuggeriti.TabIndex = 14;
            BtnContenutiSuggeriti.Text = "...";
            BtnContenutiSuggeriti.TextAlign = ContentAlignment.TopLeft;
            BtnContenutiSuggeriti.UseVisualStyleBackColor = true;
            BtnContenutiSuggeriti.Click += BtnContenutiSuggeriti_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 224);
            label5.Name = "label5";
            label5.Size = new Size(152, 15);
            label5.TabIndex = 13;
            label5.Text = "Percorso dove salvare il file:";
            // 
            // TxtContenutiSuggeriti
            // 
            TxtContenutiSuggeriti.Location = new Point(9, 242);
            TxtContenutiSuggeriti.Name = "TxtContenutiSuggeriti";
            TxtContenutiSuggeriti.ReadOnly = true;
            TxtContenutiSuggeriti.Size = new Size(305, 23);
            TxtContenutiSuggeriti.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 3);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Nome";
            // 
            // PctAnteprimaContenuti
            // 
            PctAnteprimaContenuti.ContextMenuStrip = CmsImpostaComeSfondo;
            PctAnteprimaContenuti.Location = new Point(386, 9);
            PctAnteprimaContenuti.Name = "PctAnteprimaContenuti";
            PctAnteprimaContenuti.Size = new Size(397, 347);
            PctAnteprimaContenuti.TabIndex = 4;
            PctAnteprimaContenuti.TabStop = false;
            // 
            // LstNomeFileContenuti
            // 
            LstNomeFileContenuti.FormattingEnabled = true;
            LstNomeFileContenuti.Location = new Point(9, 21);
            LstNomeFileContenuti.Name = "LstNomeFileContenuti";
            LstNomeFileContenuti.Size = new Size(271, 184);
            LstNomeFileContenuti.TabIndex = 3;
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Image = Properties.Resources.chiudi_16;
            BtnChiudi.ImageAlign = ContentAlignment.MiddleRight;
            BtnChiudi.Location = new Point(726, 451);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(75, 23);
            BtnChiudi.TabIndex = 6;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.UseVisualStyleBackColor = true;
            BtnChiudi.Click += BtnChiudi_Click;
            // 
            // FrmImmaginiMS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 486);
            Controls.Add(BtnChiudi);
            Controls.Add(tbcImmaginiMS);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmImmaginiMS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Toro - Strumenti e funzionalità per Windows";
            Load += FrmImmaginiMS_Load;
            tbcImmaginiMS.ResumeLayout(false);
            tbpImmagineBing.ResumeLayout(false);
            tbpImmagineBing.PerformLayout();
            tbpImmaginiBlocco.ResumeLayout(false);
            tbpImmaginiBlocco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbAnteprima).EndInit();
            CmsImpostaComeSfondo.ResumeLayout(false);
            CmsMenu.ResumeLayout(false);
            tbpContenuti.ResumeLayout(false);
            tbpContenuti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PctAnteprimaContenuti).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TabControl tbcImmaginiMS;
        private TabPage tbpImmagineBing;
        private TabPage tbpImmaginiBlocco;
        private Button BtnChiudi;
        private Label label2;
        private PictureBox pcbAnteprima;
        private ListBox lstboxFile;
        private TabPage tbpContenuti;
        private Button BtnScaricaSfondoBing;
        private Button BtnCercaCartella;
        private Label lblEtichetta;
        private TextBox TxtPercorsoCartella;
        private ContextMenuStrip CmsMenu;
        private ToolStripMenuItem MniSalva;
        private Label label3;
        private PictureBox PctAnteprimaContenuti;
        private ListBox LstNomeFileContenuti;
        private ContextMenuStrip CmsImpostaComeSfondo;
        private ToolStripMenuItem MniImpostaSfondo;
        private ToolStripMenuItem MniApri;
        private Button BtnCopiaSfondo;
        private Button BtnCercaCartellaPerSfondo;
        private Label label4;
        private TextBox TxtPercorsoFileSfondo;
        private Button BtnCopiaContenuti;
        private Button BtnContenutiSuggeriti;
        private Label label5;
        private TextBox TxtContenutiSuggeriti;
        private Label labelInfo;
    }
}