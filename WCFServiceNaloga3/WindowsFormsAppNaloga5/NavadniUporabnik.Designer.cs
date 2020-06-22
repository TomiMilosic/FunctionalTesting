namespace WindowsFormsAppNaloga5
{
    partial class NavadniUporabnik
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
            this.Prikaz_Uporabnikov = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UporabniskoIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Geslo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Admin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Prikaz_Uporabnikov
            // 
            this.Prikaz_Uporabnikov.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.UporabniskoIme,
            this.Geslo,
            this.Admin});
            this.Prikaz_Uporabnikov.FullRowSelect = true;
            this.Prikaz_Uporabnikov.GridLines = true;
            this.Prikaz_Uporabnikov.HideSelection = false;
            this.Prikaz_Uporabnikov.Location = new System.Drawing.Point(180, 61);
            this.Prikaz_Uporabnikov.Name = "Prikaz_Uporabnikov";
            this.Prikaz_Uporabnikov.Size = new System.Drawing.Size(377, 257);
            this.Prikaz_Uporabnikov.TabIndex = 0;
            this.Prikaz_Uporabnikov.UseCompatibleStateImageBehavior = false;
            this.Prikaz_Uporabnikov.View = System.Windows.Forms.View.Details;
            this.Prikaz_Uporabnikov.Click += new System.EventHandler(this.Prikaz_Uporabnikov_Click);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // UporabniskoIme
            // 
            this.UporabniskoIme.Text = "Uporabnisko ime:";
            this.UporabniskoIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UporabniskoIme.Width = 123;
            // 
            // Geslo
            // 
            this.Geslo.Text = "Geslo:";
            this.Geslo.Width = 120;
            // 
            // Admin
            // 
            this.Admin.Text = "Admin";
            // 
            // NavadniUporabnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Prikaz_Uporabnikov);
            this.Name = "NavadniUporabnik";
            this.Text = "NavadniUporabnik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Prikaz_Uporabnikov;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader UporabniskoIme;
        private System.Windows.Forms.ColumnHeader Geslo;
        private System.Windows.Forms.ColumnHeader Admin;
    }
}