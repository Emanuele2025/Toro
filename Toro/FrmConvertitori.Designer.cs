namespace Toro
{
    partial class FrmConvertitori
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
            TxtNumeroRomanoRisultato = new TextBox();
            BtnConverti = new Button();
            TxtNumero = new TextBox();
            label2 = new Label();
            tbpDaNumeroRomano = new TabPage();
            TxtRomaNumeroRisultato = new TextBox();
            BtnConvertiRomanoNumero = new Button();
            TxtRomanoNumero = new TextBox();
            label3 = new Label();
            tbpNumeroTesto = new TabPage();
            txtNumeroTestoRisultato = new TextBox();
            BtnConvertiNumeroTesto = new Button();
            label4 = new Label();
            BtnChiudi = new Button();
            nudNumeroTesto = new NumericUpDown();
            tbcConvertitori.SuspendLayout();
            tbpNumeroToRomano.SuspendLayout();
            tbpDaNumeroRomano.SuspendLayout();
            tbpNumeroTesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumeroTesto).BeginInit();
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
            label1.Size = new Size(826, 22);
            label1.TabIndex = 1;
            label1.Text = "Toro- Convertitori vari";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbcConvertitori
            // 
            tbcConvertitori.Controls.Add(tbpNumeroToRomano);
            tbcConvertitori.Controls.Add(tbpDaNumeroRomano);
            tbcConvertitori.Controls.Add(tbpNumeroTesto);
            tbcConvertitori.Dock = DockStyle.Top;
            tbcConvertitori.Location = new Point(0, 22);
            tbcConvertitori.Name = "tbcConvertitori";
            tbcConvertitori.SelectedIndex = 0;
            tbcConvertitori.Size = new Size(826, 162);
            tbcConvertitori.TabIndex = 2;
            // 
            // tbpNumeroToRomano
            // 
            tbpNumeroToRomano.Controls.Add(TxtNumeroRomanoRisultato);
            tbpNumeroToRomano.Controls.Add(BtnConverti);
            tbpNumeroToRomano.Controls.Add(TxtNumero);
            tbpNumeroToRomano.Controls.Add(label2);
            tbpNumeroToRomano.Location = new Point(4, 24);
            tbpNumeroToRomano.Name = "tbpNumeroToRomano";
            tbpNumeroToRomano.Padding = new Padding(3);
            tbpNumeroToRomano.Size = new Size(818, 134);
            tbpNumeroToRomano.TabIndex = 0;
            tbpNumeroToRomano.Text = "Da numerico a Romano";
            tbpNumeroToRomano.UseVisualStyleBackColor = true;
            // 
            // TxtNumeroRomanoRisultato
            // 
            TxtNumeroRomanoRisultato.Location = new Point(229, 32);
            TxtNumeroRomanoRisultato.Name = "TxtNumeroRomanoRisultato";
            TxtNumeroRomanoRisultato.ReadOnly = true;
            TxtNumeroRomanoRisultato.Size = new Size(301, 23);
            TxtNumeroRomanoRisultato.TabIndex = 3;
            // 
            // BtnConverti
            // 
            BtnConverti.Location = new Point(14, 62);
            BtnConverti.Name = "BtnConverti";
            BtnConverti.Size = new Size(75, 23);
            BtnConverti.TabIndex = 2;
            BtnConverti.Text = "Converti";
            BtnConverti.UseVisualStyleBackColor = true;
            BtnConverti.Click += BtnConverti_Click;
            // 
            // TxtNumero
            // 
            TxtNumero.Location = new Point(13, 32);
            TxtNumero.MaxLength = 5;
            TxtNumero.Name = "TxtNumero";
            TxtNumero.Size = new Size(190, 23);
            TxtNumero.TabIndex = 1;
            TxtNumero.Enter += TxtCaselle_Enter;
            TxtNumero.KeyPress += TxtNumero_KeyPress;
            TxtNumero.Leave += TxtCaselle_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 16);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 0;
            label2.Text = "Da numero a romano";
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
            BtnConvertiRomanoNumero.Click += BtnConvertiRomanoNumero_Click;
            // 
            // TxtRomanoNumero
            // 
            TxtRomanoNumero.Location = new Point(8, 33);
            TxtRomanoNumero.MaxLength = 20;
            TxtRomanoNumero.Name = "TxtRomanoNumero";
            TxtRomanoNumero.Size = new Size(190, 23);
            TxtRomanoNumero.TabIndex = 5;
            TxtRomanoNumero.Enter += TxtCaselle_Enter;
            TxtRomanoNumero.Leave += TxtCaselle_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 15);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 4;
            label3.Text = "Da numero a romano";
            // 
            // tbpNumeroTesto
            // 
            tbpNumeroTesto.Controls.Add(nudNumeroTesto);
            tbpNumeroTesto.Controls.Add(txtNumeroTestoRisultato);
            tbpNumeroTesto.Controls.Add(BtnConvertiNumeroTesto);
            tbpNumeroTesto.Controls.Add(label4);
            tbpNumeroTesto.Location = new Point(4, 24);
            tbpNumeroTesto.Name = "tbpNumeroTesto";
            tbpNumeroTesto.Padding = new Padding(3);
            tbpNumeroTesto.Size = new Size(818, 134);
            tbpNumeroTesto.TabIndex = 2;
            tbpNumeroTesto.Text = "Da numero a testo";
            tbpNumeroTesto.UseVisualStyleBackColor = true;
            // 
            // txtNumeroTestoRisultato
            // 
            txtNumeroTestoRisultato.Location = new Point(224, 33);
            txtNumeroTestoRisultato.Name = "txtNumeroTestoRisultato";
            txtNumeroTestoRisultato.ReadOnly = true;
            txtNumeroTestoRisultato.Size = new Size(301, 23);
            txtNumeroTestoRisultato.TabIndex = 11;
            // 
            // BtnConvertiNumeroTesto
            // 
            BtnConvertiNumeroTesto.Location = new Point(12, 63);
            BtnConvertiNumeroTesto.Name = "BtnConvertiNumeroTesto";
            BtnConvertiNumeroTesto.Size = new Size(75, 23);
            BtnConvertiNumeroTesto.TabIndex = 10;
            BtnConvertiNumeroTesto.Text = "Converti";
            BtnConvertiNumeroTesto.UseVisualStyleBackColor = true;
            BtnConvertiNumeroTesto.Click += BtnConvertiNumeroTesto_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 15);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 8;
            label4.Text = "Da numero a testo";
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Location = new Point(739, 216);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(75, 23);
            BtnChiudi.TabIndex = 3;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.UseVisualStyleBackColor = true;
            BtnChiudi.Click += BtnChiudi_Click;
            // 
            // nudNumeroTesto
            // 
            nudNumeroTesto.DecimalPlaces = 2;
            nudNumeroTesto.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudNumeroTesto.Location = new Point(8, 33);
            nudNumeroTesto.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudNumeroTesto.Name = "nudNumeroTesto";
            nudNumeroTesto.Size = new Size(193, 23);
            nudNumeroTesto.TabIndex = 12;
            nudNumeroTesto.ThousandsSeparator = true;
            // 
            // FrmConvertitori
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 242);
            Controls.Add(BtnChiudi);
            Controls.Add(tbcConvertitori);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConvertitori";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Convertitori";
            Load += FrmConvertitori_Load;
            tbcConvertitori.ResumeLayout(false);
            tbpNumeroToRomano.ResumeLayout(false);
            tbpNumeroToRomano.PerformLayout();
            tbpDaNumeroRomano.ResumeLayout(false);
            tbpDaNumeroRomano.PerformLayout();
            tbpNumeroTesto.ResumeLayout(false);
            tbpNumeroTesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumeroTesto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TabControl tbcConvertitori;
        private TabPage tbpNumeroToRomano;
        private TabPage tbpDaNumeroRomano;
        private Button BtnChiudi;
        private TextBox TxtNumeroRomanoRisultato;
        private Button BtnConverti;
        private TextBox TxtNumero;
        private Label label2;
        private TextBox TxtRomaNumeroRisultato;
        private Button BtnConvertiRomanoNumero;
        private TextBox TxtRomanoNumero;
        private Label label3;
        private TabPage tbpNumeroTesto;
        private TextBox txtNumeroTestoRisultato;
        private Button BtnConvertiNumeroTesto;
        private Label label4;
        private NumericUpDown nudNumeroTesto;
    }
}