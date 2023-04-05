namespace KvetinarstviSemPrace.Forms
{
    partial class FormPridejKvetinu
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
            this.tbNazev = new System.Windows.Forms.TextBox();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.tbPopis = new System.Windows.Forms.TextBox();
            this.btnPridej = new System.Windows.Forms.Button();
            this.lbNazev = new System.Windows.Forms.Label();
            this.lbPocetKusu = new System.Windows.Forms.Label();
            this.lbCena = new System.Windows.Forms.Label();
            this.lbPopis = new System.Windows.Forms.Label();
            this.btnKonec = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.cbDruhyKvetin = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbNazev
            // 
            this.tbNazev.Location = new System.Drawing.Point(167, 77);
            this.tbNazev.Name = "tbNazev";
            this.tbNazev.Size = new System.Drawing.Size(120, 20);
            this.tbNazev.TabIndex = 0;
            this.tbNazev.Text = "nazev";
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(167, 175);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(120, 20);
            this.tbCena.TabIndex = 2;
            this.tbCena.Text = "50";
            // 
            // tbPopis
            // 
            this.tbPopis.Location = new System.Drawing.Point(46, 234);
            this.tbPopis.Multiline = true;
            this.tbPopis.Name = "tbPopis";
            this.tbPopis.Size = new System.Drawing.Size(241, 51);
            this.tbPopis.TabIndex = 3;
            this.tbPopis.Text = "dfsdfsdfsdfsdf";
            // 
            // btnPridej
            // 
            this.btnPridej.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPridej.Location = new System.Drawing.Point(212, 304);
            this.btnPridej.Name = "btnPridej";
            this.btnPridej.Size = new System.Drawing.Size(75, 29);
            this.btnPridej.TabIndex = 4;
            this.btnPridej.Text = "Přidat";
            this.btnPridej.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPridej.UseVisualStyleBackColor = true;
            this.btnPridej.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // lbNazev
            // 
            this.lbNazev.AutoSize = true;
            this.lbNazev.Location = new System.Drawing.Point(40, 77);
            this.lbNazev.Name = "lbNazev";
            this.lbNazev.Size = new System.Drawing.Size(41, 13);
            this.lbNazev.TabIndex = 5;
            this.lbNazev.Text = "Název:";
            // 
            // lbPocetKusu
            // 
            this.lbPocetKusu.AutoSize = true;
            this.lbPocetKusu.Location = new System.Drawing.Point(40, 126);
            this.lbPocetKusu.Name = "lbPocetKusu";
            this.lbPocetKusu.Size = new System.Drawing.Size(33, 13);
            this.lbPocetKusu.TabIndex = 7;
            this.lbPocetKusu.Text = "Druh:";
            // 
            // lbCena
            // 
            this.lbCena.AutoSize = true;
            this.lbCena.Location = new System.Drawing.Point(43, 175);
            this.lbCena.Name = "lbCena";
            this.lbCena.Size = new System.Drawing.Size(35, 13);
            this.lbCena.TabIndex = 8;
            this.lbCena.Text = "Cena:";
            // 
            // lbPopis
            // 
            this.lbPopis.AutoSize = true;
            this.lbPopis.Location = new System.Drawing.Point(46, 215);
            this.lbPopis.Name = "lbPopis";
            this.lbPopis.Size = new System.Drawing.Size(36, 13);
            this.lbPopis.TabIndex = 9;
            this.lbPopis.Text = "Popis:";
            // 
            // btnKonec
            // 
            this.btnKonec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKonec.Location = new System.Drawing.Point(46, 304);
            this.btnKonec.Name = "btnKonec";
            this.btnKonec.Size = new System.Drawing.Size(75, 29);
            this.btnKonec.TabIndex = 10;
            this.btnKonec.Text = "Konec";
            this.btnKonec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKonec.UseVisualStyleBackColor = true;
            this.btnKonec.Click += new System.EventHandler(this.BtnKonec_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BackgroundImage = global::KvetinarstviSemPrace.Properties.Resources.ic1;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(339, 61);
            this.panelMain.TabIndex = 11;
            // 
            // cbDruhyKvetin
            // 
            this.cbDruhyKvetin.FormattingEnabled = true;
            this.cbDruhyKvetin.Location = new System.Drawing.Point(167, 123);
            this.cbDruhyKvetin.Name = "cbDruhyKvetin";
            this.cbDruhyKvetin.Size = new System.Drawing.Size(121, 21);
            this.cbDruhyKvetin.TabIndex = 12;
            // 
            // FormPridejKvetinu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(339, 410);
            this.Controls.Add(this.cbDruhyKvetin);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.btnKonec);
            this.Controls.Add(this.lbPopis);
            this.Controls.Add(this.lbCena);
            this.Controls.Add(this.lbPocetKusu);
            this.Controls.Add(this.lbNazev);
            this.Controls.Add(this.btnPridej);
            this.Controls.Add(this.tbPopis);
            this.Controls.Add(this.tbCena);
            this.Controls.Add(this.tbNazev);
            this.Name = "FormPridejKvetinu";
            this.Text = "Nová květina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNazev;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.TextBox tbPopis;
        private System.Windows.Forms.Button btnPridej;
        private System.Windows.Forms.Label lbNazev;
        private System.Windows.Forms.Label lbPocetKusu;
        private System.Windows.Forms.Label lbCena;
        private System.Windows.Forms.Label lbPopis;
        private System.Windows.Forms.Button btnKonec;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ComboBox cbDruhyKvetin;
    }
}