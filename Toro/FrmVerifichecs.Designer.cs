namespace Toro
{
    partial class FrmVerifichecs
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
            tbcConvertitori = new TabControl();
            tbpNumeroToRomano = new TabPage();
            BtnVerificaIban = new Button();
            TxtIBan = new TextBox();
            label2 = new Label();
            tbpDaNumeroRomano = new TabPage();
            TxtRomaNumeroRisultato = new TextBox();
            BtnConvertiRomanoNumero = new Button();
            TxtRomanoNumero = new TextBox();
            label3 = new Label();
            BtnChiudi = new Button();
            tbcConvertitori.SuspendLayout();
            tbpNumeroToRomano.SuspendLayout();
            tbpDaNumeroRomano.SuspendLayout();
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
            label1.TabIndex = 2;
            label1.Text = "Toro- Verifiche";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbcConvertitori
            // 
            tbcConvertitori.Controls.Add(tbpNumeroToRomano);
            tbcConvertitori.Controls.Add(tbpDaNumeroRomano);
            tbcConvertitori.Dock = DockStyle.Top;
            tbcConvertitori.Location = new Point(0, 22);
            tbcConvertitori.Name = "tbcConvertitori";
            tbcConvertitori.SelectedIndex = 0;
            tbcConvertitori.Size = new Size(800, 162);
            tbcConvertitori.TabIndex = 3;
            // 
            // tbpNumeroToRomano
            // 
            tbpNumeroToRomano.Controls.Add(BtnVerificaIban);
            tbpNumeroToRomano.Controls.Add(TxtIBan);
            tbpNumeroToRomano.Controls.Add(label2);
            tbpNumeroToRomano.Location = new Point(4, 24);
            tbpNumeroToRomano.Name = "tbpNumeroToRomano";
            tbpNumeroToRomano.Padding = new Padding(3);
            tbpNumeroToRomano.Size = new Size(792, 134);
            tbpNumeroToRomano.TabIndex = 0;
            tbpNumeroToRomano.Text = "IBAN";
            tbpNumeroToRomano.UseVisualStyleBackColor = true;
            // 
            // BtnVerificaIban
            // 
            BtnVerificaIban.Location = new Point(18, 62);
            BtnVerificaIban.Name = "BtnVerificaIban";
            BtnVerificaIban.Size = new Size(75, 23);
            BtnVerificaIban.TabIndex = 2;
            BtnVerificaIban.Text = "Converti";
            BtnVerificaIban.UseVisualStyleBackColor = true;
            // 
            // TxtIBan
            // 
            TxtIBan.Location = new Point(17, 32);
            TxtIBan.MaxLength = 5;
            TxtIBan.Name = "TxtIBan";
            TxtIBan.Size = new Size(190, 23);
            TxtIBan.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 19);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 0;
            label2.Text = "IBAN";
            // 
            // tbpDaNumeroRomano
            // 
            tbpDaNumeroRomano.Controls.Add(TxtRomaNumeroRisultato);
            tbpDaNumeroRomano.Controls.Add(BtnConvertiRomanoNumero);
            tbpDaNumeroRomano.Controls.Add(TxtRomanoNumero);
            tbpDaNumeroRomano.Controls.Add(label3);
            tbpDaNumeroRomano.Location = new Point(4, 24);
            tbpDaNumeroRomano.Name = "tbpDaNumeroRomano";
            tbpDaNumeroRomano.Padding = new Padding(3);
            tbpDaNumeroRomano.Size = new Size(818, 134);
            tbpDaNumeroRomano.TabIndex = 1;
            tbpDaNumeroRomano.Text = "Da Romano a Numerico";
            tbpDaNumeroRomano.UseVisualStyleBackColor = true;
            // 
            // TxtRomaNumeroRisultato
            // 
            TxtRomaNumeroRisultato.Location = new Point(224, 33);
            TxtRomaNumeroRisultato.Name = "TxtRomaNumeroRisultato";
            TxtRomaNumeroRisultato.ReadOnly = true;
            TxtRomaNumeroRisultato.Size = new Size(301, 23);
            TxtRomaNumeroRisultato.TabIndex = 7;
            // 
            // BtnConvertiRomanoNumero
            // 
            BtnConvertiRomanoNumero.Location = new Point(12, 63);
            BtnConvertiRomanoNumero.Name = "BtnConvertiRomanoNumero";
            BtnConvertiRomanoNumero.Size = new Size(75, 23);
            BtnConvertiRomanoNumero.TabIndex = 6;
            BtnConvertiRomanoNumero.Text = "Converti";
            BtnConvertiRomanoNumero.UseVisualStyleBackColor = true;
            // 
            // TxtRomanoNumero
            // 
            TxtRomanoNumero.Location = new Point(8, 33);
            TxtRomanoNumero.MaxLength = 5;
            TxtRomanoNumero.Name = "TxtRomanoNumero";
            TxtRomanoNumero.Size = new Size(190, 23);
            TxtRomanoNumero.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 18);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 4;
            label3.Text = "Da numero a romano";
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Location = new Point(713, 216);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(75, 23);
            BtnChiudi.TabIndex = 4;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.UseVisualStyleBackColor = true;
            BtnChiudi.Click += BtnChiudi_Click;
            // 
            // FrmVerifichecs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 251);
            Controls.Add(BtnChiudi);
            Controls.Add(tbcConvertitori);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmVerifichecs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Toro - Funzionalità di verifica";
            tbcConvertitori.ResumeLayout(false);
            tbpNumeroToRomano.ResumeLayout(false);
            tbpNumeroToRomano.PerformLayout();
            tbpDaNumeroRomano.ResumeLayout(false);
            tbpDaNumeroRomano.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TabControl tbcConvertitori;
        private TabPage tbpNumeroToRomano;
        private TextBox TxtNumeroRomanoRisultato;
        private Button BtnVerificaIban;
        private TextBox TxtIBan;
        private Label label2;
        private TabPage tbpDaNumeroRomano;
        private TextBox TxtRomaNumeroRisultato;
        private Button BtnConvertiRomanoNumero;
        private TextBox TxtRomanoNumero;
        private Label label3;
        private Button BtnChiudi;
    }
}