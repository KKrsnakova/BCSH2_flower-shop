namespace KvetinarstviSemPrace.Forms
{
    partial class FormZbozi
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
            this.lvZbozi = new System.Windows.Forms.ListView();
            this.nazev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.popis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvZbozi
            // 
            this.lvZbozi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nazev,
            this.cena,
            this.popis});
            this.lvZbozi.HideSelection = false;
            this.lvZbozi.Location = new System.Drawing.Point(47, 102);
            this.lvZbozi.Name = "lvZbozi";
            this.lvZbozi.Size = new System.Drawing.Size(684, 364);
            this.lvZbozi.TabIndex = 0;
            this.lvZbozi.UseCompatibleStateImageBehavior = false;
            this.lvZbozi.View = System.Windows.Forms.View.Details;
            this.lvZbozi.SelectedIndexChanged += new System.EventHandler(this.LvZbozi_SelectedIndexChanged);
            // 
            // nazev
            // 
            this.nazev.Text = "Název";
            this.nazev.Width = 164;
            // 
            // cena
            // 
            this.cena.Text = "Cena";
            this.cena.Width = 81;
            // 
            // popis
            // 
            this.popis.Text = "Popis";
            this.popis.Width = 204;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BackgroundImage = global::KvetinarstviSemPrace.Properties.Resources.ic1;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(786, 60);
            this.panelMain.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Poklikem pridejte zboží do objednávky:";
            // 
            // FormZbozi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(786, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.lvZbozi);
            this.Name = "FormZbozi";
            this.Text = "Zboží";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvZbozi;
        private System.Windows.Forms.ColumnHeader nazev;
        private System.Windows.Forms.ColumnHeader cena;
        private System.Windows.Forms.ColumnHeader popis;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
    }
}