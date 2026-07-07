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
            tbpPalindromo = new TabPage();
            TxtPalindromoRisultato = new TextBox();
            BtnVerificaPalindromo = new Button();
            TxtPalindromo = new TextBox();
            label3 = new Label();
            tabPage1 = new TabPage();
            label4 = new Label();
            CmbUnitaUSB = new ComboBox();
            BtnChiudi = new Button();
            BtnVerificaUSB = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            tbcConvertitori.SuspendLayout();
            tbpNumeroToRomano.SuspendLayout();
            tbpPalindromo.SuspendLayout();
            tabPage1.SuspendLayout();
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
            tbcConvertitori.Controls.Add(tbpPalindromo);
            tbcConvertitori.Controls.Add(tabPage1);
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
            BtnVerificaIban.Text = "Verifica";
            BtnVerificaIban.UseVisualStyleBackColor = true;
            BtnVerificaIban.Click += BtnVerificaIban_Click;
            // 
            // TxtIBan
            // 
            TxtIBan.Location = new Point(17, 32);
            TxtIBan.MaxLength = 30;
            TxtIBan.Name = "TxtIBan";
            TxtIBan.Size = new Size(190, 23);
            TxtIBan.TabIndex = 1;
            TxtIBan.Enter += TxtCaselle_Enter;
            TxtIBan.Leave += TxtCaselle_Leave;
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
            // tbpPalindromo
            // 
            tbpPalindromo.Controls.Add(TxtPalindromoRisultato);
            tbpPalindromo.Controls.Add(BtnVerificaPalindromo);
            tbpPalindromo.Controls.Add(TxtPalindromo);
            tbpPalindromo.Controls.Add(label3);
            tbpPalindromo.Location = new Point(4, 24);
            tbpPalindromo.Name = "tbpPalindromo";
            tbpPalindromo.Padding = new Padding(3);
            tbpPalindromo.Size = new Size(792, 134);
            tbpPalindromo.TabIndex = 1;
            tbpPalindromo.Text = "Palindromo";
            tbpPalindromo.UseVisualStyleBackColor = true;
            // 
            // TxtPalindromoRisultato
            // 
            TxtPalindromoRisultato.Location = new Point(224, 33);
            TxtPalindromoRisultato.Name = "TxtPalindromoRisultato";
            TxtPalindromoRisultato.ReadOnly = true;
            TxtPalindromoRisultato.Size = new Size(301, 23);
            TxtPalindromoRisultato.TabIndex = 7;
            // 
            // BtnVerificaPalindromo
            // 
            BtnVerificaPalindromo.Location = new Point(12, 63);
            BtnVerificaPalindromo.Name = "BtnVerificaPalindromo";
            BtnVerificaPalindromo.Size = new Size(75, 23);
            BtnVerificaPalindromo.TabIndex = 6;
            BtnVerificaPalindromo.Text = "Verifica";
            BtnVerificaPalindromo.UseVisualStyleBackColor = true;
            BtnVerificaPalindromo.Click += BtnVerificaPalindromo_Click;
            // 
            // TxtPalindromo
            // 
            TxtPalindromo.Location = new Point(8, 33);
            TxtPalindromo.MaxLength = 50;
            TxtPalindromo.Name = "TxtPalindromo";
            TxtPalindromo.Size = new Size(190, 23);
            TxtPalindromo.TabIndex = 5;
            TxtPalindromo.Enter += TxtCaselle_Enter;
            TxtPalindromo.KeyPress += TxtPalindromo_KeyPress;
            TxtPalindromo.Leave += TxtCaselle_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 18);
            label3.Name = "label3";
            label3.Size = new Size(144, 15);
            label3.TabIndex = 4;
            label3.Text = "Verifica nome Palindromo";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(BtnVerificaUSB);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(CmbUnitaUSB);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 134);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Velocità chiavetta USB";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 5);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 1;
            label4.Text = "Unità USB esterna:";
            // 
            // CmbUnitaUSB
            // 
            CmbUnitaUSB.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbUnitaUSB.FormattingEnabled = true;
            CmbUnitaUSB.Location = new Point(20, 23);
            CmbUnitaUSB.Name = "CmbUnitaUSB";
            CmbUnitaUSB.Size = new Size(172, 23);
            CmbUnitaUSB.TabIndex = 0;
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
            // BtnVerificaUSB
            // 
            BtnVerificaUSB.Location = new Point(23, 57);
            BtnVerificaUSB.Name = "BtnVerificaUSB";
            BtnVerificaUSB.Size = new Size(100, 23);
            BtnVerificaUSB.TabIndex = 2;
            BtnVerificaUSB.Text = "Verifica";
            BtnVerificaUSB.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(243, 26);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 3;
            label5.Text = "Lettura:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(243, 56);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 4;
            label6.Text = "Scrittura:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(308, 23);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(301, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(308, 58);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(301, 23);
            textBox2.TabIndex = 9;
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
            Load += FrmVerifichecs_Load;
            tbcConvertitori.ResumeLayout(false);
            tbpNumeroToRomano.ResumeLayout(false);
            tbpNumeroToRomano.PerformLayout();
            tbpPalindromo.ResumeLayout(false);
            tbpPalindromo.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
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
        private TabPage tbpPalindromo;
        private TextBox TxtPalindromoRisultato;
        private Button BtnVerificaPalindromo;
        private TextBox TxtPalindromo;
        private Label label3;
        private Button BtnChiudi;
        private TabPage tabPage1;
        private Label label4;
        private ComboBox CmbUnitaUSB;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Button BtnVerificaUSB;
    }
}