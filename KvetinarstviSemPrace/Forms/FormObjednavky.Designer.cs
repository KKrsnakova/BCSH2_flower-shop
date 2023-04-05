namespace KvetinarstviSemPrace.Forms
{
    partial class FormObjednavky
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.BtnSplneno = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnOdebrat = new System.Windows.Forms.Button();
            this.btnPridet = new System.Windows.Forms.Button();
            this.lvObjednavky = new System.Windows.Forms.ListView();
            this.idObjednavka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zakaznik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datumVytvoreni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splneno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datumSplneni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.MenuPanel.Controls.Add(this.BtnSplneno);
            this.MenuPanel.Controls.Add(this.btnEdit);
            this.MenuPanel.Controls.Add(this.btnOdebrat);
            this.MenuPanel.Controls.Add(this.btnPridet);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MenuPanel.Location = new System.Drawing.Point(784, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(180, 450);
            this.MenuPanel.TabIndex = 1;
            // 
            // BtnSplneno
            // 
            this.BtnSplneno.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSplneno.FlatAppearance.BorderSize = 0;
            this.BtnSplneno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSplneno.ForeColor = System.Drawing.Color.Black;
            this.BtnSplneno.Image = global::KvetinarstviSemPrace.Properties.Resources.pl4;
            this.BtnSplneno.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnSplneno.Location = new System.Drawing.Point(0, 180);
            this.BtnSplneno.Name = "BtnSplneno";
            this.BtnSplneno.Size = new System.Drawing.Size(180, 60);
            this.BtnSplneno.TabIndex = 5;
            this.BtnSplneno.Text = "Splněno";
            this.BtnSplneno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSplneno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSplneno.UseVisualStyleBackColor = true;
            this.BtnSplneno.Click += new System.EventHandler(this.BtnSplneno_Click);
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
            // lvObjednavky
            // 
            this.lvObjednavky.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idObjednavka,
            this.zakaznik,
            this.cena,
            this.datumVytvoreni,
            this.splneno,
            this.datumSplneni});
            this.lvObjednavky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvObjednavky.HideSelection = false;
            this.lvObjednavky.Location = new System.Drawing.Point(0, 0);
            this.lvObjednavky.Name = "lvObjednavky";
            this.lvObjednavky.Size = new System.Drawing.Size(784, 450);
            this.lvObjednavky.TabIndex = 2;
            this.lvObjednavky.UseCompatibleStateImageBehavior = false;
            this.lvObjednavky.View = System.Windows.Forms.View.Details;
            this.lvObjednavky.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LvObjednavky_ColumnClick);
            // 
            // idObjednavka
            // 
            this.idObjednavka.Text = "ID objednávka";
            this.idObjednavka.Width = 90;
            // 
            // zakaznik
            // 
            this.zakaznik.Text = "Zákazník";
            this.zakaznik.Width = 212;
            // 
            // cena
            // 
            this.cena.Text = "Cena";
            this.cena.Width = 70;
            // 
            // datumVytvoreni
            // 
            this.datumVytvoreni.Text = "Datum vytvoření";
            this.datumVytvoreni.Width = 144;
            // 
            // splneno
            // 
            this.splneno.Text = "Splněno";
            this.splneno.Width = 56;
            // 
            // datumSplneni
            // 
            this.datumSplneni.Text = "Datum splnění";
            this.datumSplneni.Width = 143;
            // 
            // FormObjednavky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.lvObjednavky);
            this.Controls.Add(this.MenuPanel);
            this.Name = "FormObjednavky";
            this.Text = "Objednávky";
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnOdebrat;
        private System.Windows.Forms.Button btnPridet;
        private System.Windows.Forms.ListView lvObjednavky;
        private System.Windows.Forms.ColumnHeader idObjednavka;
        private System.Windows.Forms.ColumnHeader zakaznik;
        private System.Windows.Forms.ColumnHeader cena;
        private System.Windows.Forms.ColumnHeader datumVytvoreni;
        private System.Windows.Forms.ColumnHeader splneno;
        private System.Windows.Forms.Button BtnSplneno;
        private System.Windows.Forms.ColumnHeader datumSplneni;
    }
}