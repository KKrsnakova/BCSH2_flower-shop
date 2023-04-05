namespace KvetinarstviSemPrace.Forms
{
    partial class FormZakaznici
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
            this.lvZakaznici = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jmeno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prijmeni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telCislo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnOdebrat = new System.Windows.Forms.Button();
            this.btnPridet = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvZakaznici
            // 
            this.lvZakaznici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.jmeno,
            this.prijmeni,
            this.adresa,
            this.telCislo,
            this.email});
            this.lvZakaznici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvZakaznici.HideSelection = false;
            this.lvZakaznici.Location = new System.Drawing.Point(0, 0);
            this.lvZakaznici.Name = "lvZakaznici";
            this.lvZakaznici.Size = new System.Drawing.Size(800, 450);
            this.lvZakaznici.TabIndex = 2;
            this.lvZakaznici.UseCompatibleStateImageBehavior = false;
            this.lvZakaznici.View = System.Windows.Forms.View.Details;
            this.lvZakaznici.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LvZakaznici_ColumnClick);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // jmeno
            // 
            this.jmeno.Text = "Jméno";
            this.jmeno.Width = 77;
            // 
            // prijmeni
            // 
            this.prijmeni.Text = "Příjmení";
            this.prijmeni.Width = 86;
            // 
            // adresa
            // 
            this.adresa.Text = "Adresa";
            this.adresa.Width = 135;
            // 
            // telCislo
            // 
            this.telCislo.Text = "Telefonní číslo";
            this.telCislo.Width = 122;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 250;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.MenuPanel.Controls.Add(this.btnEdit);
            this.MenuPanel.Controls.Add(this.btnOdebrat);
            this.MenuPanel.Controls.Add(this.btnPridet);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MenuPanel.Location = new System.Drawing.Point(620, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(180, 450);
            this.MenuPanel.TabIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Image = global::KvetinarstviSemPrace.Properties.Resources.pl4;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEdit.Location = new System.Drawing.Point(0, 120);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(180, 60);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Editovat";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnOdebrat
            // 
            this.btnOdebrat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOdebrat.FlatAppearance.BorderSize = 0;
            this.btnOdebrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdebrat.ForeColor = System.Drawing.Color.Black;
            this.btnOdebrat.Image = global::KvetinarstviSemPrace.Properties.Resources.pl4;
            this.btnOdebrat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdebrat.Location = new System.Drawing.Point(0, 60);
            this.btnOdebrat.Name = "btnOdebrat";
            this.btnOdebrat.Size = new System.Drawing.Size(180, 60);
            this.btnOdebrat.TabIndex = 3;
            this.btnOdebrat.Text = "Odebrat";
            this.btnOdebrat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdebrat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOdebrat.UseVisualStyleBackColor = true;
            this.btnOdebrat.Click += new System.EventHandler(this.BtnOdebrat_Click);
            // 
            // btnPridet
            // 
            this.btnPridet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPridet.FlatAppearance.BorderSize = 0;
            this.btnPridet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPridet.ForeColor = System.Drawing.Color.Black;
            this.btnPridet.Image = global::KvetinarstviSemPrace.Properties.Resources.pl4;
            this.btnPridet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPridet.Location = new System.Drawing.Point(0, 0);
            this.btnPridet.Name = "btnPridet";
            this.btnPridet.Size = new System.Drawing.Size(180, 60);
            this.btnPridet.TabIndex = 2;
            this.btnPridet.Text = "Přidat";
            this.btnPridet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPridet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPridet.UseVisualStyleBackColor = true;
            this.btnPridet.Click += new System.EventHandler(this.BtnPridet_Click);
            // 
            // FormZakaznici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.lvZakaznici);
            this.Name = "FormZakaznici";
            this.Text = "Zákazníci";
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvZakaznici;
        private System.Windows.Forms.ColumnHeader jmeno;
        private System.Windows.Forms.ColumnHeader prijmeni;
        private System.Windows.Forms.ColumnHeader adresa;
        private System.Windows.Forms.ColumnHeader telCislo;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnOdebrat;
        private System.Windows.Forms.Button btnPridet;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader id;
    }
}