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
            tabPage2 = new TabPage();
            BtnChiudi = new Button();
            label2 = new Label();
            TxtNumero = new TextBox();
            BtnConverti = new Button();
            TxtNumeroRomanoRisultato = new TextBox();
            tbcConvertitori.SuspendLayout();
            tbpNumeroToRomano.SuspendLayout();
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
            tbcConvertitori.Controls.Add(tabPage2);
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
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(818, 237);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 16);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 0;
            label2.Text = "Da numero a romano";
            // 
            // TxtNumero
            // 
            TxtNumero.Location = new Point(17, 32);
            TxtNumero.MaxLength = 5;
            TxtNumero.Name = "TxtNumero";
            TxtNumero.Size = new Size(190, 23);
            TxtNumero.TabIndex = 1;
            // 
            // BtnConverti
            // 
            BtnConverti.Location = new Point(21, 62);
            BtnConverti.Name = "BtnConverti";
            BtnConverti.Size = new Size(75, 23);
            BtnConverti.TabIndex = 2;
            BtnConverti.Text = "Converti";
            BtnConverti.UseVisualStyleBackColor = true;
            BtnConverti.Click += BtnConverti_Click;
            // 
            // TxtNumeroRomanoRisultato
            // 
            TxtNumeroRomanoRisultato.Location = new Point(233, 32);
            TxtNumeroRomanoRisultato.Name = "TxtNumeroRomanoRisultato";
            TxtNumeroRomanoRisultato.ReadOnly = true;
            TxtNumeroRomanoRisultato.Size = new Size(301, 23);
            TxtNumeroRomanoRisultato.TabIndex = 3;
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
            tbcConvertitori.ResumeLayout(false);
            tbpNumeroToRomano.ResumeLayout(false);
            tbpNumeroToRomano.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TabControl tbcConvertitori;
        private TabPage tbpNumeroToRomano;
        private TabPage tabPage2;
        private Button BtnChiudi;
        private TextBox TxtNumeroRomanoRisultato;
        private Button BtnConverti;
        private TextBox TxtNumero;
        private Label label2;
    }
}