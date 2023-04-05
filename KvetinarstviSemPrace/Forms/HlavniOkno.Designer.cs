namespace KvetinarstviSemPrace
{
    partial class HlavniOkno
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
            this.components = new System.ComponentModel.Container();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.lbCas = new System.Windows.Forms.Label();
            this.lbDatum = new System.Windows.Forms.Label();
            this.btnKvetiny = new System.Windows.Forms.Button();
            this.btnKytice = new System.Windows.Forms.Button();
            this.btnObjednavky = new System.Windows.Forms.Button();
            this.btnProdej = new System.Windows.Forms.Button();
            this.btnZakaznici = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.lbNazev = new System.Windows.Forms.Label();
            this.btnUloz = new System.Windows.Forms.Button();
            this.titulPanel = new System.Windows.Forms.Panel();
            this.hlavniPanel = new System.Windows.Forms.Panel();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.logoPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.titulPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.White;
            this.logoPanel.BackgroundImage = global::KvetinarstviSemPrace.Properties.Resources.ic1;
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoPanel.Controls.Add(this.lbCas);
            this.logoPanel.Controls.Add(this.lbDatum);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(199, 128);
            this.logoPanel.TabIndex = 0;
            // 
            // lbCas
            // 
            this.lbCas.AutoSize = true;
            this.lbCas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCas.Location = new System.Drawing.Point(58, 99);
            this.lbCas.Name = "lbCas";
            this.lbCas.Size = new System.Drawing.Size(32, 15);
            this.lbCas.TabIndex = 1;
            this.lbCas.Text = "Čas:";
            // 
            // lbDatum
            // 
            this.lbDatum.AutoSize = true;
            this.lbDatum.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbDatum.Location = new System.Drawing.Point(19, 71);
            this.lbDatum.Name = "lbDatum";
            this.lbDatum.Size = new System.Drawing.Size(47, 15);
            this.lbDatum.TabIndex = 0;
            this.lbDatum.Text = "Datum:";
            // 
            // btnKvetiny
            // 
            this.btnKvetiny.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKvetiny.FlatAppearance.BorderSize = 0;
            this.btnKvetiny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKvetiny.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnKvetiny.ForeColor = System.Drawing.Color.Black;
            this.btnKvetiny.Image = global::KvetinarstviSemPrace.Properties.Resources.pl4;
            this.btnKvetiny.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKvetiny.Location = new System.Drawing.Point(0, 128);
            this.btnKvetiny.Name = "btnKvetiny";
            this.btnKvetiny.Size = new System.Drawing.Size(199, 60);
            this.btnKvetiny.TabIndex = 1;
            this.btnKvetiny.Text = "Květiny";
            this.btnKvetiny.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKvetiny.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKvetiny.UseVisualStyleBackColor = true;
            this.btnKvetiny.Click += new System.EventHandler(this.BtnKvetiny_Click);
            // 
            // btnKytice
            // 
            this.btnKytice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKytice.FlatAppearance.BorderSize = 0;
            this.btnKytice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKytice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnKytice.ForeColor = System.Drawing.Color.Black;
            this.btnKytice.Image = global::KvetinarstviSemPrace.Properties.Resources.pl7;
            this.btnKytice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKytice.Location = new System.Drawing.Point(0, 188);
            this.btnKytice.Name = "btnKytice";
            this.btnKytice.Size = new System.Drawing.Size(199, 60);
            this.btnKytice.TabIndex = 2;
            this.btnKytice.Text = "Kytice";
            this.btnKytice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKytice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKytice.UseVisualStyleBackColor = true;
            this.btnKytice.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnObjednavky
            // 
            this.btnObjednavky.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnObjednavky.FlatAppearance.BorderSize = 0;
            this.btnObjednavky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObjednavky.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnObjednavky.ForeColor = System.Drawing.Color.Black;
            this.btnObjednavky.Image = global::KvetinarstviSemPrace.Properties.Resources.pl54;
            this.btnObjednavky.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObjednavky.Location = new System.Drawing.Point(0, 248);
            this.btnObjednavky.Name = "btnObjednavky";
            this.btnObjednavky.Size = new System.Drawing.Size(199, 60);
            this.btnObjednavky.TabIndex = 3;
            this.btnObjednavky.Text = "Objednavky";
            this.btnObjednavky.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObjednavky.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObjednavky.UseVisualStyleBackColor = true;
            this.btnObjednavky.Click += new System.EventHandler(this.BtnObjednavky_Click);
            // 
            // btnProdej
            // 
            this.btnProdej.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProdej.FlatAppearance.BorderSize = 0;
            this.btnProdej.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdej.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnProdej.ForeColor = System.Drawing.Color.Black;
            this.btnProdej.Image = global::KvetinarstviSemPrace.Properties.Resources.pl3;
            this.btnProdej.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdej.Location = new System.Drawing.Point(0, 308);
            this.btnProdej.Name = "btnProdej";
            this.btnProdej.Size = new System.Drawing.Size(199, 60);
            this.btnProdej.TabIndex = 4;
            this.btnProdej.Text = "Prodej";
            this.btnProdej.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdej.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProdej.UseVisualStyleBackColor = true;
            this.btnProdej.Visible = false;
            // 
            // btnZakaznici
            // 
            this.btnZakaznici.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnZakaznici.FlatAppearance.BorderSize = 0;
            this.btnZakaznici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZakaznici.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnZakaznici.ForeColor = System.Drawing.Color.Black;
            this.btnZakaznici.Image = global::KvetinarstviSemPrace.Properties.Resources.pl81;
            this.btnZakaznici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZakaznici.Location = new System.Drawing.Point(0, 368);
            this.btnZakaznici.Name = "btnZakaznici";
            this.btnZakaznici.Size = new System.Drawing.Size(199, 60);
            this.btnZakaznici.TabIndex = 5;
            this.btnZakaznici.Text = "Zákazníci";
            this.btnZakaznici.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZakaznici.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnZakaznici.UseVisualStyleBackColor = true;
            this.btnZakaznici.Click += new System.EventHandler(this.BtnZakaznici_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.menuPanel.Controls.Add(this.btnZakaznici);
            this.menuPanel.Controls.Add(this.btnProdej);
            this.menuPanel.Controls.Add(this.btnObjednavky);
            this.menuPanel.Controls.Add(this.btnKytice);
            this.menuPanel.Controls.Add(this.btnKvetiny);
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(199, 507);
            this.menuPanel.TabIndex = 0;
            // 
            // lbNazev
            // 
            this.lbNazev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbNazev.AutoSize = true;
            this.lbNazev.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNazev.Location = new System.Drawing.Point(24, 19);
            this.lbNazev.Name = "lbNazev";
            this.lbNazev.Size = new System.Drawing.Size(80, 30);
            this.lbNazev.TabIndex = 0;
            this.lbNazev.Text = "ÚVOD";
            // 
            // btnUloz
            // 
            this.btnUloz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.btnUloz.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUloz.FlatAppearance.BorderSize = 0;
            this.btnUloz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUloz.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnUloz.Image = global::KvetinarstviSemPrace.Properties.Resources.pl8;
            this.btnUloz.Location = new System.Drawing.Point(800, 0);
            this.btnUloz.Name = "btnUloz";
            this.btnUloz.Size = new System.Drawing.Size(170, 60);
            this.btnUloz.TabIndex = 1;
            this.btnUloz.Text = "Uložit záznamy";
            this.btnUloz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUloz.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUloz.UseVisualStyleBackColor = true;
            this.btnUloz.Click += new System.EventHandler(this.BtnUloz_Click);
            // 
            // titulPanel
            // 
            this.titulPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.titulPanel.Controls.Add(this.btnUloz);
            this.titulPanel.Controls.Add(this.lbNazev);
            this.titulPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titulPanel.Location = new System.Drawing.Point(199, 0);
            this.titulPanel.Name = "titulPanel";
            this.titulPanel.Size = new System.Drawing.Size(970, 60);
            this.titulPanel.TabIndex = 1;
            // 
            // hlavniPanel
            // 
            this.hlavniPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hlavniPanel.Location = new System.Drawing.Point(199, 60);
            this.hlavniPanel.Name = "hlavniPanel";
            this.hlavniPanel.Size = new System.Drawing.Size(970, 447);
            this.hlavniPanel.TabIndex = 2;
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // HlavniOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 507);
            this.Controls.Add(this.hlavniPanel);
            this.Controls.Add(this.titulPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "HlavniOkno";
            this.Text = "Úvod";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HlavniOkno_FormClosing);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.titulPanel.ResumeLayout(false);
            this.titulPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Button btnKvetiny;
        private System.Windows.Forms.Button btnKytice;
        private System.Windows.Forms.Button btnObjednavky;
        private System.Windows.Forms.Button btnProdej;
        private System.Windows.Forms.Button btnZakaznici;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label lbNazev;
        private System.Windows.Forms.Button btnUloz;
        private System.Windows.Forms.Panel titulPanel;
        private System.Windows.Forms.Panel hlavniPanel;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.Label lbCas;
        private System.Windows.Forms.Label lbDatum;
    }
}

