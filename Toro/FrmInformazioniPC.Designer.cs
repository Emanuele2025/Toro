namespace Toro
{
    partial class FrmInformazioniPC
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
            groupBox1 = new GroupBox();
            TxtRisoluzioneSenzaBarra = new TextBox();
            label3 = new Label();
            txtRisoluzioneVideo = new TextBox();
            label2 = new Label();
            BtnChiudi = new Button();
            groupBox2 = new GroupBox();
            TxtCollegata = new TextBox();
            label6 = new Label();
            TxtLivelloBatteria = new TextBox();
            label7 = new Label();
            txtNomeUtente = new TextBox();
            label4 = new Label();
            TxtNomePC = new TextBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            TxtSpazioTotale = new TextBox();
            label13 = new Label();
            cmbUnita = new ComboBox();
            label12 = new Label();
            TxtUtilizzabile = new TextBox();
            label8 = new Label();
            TxtFileSystem = new TextBox();
            label9 = new Label();
            TxtEtichetta = new TextBox();
            label10 = new Label();
            txtTipo = new TextBox();
            label11 = new Label();
            TxtSpazioLibero = new TextBox();
            label14 = new Label();
            TxtOccupato = new TextBox();
            label15 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
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
            label1.TabIndex = 3;
            label1.Text = "Toro- Informazioni sul pc";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtRisoluzioneSenzaBarra);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtRisoluzioneVideo);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(6, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 139);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Video";
            // 
            // TxtRisoluzioneSenzaBarra
            // 
            TxtRisoluzioneSenzaBarra.Location = new Point(175, 50);
            TxtRisoluzioneSenzaBarra.Name = "TxtRisoluzioneSenzaBarra";
            TxtRisoluzioneSenzaBarra.ReadOnly = true;
            TxtRisoluzioneSenzaBarra.Size = new Size(177, 23);
            TxtRisoluzioneSenzaBarra.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 50);
            label3.Name = "label3";
            label3.Size = new Size(165, 15);
            label3.TabIndex = 2;
            label3.Text = "Risoluzione Video senza barra:";
            // 
            // txtRisoluzioneVideo
            // 
            txtRisoluzioneVideo.Location = new Point(175, 21);
            txtRisoluzioneVideo.Name = "txtRisoluzioneVideo";
            txtRisoluzioneVideo.ReadOnly = true;
            txtRisoluzioneVideo.Size = new Size(177, 23);
            txtRisoluzioneVideo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 21);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 0;
            label2.Text = "Risoluzione Video:";
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Location = new Point(704, 415);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(75, 23);
            BtnChiudi.TabIndex = 5;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.UseVisualStyleBackColor = true;
            BtnChiudi.Click += BtnChiudi_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtCollegata);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(TxtLivelloBatteria);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtNomeUtente);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(TxtNomePC);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(393, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(364, 139);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sistema";
            // 
            // TxtCollegata
            // 
            TxtCollegata.Location = new Point(175, 110);
            TxtCollegata.Name = "TxtCollegata";
            TxtCollegata.ReadOnly = true;
            TxtCollegata.Size = new Size(177, 23);
            TxtCollegata.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 110);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 6;
            label6.Text = "Collegata:";
            // 
            // TxtLivelloBatteria
            // 
            TxtLivelloBatteria.Location = new Point(175, 81);
            TxtLivelloBatteria.Name = "TxtLivelloBatteria";
            TxtLivelloBatteria.ReadOnly = true;
            TxtLivelloBatteria.Size = new Size(177, 23);
            TxtLivelloBatteria.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 81);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 4;
            label7.Text = "Livello Batteria:";
            // 
            // txtNomeUtente
            // 
            txtNomeUtente.Location = new Point(175, 50);
            txtNomeUtente.Name = "txtNomeUtente";
            txtNomeUtente.ReadOnly = true;
            txtNomeUtente.Size = new Size(177, 23);
            txtNomeUtente.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 50);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 2;
            label4.Text = "Nome Utente:";
            // 
            // TxtNomePC
            // 
            TxtNomePC.Location = new Point(175, 21);
            TxtNomePC.Name = "TxtNomePC";
            TxtNomePC.ReadOnly = true;
            TxtNomePC.Size = new Size(177, 23);
            TxtNomePC.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 21);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 0;
            label5.Text = "Nome PC:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(TxtOccupato);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(TxtSpazioLibero);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(TxtSpazioTotale);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(cmbUnita);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(TxtUtilizzabile);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(TxtFileSystem);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(TxtEtichetta);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtTipo);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(10, 177);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(364, 272);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Unità Disco PC";
            // 
            // TxtSpazioTotale
            // 
            TxtSpazioTotale.Location = new Point(175, 174);
            TxtSpazioTotale.Name = "TxtSpazioTotale";
            TxtSpazioTotale.ReadOnly = true;
            TxtSpazioTotale.Size = new Size(177, 23);
            TxtSpazioTotale.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 174);
            label13.Name = "label13";
            label13.Size = new Size(79, 15);
            label13.TabIndex = 10;
            label13.Text = "Spazio Totale:";
            // 
            // cmbUnita
            // 
            cmbUnita.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnita.FormattingEnabled = true;
            cmbUnita.Location = new Point(175, 25);
            cmbUnita.Name = "cmbUnita";
            cmbUnita.Size = new Size(173, 23);
            cmbUnita.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(4, 28);
            label12.Name = "label12";
            label12.Size = new Size(38, 15);
            label12.TabIndex = 8;
            label12.Text = "Unità:";
            // 
            // TxtUtilizzabile
            // 
            TxtUtilizzabile.Location = new Point(175, 144);
            TxtUtilizzabile.Name = "TxtUtilizzabile";
            TxtUtilizzabile.ReadOnly = true;
            TxtUtilizzabile.Size = new Size(177, 23);
            TxtUtilizzabile.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 144);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 6;
            label8.Text = "Utilizzabile:";
            // 
            // TxtFileSystem
            // 
            TxtFileSystem.Location = new Point(175, 115);
            TxtFileSystem.Name = "TxtFileSystem";
            TxtFileSystem.ReadOnly = true;
            TxtFileSystem.Size = new Size(177, 23);
            TxtFileSystem.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 114);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 4;
            label9.Text = "File System:";
            // 
            // TxtEtichetta
            // 
            TxtEtichetta.Location = new Point(175, 86);
            TxtEtichetta.Name = "TxtEtichetta";
            TxtEtichetta.ReadOnly = true;
            TxtEtichetta.Size = new Size(177, 23);
            TxtEtichetta.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 86);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 2;
            label10.Text = "Etichetta:";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(175, 57);
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            txtTipo.Size = new Size(177, 23);
            txtTipo.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 60);
            label11.Name = "label11";
            label11.Size = new Size(34, 15);
            label11.TabIndex = 0;
            label11.Text = "Tipo:";
            // 
            // TxtSpazioLibero
            // 
            TxtSpazioLibero.Location = new Point(175, 203);
            TxtSpazioLibero.Name = "TxtSpazioLibero";
            TxtSpazioLibero.ReadOnly = true;
            TxtSpazioLibero.Size = new Size(177, 23);
            TxtSpazioLibero.TabIndex = 13;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 203);
            label14.Name = "label14";
            label14.Size = new Size(80, 15);
            label14.TabIndex = 12;
            label14.Text = "Spazio Libero:";
            // 
            // TxtOccupato
            // 
            TxtOccupato.Location = new Point(175, 235);
            TxtOccupato.Name = "TxtOccupato";
            TxtOccupato.ReadOnly = true;
            TxtOccupato.Size = new Size(177, 23);
            TxtOccupato.TabIndex = 15;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 235);
            label15.Name = "label15";
            label15.Size = new Size(99, 15);
            label15.TabIndex = 14;
            label15.Text = "Spazio Occupato:";
            // 
            // FrmInformazioniPC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(BtnChiudi);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInformazioniPC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Toro - Informazioni PC";
            Load += FrmInformazioniPC_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtRisoluzioneVideo;
        private Label label2;
        private Button BtnChiudi;
        private TextBox TxtRisoluzioneSenzaBarra;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox txtNomeUtente;
        private Label label4;
        private TextBox TxtNomePC;
        private Label label5;
        private TextBox TxtCollegata;
        private Label label6;
        private TextBox TxtLivelloBatteria;
        private Label label7;
        private GroupBox groupBox3;
        private TextBox TxtSpazioTotale;
        private Label label13;
        private ComboBox cmbUnita;
        private Label label12;
        private TextBox TxtUtilizzabile;
        private Label label8;
        private TextBox TxtFileSystem;
        private Label label9;
        private TextBox TxtEtichetta;
        private Label label10;
        private TextBox txtTipo;
        private Label label11;
        private TextBox TxtOccupato;
        private Label label15;
        private TextBox TxtSpazioLibero;
        private Label label14;
    }
}