namespace KvetinarstviSemPrace.Forms
{
    partial class FormNovaObjednavka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNovaObjednavka));
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnKonec = new System.Windows.Forms.Button();
            this.lbCena = new System.Windows.Forms.Label();
            this.lbZakaznik = new System.Windows.Forms.Label();
            this.btnPridej = new System.Windows.Forms.Button();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.lbTelCislo = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTelCislo = new System.Windows.Forms.TextBox();
            this.lbAdresa = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbJmenoPrijmeni = new System.Windows.Forms.TextBox();
            this.lvObjednavka = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cenaPolozky = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPridatDoSeznamu = new System.Windows.Forms.Button();
            this.lbObjednavka = new System.Windows.Forms.Label();
            this.cbJmenoPrijmeni = new System.Windows.Forms.ComboBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.btnOdeberZeSeznamu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BackgroundImage = global::KvetinarstviSemPrace.Properties.Resources.ic1;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(840, 61);
            this.panelMain.TabIndex = 22;
            // 
            // btnKonec
            // 
            this.btnKonec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKonec.Location = new System.Drawing.Point(99, 613);
            this.btnKonec.Name = "btnKonec";
            this.btnKonec.Size = new System.Drawing.Size(75, 29);
            this.btnKonec.TabIndex = 21;
            this.btnKonec.Text = "Konec";
            this.btnKonec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKonec.UseVisualStyleBackColor = true;
            // 
            // lbCena
            // 
            this.lbCena.AutoSize = true;
            this.lbCena.Location = new System.Drawing.Point(360, 621);
            this.lbCena.Name = "lbCena";
            this.lbCena.Size = new System.Drawing.Size(35, 13);
            this.lbCena.TabIndex = 19;
            this.lbCena.Text = "Cena:";
            // 
            // lbZakaznik
            // 
            this.lbZakaznik.AutoSize = true;
            this.lbZakaznik.Location = new System.Drawing.Point(96, 89);
            this.lbZakaznik.Name = "lbZakaznik";
            this.lbZakaznik.Size = new System.Drawing.Size(56, 13);
            this.lbZakaznik.TabIndex = 16;
            this.lbZakaznik.Text = "Zákazník:";
            // 
            // btnPridej
            // 
            this.btnPridej.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPridej.Location = new System.Drawing.Point(613, 613);
            this.btnPridej.Name = "btnPridej";
            this.btnPridej.Size = new System.Drawing.Size(75, 29);
            this.btnPridej.TabIndex = 15;
            this.btnPridej.Text = "Přidat";
            this.btnPridej.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPridej.UseVisualStyleBackColor = true;
            this.btnPridej.Click += new System.EventHandler(this.BtnPridej_Click);
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(413, 618);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(120, 20);
            this.tbCena.TabIndex = 13;
            this.tbCena.Text = "0";
            // 
            // lbTelCislo
            // 
            this.lbTelCislo.AutoSize = true;
            this.lbTelCislo.Location = new System.Drawing.Point(185, 186);
            this.lbTelCislo.Name = "lbTelCislo";
            this.lbTelCislo.Size = new System.Drawing.Size(82, 13);
            this.lbTelCislo.TabIndex = 32;
            this.lbTelCislo.Text = "Telefonní číslo:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(534, 179);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(154, 20);
            this.tbEmail.TabIndex = 31;
            // 
            // tbTelCislo
            // 
            this.tbTelCislo.Location = new System.Drawing.Point(272, 180);
            this.tbTelCislo.Name = "tbTelCislo";
            this.tbTelCislo.Size = new System.Drawing.Size(154, 20);
            this.tbTelCislo.TabIndex = 30;
            // 
            // lbAdresa
            // 
            this.lbAdresa.AutoSize = true;
            this.lbAdresa.Location = new System.Drawing.Point(185, 118);
            this.lbAdresa.Name = "lbAdresa";
            this.lbAdresa.Size = new System.Drawing.Size(40, 13);
            this.lbAdresa.TabIndex = 29;
            this.lbAdresa.Text = "Adresa";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(450, 185);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 33;
            this.lbEmail.Text = "Email:";
            // 
            // tbJmenoPrijmeni
            // 
            this.tbJmenoPrijmeni.Location = new System.Drawing.Point(188, 95);
            this.tbJmenoPrijmeni.Name = "tbJmenoPrijmeni";
            this.tbJmenoPrijmeni.Size = new System.Drawing.Size(500, 20);
            this.tbJmenoPrijmeni.TabIndex = 34;
            // 
            // lvObjednavka
            // 
            this.lvObjednavka.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.cenaPolozky});
            this.lvObjednavka.FullRowSelect = true;
            this.lvObjednavka.HideSelection = false;
            this.lvObjednavka.Location = new System.Drawing.Point(99, 260);
            this.lvObjednavka.Name = "lvObjednavka";
            this.lvObjednavka.Size = new System.Drawing.Size(589, 337);
            this.lvObjednavka.TabIndex = 35;
            this.lvObjednavka.UseCompatibleStateImageBehavior = false;
            this.lvObjednavka.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Id";
            // 
            // name
            // 
            this.name.Text = "Název";
            this.name.Width = 241;
            // 
            // cenaPolozky
            // 
            this.cenaPolozky.Text = "Cena";
            this.cenaPolozky.Width = 149;
            // 
            // btnPridatDoSeznamu
            // 
            this.btnPridatDoSeznamu.Location = new System.Drawing.Point(703, 260);
            this.btnPridatDoSeznamu.Name = "btnPridatDoSeznamu";
            this.btnPridatDoSeznamu.Size = new System.Drawing.Size(42, 37);
            this.btnPridatDoSeznamu.TabIndex = 36;
            this.btnPridatDoSeznamu.Text = "+";
            this.btnPridatDoSeznamu.UseVisualStyleBackColor = true;
            this.btnPridatDoSeznamu.Click += new System.EventHandler(this.BtnPridatDoSeznamu_Click);
            // 
            // lbObjednavka
            // 
            this.lbObjednavka.AutoSize = true;
            this.lbObjednavka.Location = new System.Drawing.Point(96, 231);
            this.lbObjednavka.Name = "lbObjednavka";
            this.lbObjednavka.Size = new System.Drawing.Size(68, 13);
            this.lbObjednavka.TabIndex = 37;
            this.lbObjednavka.Text = "Objednávka:";
            // 
            // cbJmenoPrijmeni
            // 
            this.cbJmenoPrijmeni.FormattingEnabled = true;
            this.cbJmenoPrijmeni.Location = new System.Drawing.Point(188, 68);
            this.cbJmenoPrijmeni.Name = "cbJmenoPrijmeni";
            this.cbJmenoPrijmeni.Size = new System.Drawing.Size(500, 21);
            this.cbJmenoPrijmeni.TabIndex = 38;
            this.cbJmenoPrijmeni.SelectedIndexChanged += new System.EventHandler(this.CbJmenoPrijmeni_SelectedIndexChanged);
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(188, 134);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(500, 20);
            this.tbAdresa.TabIndex = 39;
            // 
            // btnOdeberZeSeznamu
            // 
            this.btnOdeberZeSeznamu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdeberZeSeznamu.Location = new System.Drawing.Point(703, 326);
            this.btnOdeberZeSeznamu.Name = "btnOdeberZeSeznamu";
            this.btnOdeberZeSeznamu.Size = new System.Drawing.Size(42, 37);
            this.btnOdeberZeSeznamu.TabIndex = 40;
            this.btnOdeberZeSeznamu.Text = "-";
            this.btnOdeberZeSeznamu.UseVisualStyleBackColor = true;
            this.btnOdeberZeSeznamu.Click += new System.EventHandler(this.btnOdeberZeSeznamu_Click);
            // 
            // FormNovaObjednavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(840, 667);
            this.Controls.Add(this.btnOdeberZeSeznamu);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.cbJmenoPrijmeni);
            this.Controls.Add(this.lbObjednavka);
            this.Controls.Add(this.btnPridatDoSeznamu);
            this.Controls.Add(this.lvObjednavka);
            this.Controls.Add(this.tbJmenoPrijmeni);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbTelCislo);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbTelCislo);
            this.Controls.Add(this.lbAdresa);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.btnKonec);
            this.Controls.Add(this.lbCena);
            this.Controls.Add(this.lbZakaznik);
            this.Controls.Add(this.btnPridej);
            this.Controls.Add(this.tbCena);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNovaObjednavka";
            this.Text = "Nová objednávka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnKonec;
        private System.Windows.Forms.Label lbCena;
        private System.Windows.Forms.Label lbZakaznik;
        private System.Windows.Forms.Button btnPridej;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.Label lbTelCislo;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTelCislo;
        private System.Windows.Forms.Label lbAdresa;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbJmenoPrijmeni;
        private System.Windows.Forms.ListView lvObjednavka;
        private System.Windows.Forms.Button btnPridatDoSeznamu;
        private System.Windows.Forms.Label lbObjednavka;
        private System.Windows.Forms.ComboBox cbJmenoPrijmeni;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader cenaPolozky;
        private System.Windows.Forms.Button btnOdeberZeSeznamu;
        private System.Windows.Forms.ColumnHeader id;
    }
}