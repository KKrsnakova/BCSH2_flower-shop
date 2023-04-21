namespace KvetinarstviSemPrace.Forms
{
    partial class FormPridejKytici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPridejKytici));
            this.btnKonec = new System.Windows.Forms.Button();
            this.lbPopis = new System.Windows.Forms.Label();
            this.lbCena = new System.Windows.Forms.Label();
            this.lbPocetKusu = new System.Windows.Forms.Label();
            this.numPocet = new System.Windows.Forms.NumericUpDown();
            this.lbNazev = new System.Windows.Forms.Label();
            this.btnPridej = new System.Windows.Forms.Button();
            this.tbPopis = new System.Windows.Forms.TextBox();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.tbNazev = new System.Windows.Forms.TextBox();
            this.panelMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numPocet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKonec
            // 
            this.btnKonec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKonec.Location = new System.Drawing.Point(47, 329);
            this.btnKonec.Name = "btnKonec";
            this.btnKonec.Size = new System.Drawing.Size(75, 29);
            this.btnKonec.TabIndex = 21;
            this.btnKonec.Text = "Konec";
            this.btnKonec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKonec.UseVisualStyleBackColor = true;
            this.btnKonec.Click += new System.EventHandler(this.BtnKonec_Click);
            // 
            // lbPopis
            // 
            this.lbPopis.AutoSize = true;
            this.lbPopis.Location = new System.Drawing.Point(47, 240);
            this.lbPopis.Name = "lbPopis";
            this.lbPopis.Size = new System.Drawing.Size(36, 13);
            this.lbPopis.TabIndex = 20;
            this.lbPopis.Text = "Popis:";
            // 
            // lbCena
            // 
            this.lbCena.AutoSize = true;
            this.lbCena.Location = new System.Drawing.Point(48, 153);
            this.lbCena.Name = "lbCena";
            this.lbCena.Size = new System.Drawing.Size(35, 13);
            this.lbCena.TabIndex = 19;
            this.lbCena.Text = "Cena:";
            // 
            // lbPocetKusu
            // 
            this.lbPocetKusu.AutoSize = true;
            this.lbPocetKusu.Location = new System.Drawing.Point(47, 202);
            this.lbPocetKusu.Name = "lbPocetKusu";
            this.lbPocetKusu.Size = new System.Drawing.Size(70, 13);
            this.lbPocetKusu.TabIndex = 18;
            this.lbPocetKusu.Text = "Počet květin:";
            // 
            // numPocet
            // 
            this.numPocet.Location = new System.Drawing.Point(168, 200);
            this.numPocet.Name = "numPocet";
            this.numPocet.Size = new System.Drawing.Size(120, 20);
            this.numPocet.TabIndex = 17;
            // 
            // lbNazev
            // 
            this.lbNazev.AutoSize = true;
            this.lbNazev.Location = new System.Drawing.Point(47, 105);
            this.lbNazev.Name = "lbNazev";
            this.lbNazev.Size = new System.Drawing.Size(41, 13);
            this.lbNazev.TabIndex = 16;
            this.lbNazev.Text = "Název:";
            // 
            // btnPridej
            // 
            this.btnPridej.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPridej.Location = new System.Drawing.Point(213, 329);
            this.btnPridej.Name = "btnPridej";
            this.btnPridej.Size = new System.Drawing.Size(75, 29);
            this.btnPridej.TabIndex = 15;
            this.btnPridej.Text = "Přidat";
            this.btnPridej.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPridej.UseVisualStyleBackColor = true;
            this.btnPridej.Click += new System.EventHandler(this.BtnPridej_Click);
            // 
            // tbPopis
            // 
            this.tbPopis.Location = new System.Drawing.Point(47, 259);
            this.tbPopis.Multiline = true;
            this.tbPopis.Name = "tbPopis";
            this.tbPopis.Size = new System.Drawing.Size(241, 51);
            this.tbPopis.TabIndex = 14;
            this.tbPopis.Text = "dfsdfsdfsdfsdf";
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(168, 150);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(120, 20);
            this.tbCena.TabIndex = 13;
            this.tbCena.Text = "50";
            // 
            // tbNazev
            // 
            this.tbNazev.Location = new System.Drawing.Point(168, 102);
            this.tbNazev.Name = "tbNazev";
            this.tbNazev.Size = new System.Drawing.Size(120, 20);
            this.tbNazev.TabIndex = 12;
            this.tbNazev.Text = "nazev";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BackgroundImage = global::KvetinarstviSemPrace.Properties.Resources.ic1;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(338, 60);
            this.panelMain.TabIndex = 22;
            // 
            // FormPridejKytici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(338, 409);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.btnKonec);
            this.Controls.Add(this.lbPopis);
            this.Controls.Add(this.lbCena);
            this.Controls.Add(this.lbPocetKusu);
            this.Controls.Add(this.numPocet);
            this.Controls.Add(this.lbNazev);
            this.Controls.Add(this.btnPridej);
            this.Controls.Add(this.tbPopis);
            this.Controls.Add(this.tbCena);
            this.Controls.Add(this.tbNazev);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPridejKytici";
            this.Text = "Přidej kytici";
            ((System.ComponentModel.ISupportInitialize)(this.numPocet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnKonec;
        private System.Windows.Forms.Label lbPopis;
        private System.Windows.Forms.Label lbCena;
        private System.Windows.Forms.Label lbPocetKusu;
        private System.Windows.Forms.NumericUpDown numPocet;
        private System.Windows.Forms.Label lbNazev;
        private System.Windows.Forms.Button btnPridej;
        private System.Windows.Forms.TextBox tbPopis;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.TextBox tbNazev;
    }
}