namespace KvetinarstviSemPrace.Forms
{
    partial class FormPridejZakaznika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPridejZakaznika));
            this.btnKonec = new System.Windows.Forms.Button();
            this.lbAdresa = new System.Windows.Forms.Label();
            this.lbJmeno = new System.Windows.Forms.Label();
            this.btnPridej = new System.Windows.Forms.Button();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbJmeno = new System.Windows.Forms.TextBox();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.lbPrijmeni = new System.Windows.Forms.Label();
            this.tbPrijmeni = new System.Windows.Forms.TextBox();
            this.tbTelCislo = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbTelCislo = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKonec
            // 
            this.btnKonec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKonec.Location = new System.Drawing.Point(55, 306);
            this.btnKonec.Name = "btnKonec";
            this.btnKonec.Size = new System.Drawing.Size(75, 29);
            this.btnKonec.TabIndex = 20;
            this.btnKonec.Text = "Konec";
            this.btnKonec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKonec.UseVisualStyleBackColor = true;
            this.btnKonec.Click += new System.EventHandler(this.BtnKonec_Click);
            // 
            // lbAdresa
            // 
            this.lbAdresa.AutoSize = true;
            this.lbAdresa.Location = new System.Drawing.Point(55, 130);
            this.lbAdresa.Name = "lbAdresa";
            this.lbAdresa.Size = new System.Drawing.Size(40, 13);
            this.lbAdresa.TabIndex = 19;
            this.lbAdresa.Text = "Adresa";
            // 
            // lbJmeno
            // 
            this.lbJmeno.AutoSize = true;
            this.lbJmeno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.lbJmeno.Location = new System.Drawing.Point(55, 82);
            this.lbJmeno.Name = "lbJmeno";
            this.lbJmeno.Size = new System.Drawing.Size(41, 13);
            this.lbJmeno.TabIndex = 15;
            this.lbJmeno.Text = "Jméno:";
            // 
            // btnPridej
            // 
            this.btnPridej.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPridej.Location = new System.Drawing.Point(221, 306);
            this.btnPridej.Name = "btnPridej";
            this.btnPridej.Size = new System.Drawing.Size(75, 29);
            this.btnPridej.TabIndex = 14;
            this.btnPridej.Text = "Přidat";
            this.btnPridej.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPridej.UseVisualStyleBackColor = true;
            this.btnPridej.Click += new System.EventHandler(this.BtnPridej_Click);
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(58, 152);
            this.tbAdresa.Multiline = true;
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(241, 51);
            this.tbAdresa.TabIndex = 13;
            this.tbAdresa.Text = "dfsdfsdfsdfsdf";
            // 
            // tbJmeno
            // 
            this.tbJmeno.Location = new System.Drawing.Point(145, 79);
            this.tbJmeno.Name = "tbJmeno";
            this.tbJmeno.Size = new System.Drawing.Size(151, 20);
            this.tbJmeno.TabIndex = 11;
            this.tbJmeno.Text = "jmeno";
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.White;
            this.menuPanel.BackgroundImage = global::KvetinarstviSemPrace.Properties.Resources.ic1;
            this.menuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(350, 60);
            this.menuPanel.TabIndex = 21;
            // 
            // lbPrijmeni
            // 
            this.lbPrijmeni.AutoSize = true;
            this.lbPrijmeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.lbPrijmeni.Location = new System.Drawing.Point(55, 105);
            this.lbPrijmeni.Name = "lbPrijmeni";
            this.lbPrijmeni.Size = new System.Drawing.Size(51, 13);
            this.lbPrijmeni.TabIndex = 22;
            this.lbPrijmeni.Text = "Příjmení:";
            // 
            // tbPrijmeni
            // 
            this.tbPrijmeni.Location = new System.Drawing.Point(145, 102);
            this.tbPrijmeni.Name = "tbPrijmeni";
            this.tbPrijmeni.Size = new System.Drawing.Size(151, 20);
            this.tbPrijmeni.TabIndex = 23;
            this.tbPrijmeni.Text = "projemni";
            // 
            // tbTelCislo
            // 
            this.tbTelCislo.Location = new System.Drawing.Point(145, 209);
            this.tbTelCislo.Name = "tbTelCislo";
            this.tbTelCislo.Size = new System.Drawing.Size(154, 20);
            this.tbTelCislo.TabIndex = 24;
            this.tbTelCislo.Text = "123456789";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(145, 235);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(154, 20);
            this.tbEmail.TabIndex = 25;
            this.tbEmail.Text = "email@email.com";
            // 
            // lbTelCislo
            // 
            this.lbTelCislo.AutoSize = true;
            this.lbTelCislo.Location = new System.Drawing.Point(58, 215);
            this.lbTelCislo.Name = "lbTelCislo";
            this.lbTelCislo.Size = new System.Drawing.Size(82, 13);
            this.lbTelCislo.TabIndex = 26;
            this.lbTelCislo.Text = "Telefonní číslo:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(61, 241);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 27;
            this.lbEmail.Text = "Email:";
            // 
            // FormPridejZakaznika
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(350, 373);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbTelCislo);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbTelCislo);
            this.Controls.Add(this.tbPrijmeni);
            this.Controls.Add(this.lbPrijmeni);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.btnKonec);
            this.Controls.Add(this.lbAdresa);
            this.Controls.Add(this.lbJmeno);
            this.Controls.Add(this.btnPridej);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbJmeno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPridejZakaznika";
            this.Text = "Nový zákazník";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKonec;
        private System.Windows.Forms.Label lbAdresa;
        private System.Windows.Forms.Label lbJmeno;
        private System.Windows.Forms.Button btnPridej;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.TextBox tbJmeno;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label lbPrijmeni;
        private System.Windows.Forms.TextBox tbPrijmeni;
        private System.Windows.Forms.TextBox tbTelCislo;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbTelCislo;
        private System.Windows.Forms.Label lbEmail;
    }
}