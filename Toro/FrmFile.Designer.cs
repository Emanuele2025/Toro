namespace Toro
{
    partial class FrmFile
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
            tbcFile = new TabControl();
            tbpLeggiCertificatiPdf = new TabPage();
            BtnLeggiCertificatiPdf = new Button();
            BtnCercaCartella = new Button();
            TxtPercorsoCartella = new TextBox();
            label2 = new Label();
            dtgCertificatiFilePdf = new DataGridView();
            tbpLeggiVCF = new TabPage();
            dtgDatiVcf = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Note = new DataGridViewTextBoxColumn();
            BtnFileVCF = new Button();
            BtnRilevaVCF = new Button();
            TxtPercorsoVCF = new TextBox();
            label3 = new Label();
            tbpEstrapolaFileP7m = new TabPage();
            BtnSelezionaFileP7m = new Button();
            BtnEstrapolaFile = new Button();
            TxtPercorsoFileP7m = new TextBox();
            label4 = new Label();
            TbpHacker = new TabPage();
            groupBox2 = new GroupBox();
            BtnTrovaImmaginePngConFile = new Button();
            BtnRilevaFile = new Button();
            TxtImmagineConWord = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            BtnTrovaImmagine = new Button();
            BtnCreaFile = new Button();
            BtnTrovaFileHacker = new Button();
            TxtPercorsoNomeFileImmagine = new TextBox();
            label5 = new Label();
            TxtPercorsoNomeFileDaNascondere = new TextBox();
            label6 = new Label();
            BtnChiudi = new Button();
            tbcFile.SuspendLayout();
            tbpLeggiCertificatiPdf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCertificatiFilePdf).BeginInit();
            tbpLeggiVCF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDatiVcf).BeginInit();
            tbpEstrapolaFileP7m.SuspendLayout();
            TbpHacker.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
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
            label1.Size = new Size(963, 22);
            label1.TabIndex = 2;
            label1.Text = "Toro- Gestione dei file ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbcFile
            // 
            tbcFile.Controls.Add(tbpLeggiCertificatiPdf);
            tbcFile.Controls.Add(tbpLeggiVCF);
            tbcFile.Controls.Add(tbpEstrapolaFileP7m);
            tbcFile.Controls.Add(TbpHacker);
            tbcFile.Dock = DockStyle.Top;
            tbcFile.Location = new Point(0, 22);
            tbcFile.Multiline = true;
            tbcFile.Name = "tbcFile";
            tbcFile.SelectedIndex = 0;
            tbcFile.Size = new Size(963, 405);
            tbcFile.TabIndex = 3;
            // 
            // tbpLeggiCertificatiPdf
            // 
            tbpLeggiCertificatiPdf.Controls.Add(BtnLeggiCertificatiPdf);
            tbpLeggiCertificatiPdf.Controls.Add(BtnCercaCartella);
            tbpLeggiCertificatiPdf.Controls.Add(TxtPercorsoCartella);
            tbpLeggiCertificatiPdf.Controls.Add(label2);
            tbpLeggiCertificatiPdf.Controls.Add(dtgCertificatiFilePdf);
            tbpLeggiCertificatiPdf.Location = new Point(4, 24);
            tbpLeggiCertificatiPdf.Name = "tbpLeggiCertificatiPdf";
            tbpLeggiCertificatiPdf.Padding = new Padding(3);
            tbpLeggiCertificatiPdf.Size = new Size(955, 377);
            tbpLeggiCertificatiPdf.TabIndex = 0;
            tbpLeggiCertificatiPdf.Text = "Certificati file PDF";
            tbpLeggiCertificatiPdf.UseVisualStyleBackColor = true;
            // 
            // BtnLeggiCertificatiPdf
            // 
            BtnLeggiCertificatiPdf.Location = new Point(17, 48);
            BtnLeggiCertificatiPdf.Name = "BtnLeggiCertificatiPdf";
            BtnLeggiCertificatiPdf.Size = new Size(117, 23);
            BtnLeggiCertificatiPdf.TabIndex = 16;
            BtnLeggiCertificatiPdf.Text = "Rileva Certificati";
            BtnLeggiCertificatiPdf.UseVisualStyleBackColor = true;
            BtnLeggiCertificatiPdf.Click += BtnLeggiCertificatiPdf_Click;
            // 
            // BtnCercaCartella
            // 
            BtnCercaCartella.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnCercaCartella.Location = new Point(572, 19);
            BtnCercaCartella.Name = "BtnCercaCartella";
            BtnCercaCartella.Size = new Size(30, 29);
            BtnCercaCartella.TabIndex = 15;
            BtnCercaCartella.Text = "...";
            BtnCercaCartella.TextAlign = ContentAlignment.TopLeft;
            BtnCercaCartella.UseVisualStyleBackColor = true;
            BtnCercaCartella.Click += BtnCercaCartella_Click;
            // 
            // TxtPercorsoCartella
            // 
            TxtPercorsoCartella.Location = new Point(17, 22);
            TxtPercorsoCartella.Name = "TxtPercorsoCartella";
            TxtPercorsoCartella.ReadOnly = true;
            TxtPercorsoCartella.Size = new Size(555, 23);
            TxtPercorsoCartella.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 4);
            label2.Name = "label2";
            label2.Size = new Size(324, 15);
            label2.TabIndex = 1;
            label2.Text = "Percorso e nome del file Pdf da estrapolare certificati file pdf";
            // 
            // dtgCertificatiFilePdf
            // 
            dtgCertificatiFilePdf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCertificatiFilePdf.Dock = DockStyle.Bottom;
            dtgCertificatiFilePdf.Location = new Point(3, 107);
            dtgCertificatiFilePdf.Name = "dtgCertificatiFilePdf";
            dtgCertificatiFilePdf.Size = new Size(949, 267);
            dtgCertificatiFilePdf.TabIndex = 0;
            // 
            // tbpLeggiVCF
            // 
            tbpLeggiVCF.Controls.Add(dtgDatiVcf);
            tbpLeggiVCF.Controls.Add(BtnFileVCF);
            tbpLeggiVCF.Controls.Add(BtnRilevaVCF);
            tbpLeggiVCF.Controls.Add(TxtPercorsoVCF);
            tbpLeggiVCF.Controls.Add(label3);
            tbpLeggiVCF.Location = new Point(4, 24);
            tbpLeggiVCF.Name = "tbpLeggiVCF";
            tbpLeggiVCF.Padding = new Padding(3);
            tbpLeggiVCF.Size = new Size(955, 377);
            tbpLeggiVCF.TabIndex = 1;
            tbpLeggiVCF.Text = "Leggi file VCF";
            tbpLeggiVCF.ToolTipText = "Estrapola il contenuto dei file VCF";
            tbpLeggiVCF.UseVisualStyleBackColor = true;
            // 
            // dtgDatiVcf
            // 
            dtgDatiVcf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatiVcf.Columns.AddRange(new DataGridViewColumn[] { Nome, Email, Note });
            dtgDatiVcf.Dock = DockStyle.Bottom;
            dtgDatiVcf.Location = new Point(3, 198);
            dtgDatiVcf.Name = "dtgDatiVcf";
            dtgDatiVcf.Size = new Size(949, 176);
            dtgDatiVcf.TabIndex = 19;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.Width = 65;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.Width = 61;
            // 
            // Note
            // 
            Note.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Note.DataPropertyName = "Note";
            Note.HeaderText = "Note";
            Note.Name = "Note";
            Note.Width = 58;
            // 
            // BtnFileVCF
            // 
            BtnFileVCF.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnFileVCF.Location = new Point(579, 22);
            BtnFileVCF.Name = "BtnFileVCF";
            BtnFileVCF.Size = new Size(30, 29);
            BtnFileVCF.TabIndex = 18;
            BtnFileVCF.Text = "...";
            BtnFileVCF.TextAlign = ContentAlignment.TopLeft;
            BtnFileVCF.UseVisualStyleBackColor = true;
            BtnFileVCF.Click += BtnFileVCF_Click;
            // 
            // BtnRilevaVCF
            // 
            BtnRilevaVCF.Location = new Point(17, 48);
            BtnRilevaVCF.Name = "BtnRilevaVCF";
            BtnRilevaVCF.Size = new Size(113, 23);
            BtnRilevaVCF.TabIndex = 17;
            BtnRilevaVCF.Text = "Leggi file vcf";
            BtnRilevaVCF.UseVisualStyleBackColor = true;
            BtnRilevaVCF.Click += BtnRilevaVCF_Click;
            // 
            // TxtPercorsoVCF
            // 
            TxtPercorsoVCF.Location = new Point(18, 22);
            TxtPercorsoVCF.Name = "TxtPercorsoVCF";
            TxtPercorsoVCF.ReadOnly = true;
            TxtPercorsoVCF.Size = new Size(555, 23);
            TxtPercorsoVCF.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 4);
            label3.Name = "label3";
            label3.Size = new Size(287, 15);
            label3.TabIndex = 2;
            label3.Text = "Percorso e nome del file VCF per leggere il contenuto";
            // 
            // tbpEstrapolaFileP7m
            // 
            tbpEstrapolaFileP7m.Controls.Add(BtnSelezionaFileP7m);
            tbpEstrapolaFileP7m.Controls.Add(BtnEstrapolaFile);
            tbpEstrapolaFileP7m.Controls.Add(TxtPercorsoFileP7m);
            tbpEstrapolaFileP7m.Controls.Add(label4);
            tbpEstrapolaFileP7m.Location = new Point(4, 24);
            tbpEstrapolaFileP7m.Name = "tbpEstrapolaFileP7m";
            tbpEstrapolaFileP7m.Padding = new Padding(3);
            tbpEstrapolaFileP7m.Size = new Size(955, 377);
            tbpEstrapolaFileP7m.TabIndex = 2;
            tbpEstrapolaFileP7m.Text = "Estrapola file da p7m";
            tbpEstrapolaFileP7m.UseVisualStyleBackColor = true;
            // 
            // BtnSelezionaFileP7m
            // 
            BtnSelezionaFileP7m.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnSelezionaFileP7m.Location = new Point(569, 30);
            BtnSelezionaFileP7m.Name = "BtnSelezionaFileP7m";
            BtnSelezionaFileP7m.Size = new Size(30, 29);
            BtnSelezionaFileP7m.TabIndex = 22;
            BtnSelezionaFileP7m.Text = "...";
            BtnSelezionaFileP7m.TextAlign = ContentAlignment.TopLeft;
            BtnSelezionaFileP7m.UseVisualStyleBackColor = true;
            BtnSelezionaFileP7m.Click += BtnSelezionaFileP7m_Click;
            // 
            // BtnEstrapolaFile
            // 
            BtnEstrapolaFile.Location = new Point(7, 56);
            BtnEstrapolaFile.Name = "BtnEstrapolaFile";
            BtnEstrapolaFile.Size = new Size(92, 23);
            BtnEstrapolaFile.TabIndex = 21;
            BtnEstrapolaFile.Text = "Estrapola File";
            BtnEstrapolaFile.UseVisualStyleBackColor = true;
            BtnEstrapolaFile.Click += BtnEstrapolaFile_Click;
            // 
            // TxtPercorsoFileP7m
            // 
            TxtPercorsoFileP7m.Location = new Point(8, 30);
            TxtPercorsoFileP7m.Name = "TxtPercorsoFileP7m";
            TxtPercorsoFileP7m.ReadOnly = true;
            TxtPercorsoFileP7m.Size = new Size(555, 23);
            TxtPercorsoFileP7m.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 12);
            label4.Name = "label4";
            label4.Size = new Size(273, 15);
            label4.TabIndex = 19;
            label4.Text = "Percorso e nome del file P7M, per estrapolare il file";
            // 
            // TbpHacker
            // 
            TbpHacker.Controls.Add(groupBox2);
            TbpHacker.Controls.Add(groupBox1);
            TbpHacker.Location = new Point(4, 24);
            TbpHacker.Name = "TbpHacker";
            TbpHacker.Size = new Size(955, 377);
            TbpHacker.TabIndex = 3;
            TbpHacker.Text = "Hacker";
            TbpHacker.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnTrovaImmaginePngConFile);
            groupBox2.Controls.Add(BtnRilevaFile);
            groupBox2.Controls.Add(TxtImmagineConWord);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(3, 191);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(944, 164);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            groupBox2.Text = "Leggi file immagine contenente il file Word";
            // 
            // BtnTrovaImmaginePngConFile
            // 
            BtnTrovaImmaginePngConFile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnTrovaImmaginePngConFile.Location = new Point(567, 39);
            BtnTrovaImmaginePngConFile.Name = "BtnTrovaImmaginePngConFile";
            BtnTrovaImmaginePngConFile.Size = new Size(30, 29);
            BtnTrovaImmaginePngConFile.TabIndex = 29;
            BtnTrovaImmaginePngConFile.Text = "...";
            BtnTrovaImmaginePngConFile.TextAlign = ContentAlignment.TopLeft;
            BtnTrovaImmaginePngConFile.UseVisualStyleBackColor = true;
            BtnTrovaImmaginePngConFile.Click += BtnTrovaImmaginePngConFile_Click;
            // 
            // BtnRilevaFile
            // 
            BtnRilevaFile.Location = new Point(6, 88);
            BtnRilevaFile.Name = "BtnRilevaFile";
            BtnRilevaFile.Size = new Size(142, 23);
            BtnRilevaFile.TabIndex = 29;
            BtnRilevaFile.Text = "Rileva File Word";
            BtnRilevaFile.UseVisualStyleBackColor = true;
            BtnRilevaFile.Click += BtnRilevaFile_Click;
            // 
            // TxtImmagineConWord
            // 
            TxtImmagineConWord.Location = new Point(6, 42);
            TxtImmagineConWord.Name = "TxtImmagineConWord";
            TxtImmagineConWord.ReadOnly = true;
            TxtImmagineConWord.Size = new Size(555, 23);
            TxtImmagineConWord.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 24);
            label7.Name = "label7";
            label7.Size = new Size(357, 15);
            label7.TabIndex = 27;
            label7.Text = "Selezionare il file Immagine nel quale si trova il file Microsoft Word";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnTrovaImmagine);
            groupBox1.Controls.Add(BtnCreaFile);
            groupBox1.Controls.Add(BtnTrovaFileHacker);
            groupBox1.Controls.Add(TxtPercorsoNomeFileImmagine);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TxtPercorsoNomeFileDaNascondere);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(3, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(944, 164);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crea file immagine per nascondere file Word";
            // 
            // BtnTrovaImmagine
            // 
            BtnTrovaImmagine.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnTrovaImmagine.Location = new Point(567, 39);
            BtnTrovaImmagine.Name = "BtnTrovaImmagine";
            BtnTrovaImmagine.Size = new Size(30, 29);
            BtnTrovaImmagine.TabIndex = 29;
            BtnTrovaImmagine.Text = "...";
            BtnTrovaImmagine.TextAlign = ContentAlignment.TopLeft;
            BtnTrovaImmagine.UseVisualStyleBackColor = true;
            BtnTrovaImmagine.Click += BtnTrovaImmagine_Click;
            // 
            // BtnCreaFile
            // 
            BtnCreaFile.Location = new Point(6, 120);
            BtnCreaFile.Name = "BtnCreaFile";
            BtnCreaFile.Size = new Size(92, 23);
            BtnCreaFile.TabIndex = 29;
            BtnCreaFile.Text = "Crea File";
            BtnCreaFile.UseVisualStyleBackColor = true;
            BtnCreaFile.Click += BtnCreaFile_Click;
            // 
            // BtnTrovaFileHacker
            // 
            BtnTrovaFileHacker.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnTrovaFileHacker.Location = new Point(567, 91);
            BtnTrovaFileHacker.Name = "BtnTrovaFileHacker";
            BtnTrovaFileHacker.Size = new Size(30, 29);
            BtnTrovaFileHacker.TabIndex = 30;
            BtnTrovaFileHacker.Text = "...";
            BtnTrovaFileHacker.TextAlign = ContentAlignment.TopLeft;
            BtnTrovaFileHacker.UseVisualStyleBackColor = true;
            BtnTrovaFileHacker.Click += BtnTrovaFileHacker_Click;
            // 
            // TxtPercorsoNomeFileImmagine
            // 
            TxtPercorsoNomeFileImmagine.Location = new Point(6, 42);
            TxtPercorsoNomeFileImmagine.Name = "TxtPercorsoNomeFileImmagine";
            TxtPercorsoNomeFileImmagine.ReadOnly = true;
            TxtPercorsoNomeFileImmagine.Size = new Size(555, 23);
            TxtPercorsoNomeFileImmagine.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 24);
            label5.Name = "label5";
            label5.Size = new Size(271, 15);
            label5.TabIndex = 27;
            label5.Text = "Selezionare il file Immagine nel quale inserire il file";
            // 
            // TxtPercorsoNomeFileDaNascondere
            // 
            TxtPercorsoNomeFileDaNascondere.Location = new Point(6, 91);
            TxtPercorsoNomeFileDaNascondere.Name = "TxtPercorsoNomeFileDaNascondere";
            TxtPercorsoNomeFileDaNascondere.ReadOnly = true;
            TxtPercorsoNomeFileDaNascondere.Size = new Size(555, 23);
            TxtPercorsoNomeFileDaNascondere.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 73);
            label6.Name = "label6";
            label6.Size = new Size(402, 15);
            label6.TabIndex = 27;
            label6.Text = "Seleziona il file Microsoft Word che si vuole inserire dentro al file immagine";
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Image = Properties.Resources.chiudi_16;
            BtnChiudi.ImageAlign = ContentAlignment.MiddleLeft;
            BtnChiudi.Location = new Point(876, 444);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(75, 23);
            BtnChiudi.TabIndex = 4;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.UseVisualStyleBackColor = true;
            BtnChiudi.Click += BtnChiudi_Click;
            // 
            // FrmFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 479);
            Controls.Add(BtnChiudi);
            Controls.Add(tbcFile);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Toro";
            Load += FrmFile_Load;
            tbcFile.ResumeLayout(false);
            tbpLeggiCertificatiPdf.ResumeLayout(false);
            tbpLeggiCertificatiPdf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCertificatiFilePdf).EndInit();
            tbpLeggiVCF.ResumeLayout(false);
            tbpLeggiVCF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDatiVcf).EndInit();
            tbpEstrapolaFileP7m.ResumeLayout(false);
            tbpEstrapolaFileP7m.PerformLayout();
            TbpHacker.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TabControl tbcFile;
        private TabPage tbpLeggiCertificatiPdf;
        private TabPage tbpLeggiVCF;
        private Button BtnChiudi;
        private Button BtnLeggiCertificatiPdf;
        private Button BtnCercaCartella;
        private TextBox TxtPercorsoCartella;
        private Label label2;
        private DataGridView dtgCertificatiFilePdf;
        private Button BtnFileVCF;
        private Button BtnRilevaVCF;
        private TextBox TxtPercorsoVCF;
        private Label label3;
        private DataGridView dtgDatiVcf;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Note;
        private TabPage tbpEstrapolaFileP7m;
        private Button BtnSelezionaFileP7m;
        private Button BtnEstrapolaFile;
        private TextBox TxtPercorsoFileP7m;
        private Label label4;
        private TabPage TbpHacker;
        private Button BtnTrovaFileHacker;
        private Button BtnCreaFile;
        private TextBox TxtPercorsoNomeFileDaNascondere;
        private Label label6;
        private GroupBox groupBox1;
        private Button BtnTrovaImmagine;
        private TextBox TxtPercorsoNomeFileImmagine;
        private Label label5;
        private GroupBox groupBox2;
        private Button BtnTrovaImmaginePngConFile;
        private Button BtnRilevaFile;
        private TextBox TxtImmagineConWord;
        private Label label7;
    }
}