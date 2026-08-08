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
            BtnFileVCF = new Button();
            BtnRilevaVCF = new Button();
            TxtPercorsoVCF = new TextBox();
            label3 = new Label();
            BtnChiudi = new Button();
            Nome = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Note = new DataGridViewTextBoxColumn();
            tbcFile.SuspendLayout();
            tbpLeggiCertificatiPdf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCertificatiFilePdf).BeginInit();
            tbpLeggiVCF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDatiVcf).BeginInit();
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
            tbcFile.Dock = DockStyle.Top;
            tbcFile.Location = new Point(0, 22);
            tbcFile.Name = "tbcFile";
            tbcFile.SelectedIndex = 0;
            tbcFile.Size = new Size(963, 284);
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
            tbpLeggiCertificatiPdf.Size = new Size(955, 256);
            tbpLeggiCertificatiPdf.TabIndex = 0;
            tbpLeggiCertificatiPdf.Text = "Certificati file PDF";
            tbpLeggiCertificatiPdf.UseVisualStyleBackColor = true;
            // 
            // BtnLeggiCertificatiPdf
            // 
            BtnLeggiCertificatiPdf.Location = new Point(17, 48);
            BtnLeggiCertificatiPdf.Name = "BtnLeggiCertificatiPdf";
            BtnLeggiCertificatiPdf.Size = new Size(92, 23);
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
            dtgCertificatiFilePdf.Location = new Point(3, 76);
            dtgCertificatiFilePdf.Name = "dtgCertificatiFilePdf";
            dtgCertificatiFilePdf.Size = new Size(949, 177);
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
            tbpLeggiVCF.Size = new Size(955, 256);
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
            dtgDatiVcf.Location = new Point(3, 77);
            dtgDatiVcf.Name = "dtgDatiVcf";
            dtgDatiVcf.Size = new Size(949, 176);
            dtgDatiVcf.TabIndex = 19;
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
            BtnRilevaVCF.Size = new Size(92, 23);
            BtnRilevaVCF.TabIndex = 17;
            BtnRilevaVCF.Text = "Rileva Certificati";
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
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Image = Properties.Resources.chiudi_16;
            BtnChiudi.ImageAlign = ContentAlignment.MiddleLeft;
            BtnChiudi.Location = new Point(841, 327);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(75, 23);
            BtnChiudi.TabIndex = 4;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.UseVisualStyleBackColor = true;
            BtnChiudi.Click += BtnChiudi_Click;
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
            // FrmFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 362);
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
    }
}