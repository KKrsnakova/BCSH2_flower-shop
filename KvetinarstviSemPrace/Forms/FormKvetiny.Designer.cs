namespace KvetinarstviSemPrace.Forms
{
    partial class FormKvetiny
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnOdebrat = new System.Windows.Forms.Button();
            this.btnPridet = new System.Windows.Forms.Button();
            this.lvKvetiny = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nazev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.druhKvetiny = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.popis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.MenuPanel.TabIndex = 0;
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
            // lvKvetiny
            // 
            this.lvKvetiny.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nazev,
            this.druhKvetiny,
            this.cena,
            this.popis});
            this.lvKvetiny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvKvetiny.FullRowSelect = true;
            this.lvKvetiny.HideSelection = false;
            this.lvKvetiny.Location = new System.Drawing.Point(0, 0);
            this.lvKvetiny.Name = "lvKvetiny";
            this.lvKvetiny.Size = new System.Drawing.Size(620, 450);
            this.lvKvetiny.TabIndex = 1;
            this.lvKvetiny.UseCompatibleStateImageBehavior = false;
            this.lvKvetiny.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Id";
            // 
            // nazev
            // 
            this.nazev.Text = "Název";
            this.nazev.Width = 168;
            // 
            // druhKvetiny
            // 
            this.druhKvetiny.Text = "Druh květiny";
            this.druhKvetiny.Width = 112;
            // 
            // cena
            // 
            this.cena.Text = "Cena";
            this.cena.Width = 77;
            // 
            // popis
            // 
            this.popis.Text = "Popis";
            this.popis.Width = 250;
            // 
            // FormKvetiny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvKvetiny);
            this.Controls.Add(this.MenuPanel);
            this.Name = "FormKvetiny";
            this.Text = "Květiny";
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button btnPridet;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnOdebrat;
        private System.Windows.Forms.ListView lvKvetiny;
        private System.Windows.Forms.ColumnHeader nazev;
        private System.Windows.Forms.ColumnHeader druhKvetiny;
        private System.Windows.Forms.ColumnHeader cena;
        private System.Windows.Forms.ColumnHeader popis;
        private System.Windows.Forms.ColumnHeader id;
    }
}