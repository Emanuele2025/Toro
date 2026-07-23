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
            BtnChiudi = new Button();
            tbcSezioni = new TabControl();
            tbpVideo = new TabPage();
            groupBox1 = new GroupBox();
            TxtRisoluzioneSenzaBarra = new TextBox();
            label3 = new Label();
            txtRisoluzioneVideo = new TextBox();
            label2 = new Label();
            tbpSistema = new TabPage();
            groupBox2 = new GroupBox();
            TxtModelloPC = new TextBox();
            label21 = new Label();
            TxtCollegata = new TextBox();
            label6 = new Label();
            TxtLivelloBatteria = new TextBox();
            label7 = new Label();
            txtNomeUtente = new TextBox();
            label4 = new Label();
            TxtNomePC = new TextBox();
            label5 = new Label();
            tbpUnita = new TabPage();
            groupBox3 = new GroupBox();
            TxtOccupato = new TextBox();
            label15 = new Label();
            TxtSpazioLibero = new TextBox();
            label14 = new Label();
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
            tbpRam = new TabPage();
            TxtSlotRam = new TextBox();
            label28 = new Label();
            TxtProduttore = new TextBox();
            label25 = new Label();
            txtTipoRam = new TextBox();
            label17 = new Label();
            TxtVelocita = new TextBox();
            label27 = new Label();
            TxtRamTotale = new TextBox();
            label26 = new Label();
            TxtSlotLiberi = new TextBox();
            lblliberi = new Label();
            TxtSlotOccupati = new TextBox();
            label24 = new Label();
            TxtSlotTotali = new TextBox();
            label23 = new Label();
            tbpSchedaGrafica = new TabPage();
            TxtProduttoreSchedaGrafica = new TextBox();
            label16 = new Label();
            TxtDriver = new TextBox();
            label18 = new Label();
            TxtCapacitaSchedaGrafica = new TextBox();
            label19 = new Label();
            TxtNomeSchedaGrafica = new TextBox();
            label20 = new Label();
            tbpCPU = new TabPage();
            TxtIdProcessore = new TextBox();
            label32 = new Label();
            TxtVelocitaCPU = new TextBox();
            label33 = new Label();
            TxtNumeroLogici = new TextBox();
            label34 = new Label();
            TxtNumeroCore = new TextBox();
            label30 = new Label();
            TxtDescrizioneCPU = new TextBox();
            label31 = new Label();
            TxtProduttoreCPU = new TextBox();
            label22 = new Label();
            TxtNomeCPU = new TextBox();
            label29 = new Label();
            tbcSezioni.SuspendLayout();
            tbpVideo.SuspendLayout();
            groupBox1.SuspendLayout();
            tbpSistema.SuspendLayout();
            groupBox2.SuspendLayout();
            tbpUnita.SuspendLayout();
            groupBox3.SuspendLayout();
            tbpRam.SuspendLayout();
            tbpSchedaGrafica.SuspendLayout();
            tbpCPU.SuspendLayout();
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
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Image = Properties.Resources.chiudi_16;
            BtnChiudi.ImageAlign = ContentAlignment.MiddleRight;
            BtnChiudi.Location = new Point(704, 415);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(75, 23);
            BtnChiudi.TabIndex = 5;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.UseVisualStyleBackColor = true;
            BtnChiudi.Click += BtnChiudi_Click;
            // 
            // tbcSezioni
            // 
            tbcSezioni.Controls.Add(tbpVideo);
            tbcSezioni.Controls.Add(tbpSistema);
            tbcSezioni.Controls.Add(tbpUnita);
            tbcSezioni.Controls.Add(tbpRam);
            tbcSezioni.Controls.Add(tbpSchedaGrafica);
            tbcSezioni.Controls.Add(tbpCPU);
            tbcSezioni.Location = new Point(0, 25);
            tbcSezioni.Name = "tbcSezioni";
            tbcSezioni.SelectedIndex = 0;
            tbcSezioni.Size = new Size(800, 384);
            tbcSezioni.TabIndex = 8;
            // 
            // tbpVideo
            // 
            tbpVideo.Controls.Add(groupBox1);
            tbpVideo.Location = new Point(4, 24);
            tbpVideo.Name = "tbpVideo";
            tbpVideo.Padding = new Padding(3);
            tbpVideo.Size = new Size(792, 356);
            tbpVideo.TabIndex = 0;
            tbpVideo.Text = "Video";
            tbpVideo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtRisoluzioneSenzaBarra);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtRisoluzioneVideo);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(786, 350);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informaioni Video";
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
            // tbpSistema
            // 
            tbpSistema.Controls.Add(groupBox2);
            tbpSistema.Location = new Point(4, 24);
            tbpSistema.Name = "tbpSistema";
            tbpSistema.Padding = new Padding(3);
            tbpSistema.Size = new Size(792, 356);
            tbpSistema.TabIndex = 1;
            tbpSistema.Text = "Sistema";
            tbpSistema.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtModelloPC);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(TxtCollegata);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(TxtLivelloBatteria);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtNomeUtente);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(TxtNomePC);
            groupBox2.Controls.Add(label5);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(786, 350);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informaioni Sistema ";
            // 
            // TxtModelloPC
            // 
            TxtModelloPC.Location = new Point(175, 143);
            TxtModelloPC.Name = "TxtModelloPC";
            TxtModelloPC.ReadOnly = true;
            TxtModelloPC.Size = new Size(342, 23);
            TxtModelloPC.TabIndex = 9;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(4, 143);
            label21.Name = "label21";
            label21.Size = new Size(72, 15);
            label21.TabIndex = 8;
            label21.Text = "Modello PC:";
            // 
            // TxtCollegata
            // 
            TxtCollegata.Location = new Point(175, 110);
            TxtCollegata.Name = "TxtCollegata";
            TxtCollegata.ReadOnly = true;
            TxtCollegata.Size = new Size(342, 23);
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
            TxtLivelloBatteria.Size = new Size(342, 23);
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
            txtNomeUtente.Size = new Size(342, 23);
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
            TxtNomePC.Size = new Size(342, 23);
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
            // tbpUnita
            // 
            tbpUnita.Controls.Add(groupBox3);
            tbpUnita.Location = new Point(4, 24);
            tbpUnita.Name = "tbpUnita";
            tbpUnita.Padding = new Padding(3);
            tbpUnita.Size = new Size(792, 356);
            tbpUnita.TabIndex = 2;
            tbpUnita.Text = "Unità";
            tbpUnita.UseVisualStyleBackColor = true;
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
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(786, 350);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Unità Disco PC";
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
            cmbUnita.SelectedIndexChanged += cmbUnita_SelectedIndexChanged;
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
            // tbpRam
            // 
            tbpRam.Controls.Add(TxtSlotRam);
            tbpRam.Controls.Add(label28);
            tbpRam.Controls.Add(TxtProduttore);
            tbpRam.Controls.Add(label25);
            tbpRam.Controls.Add(txtTipoRam);
            tbpRam.Controls.Add(label17);
            tbpRam.Controls.Add(TxtVelocita);
            tbpRam.Controls.Add(label27);
            tbpRam.Controls.Add(TxtRamTotale);
            tbpRam.Controls.Add(label26);
            tbpRam.Controls.Add(TxtSlotLiberi);
            tbpRam.Controls.Add(lblliberi);
            tbpRam.Controls.Add(TxtSlotOccupati);
            tbpRam.Controls.Add(label24);
            tbpRam.Controls.Add(TxtSlotTotali);
            tbpRam.Controls.Add(label23);
            tbpRam.Location = new Point(4, 24);
            tbpRam.Name = "tbpRam";
            tbpRam.Padding = new Padding(3);
            tbpRam.Size = new Size(792, 356);
            tbpRam.TabIndex = 3;
            tbpRam.Text = "RAM";
            tbpRam.UseVisualStyleBackColor = true;
            // 
            // TxtSlotRam
            // 
            TxtSlotRam.Location = new Point(127, 17);
            TxtSlotRam.Name = "TxtSlotRam";
            TxtSlotRam.ReadOnly = true;
            TxtSlotRam.Size = new Size(183, 23);
            TxtSlotRam.TabIndex = 37;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(9, 19);
            label28.Name = "label28";
            label28.Size = new Size(30, 15);
            label28.TabIndex = 36;
            label28.Text = "Slot:";
            // 
            // TxtProduttore
            // 
            TxtProduttore.Location = new Point(127, 234);
            TxtProduttore.Name = "TxtProduttore";
            TxtProduttore.ReadOnly = true;
            TxtProduttore.Size = new Size(183, 23);
            TxtProduttore.TabIndex = 35;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(9, 237);
            label25.Name = "label25";
            label25.Size = new Size(67, 15);
            label25.TabIndex = 34;
            label25.Text = "Produttore:";
            // 
            // txtTipoRam
            // 
            txtTipoRam.Location = new Point(127, 195);
            txtTipoRam.Name = "txtTipoRam";
            txtTipoRam.ReadOnly = true;
            txtTipoRam.Size = new Size(183, 23);
            txtTipoRam.TabIndex = 33;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(9, 195);
            label17.Name = "label17";
            label17.Size = new Size(34, 15);
            label17.TabIndex = 32;
            label17.Text = "Tipo:";
            // 
            // TxtVelocita
            // 
            TxtVelocita.Location = new Point(127, 166);
            TxtVelocita.Name = "TxtVelocita";
            TxtVelocita.ReadOnly = true;
            TxtVelocita.Size = new Size(183, 23);
            TxtVelocita.TabIndex = 31;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(9, 169);
            label27.Name = "label27";
            label27.Size = new Size(51, 15);
            label27.TabIndex = 30;
            label27.Text = "Velocità:";
            // 
            // TxtRamTotale
            // 
            TxtRamTotale.Location = new Point(127, 136);
            TxtRamTotale.Name = "TxtRamTotale";
            TxtRamTotale.ReadOnly = true;
            TxtRamTotale.Size = new Size(183, 23);
            TxtRamTotale.TabIndex = 29;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(9, 139);
            label26.Name = "label26";
            label26.Size = new Size(69, 15);
            label26.TabIndex = 28;
            label26.Text = "RAM totale:";
            // 
            // TxtSlotLiberi
            // 
            TxtSlotLiberi.Location = new Point(127, 107);
            TxtSlotLiberi.Name = "TxtSlotLiberi";
            TxtSlotLiberi.ReadOnly = true;
            TxtSlotLiberi.Size = new Size(183, 23);
            TxtSlotLiberi.TabIndex = 27;
            // 
            // lblliberi
            // 
            lblliberi.AutoSize = true;
            lblliberi.Location = new Point(9, 110);
            lblliberi.Name = "lblliberi";
            lblliberi.Size = new Size(59, 15);
            lblliberi.TabIndex = 26;
            lblliberi.Text = "Slot liberi:";
            // 
            // TxtSlotOccupati
            // 
            TxtSlotOccupati.Location = new Point(127, 74);
            TxtSlotOccupati.Name = "TxtSlotOccupati";
            TxtSlotOccupati.ReadOnly = true;
            TxtSlotOccupati.Size = new Size(183, 23);
            TxtSlotOccupati.TabIndex = 25;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(9, 77);
            label24.Name = "label24";
            label24.Size = new Size(79, 15);
            label24.TabIndex = 24;
            label24.Text = "Slot occupati:";
            // 
            // TxtSlotTotali
            // 
            TxtSlotTotali.Location = new Point(127, 45);
            TxtSlotTotali.Name = "TxtSlotTotali";
            TxtSlotTotali.ReadOnly = true;
            TxtSlotTotali.Size = new Size(183, 23);
            TxtSlotTotali.TabIndex = 23;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(9, 47);
            label23.Name = "label23";
            label23.Size = new Size(60, 15);
            label23.TabIndex = 22;
            label23.Text = "Slot totali:";
            // 
            // tbpSchedaGrafica
            // 
            tbpSchedaGrafica.Controls.Add(TxtProduttoreSchedaGrafica);
            tbpSchedaGrafica.Controls.Add(label16);
            tbpSchedaGrafica.Controls.Add(TxtDriver);
            tbpSchedaGrafica.Controls.Add(label18);
            tbpSchedaGrafica.Controls.Add(TxtCapacitaSchedaGrafica);
            tbpSchedaGrafica.Controls.Add(label19);
            tbpSchedaGrafica.Controls.Add(TxtNomeSchedaGrafica);
            tbpSchedaGrafica.Controls.Add(label20);
            tbpSchedaGrafica.Location = new Point(4, 24);
            tbpSchedaGrafica.Name = "tbpSchedaGrafica";
            tbpSchedaGrafica.Padding = new Padding(3);
            tbpSchedaGrafica.Size = new Size(792, 356);
            tbpSchedaGrafica.TabIndex = 4;
            tbpSchedaGrafica.Text = "Scheda Grafica";
            tbpSchedaGrafica.UseVisualStyleBackColor = true;
            // 
            // TxtProduttoreSchedaGrafica
            // 
            TxtProduttoreSchedaGrafica.Location = new Point(173, 107);
            TxtProduttoreSchedaGrafica.Name = "TxtProduttoreSchedaGrafica";
            TxtProduttoreSchedaGrafica.ReadOnly = true;
            TxtProduttoreSchedaGrafica.Size = new Size(478, 23);
            TxtProduttoreSchedaGrafica.TabIndex = 23;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(4, 107);
            label16.Name = "label16";
            label16.Size = new Size(67, 15);
            label16.TabIndex = 22;
            label16.Text = "Produttore:";
            // 
            // TxtDriver
            // 
            TxtDriver.Location = new Point(173, 75);
            TxtDriver.Name = "TxtDriver";
            TxtDriver.ReadOnly = true;
            TxtDriver.Size = new Size(478, 23);
            TxtDriver.TabIndex = 21;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(4, 75);
            label18.Name = "label18";
            label18.Size = new Size(37, 15);
            label18.TabIndex = 20;
            label18.Text = "Drive:";
            // 
            // TxtCapacitaSchedaGrafica
            // 
            TxtCapacitaSchedaGrafica.Location = new Point(173, 46);
            TxtCapacitaSchedaGrafica.Name = "TxtCapacitaSchedaGrafica";
            TxtCapacitaSchedaGrafica.ReadOnly = true;
            TxtCapacitaSchedaGrafica.Size = new Size(478, 23);
            TxtCapacitaSchedaGrafica.TabIndex = 19;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(4, 46);
            label19.Name = "label19";
            label19.Size = new Size(56, 15);
            label19.TabIndex = 18;
            label19.Text = "Capacità:";
            // 
            // TxtNomeSchedaGrafica
            // 
            TxtNomeSchedaGrafica.Location = new Point(173, 16);
            TxtNomeSchedaGrafica.Name = "TxtNomeSchedaGrafica";
            TxtNomeSchedaGrafica.ReadOnly = true;
            TxtNomeSchedaGrafica.Size = new Size(478, 23);
            TxtNomeSchedaGrafica.TabIndex = 17;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(4, 16);
            label20.Name = "label20";
            label20.Size = new Size(43, 15);
            label20.TabIndex = 16;
            label20.Text = "Nome:";
            // 
            // tbpCPU
            // 
            tbpCPU.Controls.Add(TxtIdProcessore);
            tbpCPU.Controls.Add(label32);
            tbpCPU.Controls.Add(TxtVelocitaCPU);
            tbpCPU.Controls.Add(label33);
            tbpCPU.Controls.Add(TxtNumeroLogici);
            tbpCPU.Controls.Add(label34);
            tbpCPU.Controls.Add(TxtNumeroCore);
            tbpCPU.Controls.Add(label30);
            tbpCPU.Controls.Add(TxtDescrizioneCPU);
            tbpCPU.Controls.Add(label31);
            tbpCPU.Controls.Add(TxtProduttoreCPU);
            tbpCPU.Controls.Add(label22);
            tbpCPU.Controls.Add(TxtNomeCPU);
            tbpCPU.Controls.Add(label29);
            tbpCPU.Location = new Point(4, 24);
            tbpCPU.Name = "tbpCPU";
            tbpCPU.Padding = new Padding(3);
            tbpCPU.Size = new Size(792, 356);
            tbpCPU.TabIndex = 5;
            tbpCPU.Text = "CPU";
            tbpCPU.UseVisualStyleBackColor = true;
            // 
            // TxtIdProcessore
            // 
            TxtIdProcessore.Location = new Point(186, 191);
            TxtIdProcessore.Name = "TxtIdProcessore";
            TxtIdProcessore.ReadOnly = true;
            TxtIdProcessore.Size = new Size(281, 23);
            TxtIdProcessore.TabIndex = 17;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(15, 191);
            label32.Name = "label32";
            label32.Size = new Size(81, 15);
            label32.TabIndex = 16;
            label32.Text = "ID Processore:";
            // 
            // TxtVelocitaCPU
            // 
            TxtVelocitaCPU.Location = new Point(186, 162);
            TxtVelocitaCPU.Name = "TxtVelocitaCPU";
            TxtVelocitaCPU.ReadOnly = true;
            TxtVelocitaCPU.Size = new Size(281, 23);
            TxtVelocitaCPU.TabIndex = 15;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(15, 162);
            label33.Name = "label33";
            label33.Size = new Size(51, 15);
            label33.TabIndex = 14;
            label33.Text = "Velocità:";
            // 
            // TxtNumeroLogici
            // 
            TxtNumeroLogici.Location = new Point(186, 133);
            TxtNumeroLogici.Name = "TxtNumeroLogici";
            TxtNumeroLogici.ReadOnly = true;
            TxtNumeroLogici.Size = new Size(281, 23);
            TxtNumeroLogici.TabIndex = 13;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(15, 133);
            label34.Name = "label34";
            label34.Size = new Size(89, 15);
            label34.TabIndex = 12;
            label34.Text = "Numero Logici:";
            // 
            // TxtNumeroCore
            // 
            TxtNumeroCore.Location = new Point(186, 104);
            TxtNumeroCore.Name = "TxtNumeroCore";
            TxtNumeroCore.ReadOnly = true;
            TxtNumeroCore.Size = new Size(281, 23);
            TxtNumeroCore.TabIndex = 11;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(15, 104);
            label30.Name = "label30";
            label30.Size = new Size(82, 15);
            label30.TabIndex = 10;
            label30.Text = "Numero Core:";
            // 
            // TxtDescrizioneCPU
            // 
            TxtDescrizioneCPU.Location = new Point(186, 75);
            TxtDescrizioneCPU.Name = "TxtDescrizioneCPU";
            TxtDescrizioneCPU.ReadOnly = true;
            TxtDescrizioneCPU.Size = new Size(281, 23);
            TxtDescrizioneCPU.TabIndex = 9;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(15, 75);
            label31.Name = "label31";
            label31.Size = new Size(70, 15);
            label31.TabIndex = 8;
            label31.Text = "Descrizione:";
            // 
            // TxtProduttoreCPU
            // 
            TxtProduttoreCPU.Location = new Point(186, 46);
            TxtProduttoreCPU.Name = "TxtProduttoreCPU";
            TxtProduttoreCPU.ReadOnly = true;
            TxtProduttoreCPU.Size = new Size(281, 23);
            TxtProduttoreCPU.TabIndex = 7;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(15, 46);
            label22.Name = "label22";
            label22.Size = new Size(67, 15);
            label22.TabIndex = 6;
            label22.Text = "Produttore:";
            // 
            // TxtNomeCPU
            // 
            TxtNomeCPU.Location = new Point(186, 17);
            TxtNomeCPU.Name = "TxtNomeCPU";
            TxtNomeCPU.ReadOnly = true;
            TxtNomeCPU.Size = new Size(281, 23);
            TxtNomeCPU.TabIndex = 5;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(15, 17);
            label29.Name = "label29";
            label29.Size = new Size(43, 15);
            label29.TabIndex = 4;
            label29.Text = "Nome:";
            // 
            // FrmInformazioniPC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbcSezioni);
            Controls.Add(BtnChiudi);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInformazioniPC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Toro - Informazioni PC";
            Load += FrmInformazioniPC_Load;
            tbcSezioni.ResumeLayout(false);
            tbpVideo.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tbpSistema.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tbpUnita.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tbpRam.ResumeLayout(false);
            tbpRam.PerformLayout();
            tbpSchedaGrafica.ResumeLayout(false);
            tbpSchedaGrafica.PerformLayout();
            tbpCPU.ResumeLayout(false);
            tbpCPU.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button BtnChiudi;
        private TabControl tbcSezioni;
        private TabPage tbpVideo;
        private TabPage tbpSistema;
        private GroupBox groupBox1;
        private TextBox TxtRisoluzioneSenzaBarra;
        private Label label3;
        private TextBox txtRisoluzioneVideo;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox TxtCollegata;
        private Label label6;
        private TextBox TxtLivelloBatteria;
        private Label label7;
        private TextBox txtNomeUtente;
        private Label label4;
        private TextBox TxtNomePC;
        private Label label5;
        private TabPage tbpUnita;
        private GroupBox groupBox3;
        private TextBox TxtOccupato;
        private Label label15;
        private TextBox TxtSpazioLibero;
        private Label label14;
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
        private TabPage tbpRam;
        private TextBox TxtSlotRam;
        private Label label28;
        private TextBox TxtProduttore;
        private Label label25;
        private TextBox txtTipoRam;
        private Label label17;
        private TextBox TxtVelocita;
        private Label label27;
        private TextBox TxtRamTotale;
        private Label label26;
        private TextBox TxtSlotLiberi;
        private Label lblliberi;
        private TextBox TxtSlotOccupati;
        private Label label24;
        private TextBox TxtSlotTotali;
        private Label label23;
        private TabPage tbpSchedaGrafica;
        private TextBox TxtProduttoreSchedaGrafica;
        private Label label16;
        private TextBox TxtDriver;
        private Label label18;
        private TextBox TxtCapacitaSchedaGrafica;
        private Label label19;
        private TextBox TxtNomeSchedaGrafica;
        private Label label20;
        private TextBox TxtModelloPC;
        private Label label21;
        private TabPage tbpCPU;
        private TextBox TxtProduttoreCPU;
        private Label label22;
        private TextBox TxtNomeCPU;
        private Label label29;
        private TextBox TxtNumeroCore;
        private Label label30;
        private TextBox TxtDescrizioneCPU;
        private Label label31;
        private TextBox TxtIdProcessore;
        private Label label32;
        private TextBox TxtVelocitaCPU;
        private Label label33;
        private TextBox TxtNumeroLogici;
        private Label label34;
    }
}