namespace WindowsFormsAppNaloga5
{
    partial class Vmestna
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
            this.Prikaz_AvtoSalonov = new System.Windows.Forms.ListView();
            this.ID_Avtosalon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Avtosalon_Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Avtosalon_Kraj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Avtosalon_Leto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prikaz_Avtov = new System.Windows.Forms.ListView();
            this.ID_Avta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Znamka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VmestnaList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.e = new System.Windows.Forms.Label();
            this.FKAvtoPolje = new System.Windows.Forms.TextBox();
            this.FK_AvtoSalon = new System.Windows.Forms.Label();
            this.FKAvtoSalonPolje = new System.Windows.Forms.TextBox();
            this.OdstraniVmestna = new System.Windows.Forms.Button();
            this.DodajVmestna = new System.Windows.Forms.Button();
            this.UrediVmestna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Prikaz_AvtoSalonov
            // 
            this.Prikaz_AvtoSalonov.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Avtosalon,
            this.Avtosalon_Naziv,
            this.Avtosalon_Kraj,
            this.Avtosalon_Leto});
            this.Prikaz_AvtoSalonov.FullRowSelect = true;
            this.Prikaz_AvtoSalonov.GridLines = true;
            this.Prikaz_AvtoSalonov.HideSelection = false;
            this.Prikaz_AvtoSalonov.Location = new System.Drawing.Point(765, 90);
            this.Prikaz_AvtoSalonov.Name = "Prikaz_AvtoSalonov";
            this.Prikaz_AvtoSalonov.Size = new System.Drawing.Size(316, 270);
            this.Prikaz_AvtoSalonov.TabIndex = 13;
            this.Prikaz_AvtoSalonov.UseCompatibleStateImageBehavior = false;
            this.Prikaz_AvtoSalonov.View = System.Windows.Forms.View.Details;
            this.Prikaz_AvtoSalonov.Click += new System.EventHandler(this.Prikaz_AvtoSalonov_Click);
            // 
            // ID_Avtosalon
            // 
            this.ID_Avtosalon.Text = "ID";
            // 
            // Avtosalon_Naziv
            // 
            this.Avtosalon_Naziv.Text = "Naziv";
            // 
            // Avtosalon_Kraj
            // 
            this.Avtosalon_Kraj.Text = "Kraj";
            // 
            // Avtosalon_Leto
            // 
            this.Avtosalon_Leto.Text = "Leto Ustanovitve";
            this.Avtosalon_Leto.Width = 122;
            // 
            // Prikaz_Avtov
            // 
            this.Prikaz_Avtov.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Avta,
            this.Znamka,
            this.Model,
            this.Cena});
            this.Prikaz_Avtov.FullRowSelect = true;
            this.Prikaz_Avtov.GridLines = true;
            this.Prikaz_Avtov.HideSelection = false;
            this.Prikaz_Avtov.Location = new System.Drawing.Point(24, 90);
            this.Prikaz_Avtov.Name = "Prikaz_Avtov";
            this.Prikaz_Avtov.Size = new System.Drawing.Size(319, 270);
            this.Prikaz_Avtov.TabIndex = 12;
            this.Prikaz_Avtov.UseCompatibleStateImageBehavior = false;
            this.Prikaz_Avtov.View = System.Windows.Forms.View.Details;
            this.Prikaz_Avtov.Click += new System.EventHandler(this.Prikaz_Avtov_Click);
            // 
            // ID_Avta
            // 
            this.ID_Avta.Text = "ID";
            this.ID_Avta.Width = 63;
            // 
            // Znamka
            // 
            this.Znamka.Text = "Znamka";
            this.Znamka.Width = 77;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.Width = 86;
            // 
            // Cena
            // 
            this.Cena.Text = "Cena";
            this.Cena.Width = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(874, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Avtosaloni";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Avti";
            // 
            // VmestnaList
            // 
            this.VmestnaList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.VmestnaList.FullRowSelect = true;
            this.VmestnaList.GridLines = true;
            this.VmestnaList.HideSelection = false;
            this.VmestnaList.Location = new System.Drawing.Point(427, 90);
            this.VmestnaList.Name = "VmestnaList";
            this.VmestnaList.Size = new System.Drawing.Size(269, 270);
            this.VmestnaList.TabIndex = 16;
            this.VmestnaList.UseCompatibleStateImageBehavior = false;
            this.VmestnaList.View = System.Windows.Forms.View.Details;
            this.VmestnaList.Click += new System.EventHandler(this.VmestnaList_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FK_Avto";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "FK_Avtosalon";
            this.columnHeader3.Width = 86;
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Location = new System.Drawing.Point(427, 399);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(48, 13);
            this.e.TabIndex = 17;
            this.e.Text = "FK_Avto";
            // 
            // FKAvtoPolje
            // 
            this.FKAvtoPolje.Location = new System.Drawing.Point(427, 416);
            this.FKAvtoPolje.Name = "FKAvtoPolje";
            this.FKAvtoPolje.Size = new System.Drawing.Size(269, 20);
            this.FKAvtoPolje.TabIndex = 18;
            // 
            // FK_AvtoSalon
            // 
            this.FK_AvtoSalon.AutoSize = true;
            this.FK_AvtoSalon.Location = new System.Drawing.Point(427, 456);
            this.FK_AvtoSalon.Name = "FK_AvtoSalon";
            this.FK_AvtoSalon.Size = new System.Drawing.Size(75, 13);
            this.FK_AvtoSalon.TabIndex = 19;
            this.FK_AvtoSalon.Text = "FK_AvtoSalon";
            // 
            // FKAvtoSalonPolje
            // 
            this.FKAvtoSalonPolje.Location = new System.Drawing.Point(427, 473);
            this.FKAvtoSalonPolje.Name = "FKAvtoSalonPolje";
            this.FKAvtoSalonPolje.Size = new System.Drawing.Size(269, 20);
            this.FKAvtoSalonPolje.TabIndex = 20;
            // 
            // OdstraniVmestna
            // 
            this.OdstraniVmestna.Location = new System.Drawing.Point(528, 523);
            this.OdstraniVmestna.Name = "OdstraniVmestna";
            this.OdstraniVmestna.Size = new System.Drawing.Size(75, 23);
            this.OdstraniVmestna.TabIndex = 23;
            this.OdstraniVmestna.Text = "Odstrani";
            this.OdstraniVmestna.UseVisualStyleBackColor = true;
            this.OdstraniVmestna.Click += new System.EventHandler(this.OdstraniVmestna_Click);
            // 
            // DodajVmestna
            // 
            this.DodajVmestna.Location = new System.Drawing.Point(430, 523);
            this.DodajVmestna.Name = "DodajVmestna";
            this.DodajVmestna.Size = new System.Drawing.Size(75, 23);
            this.DodajVmestna.TabIndex = 24;
            this.DodajVmestna.Text = "Dodaj";
            this.DodajVmestna.UseVisualStyleBackColor = true;
            this.DodajVmestna.Click += new System.EventHandler(this.DodajVmestna_Click);
            // 
            // UrediVmestna
            // 
            this.UrediVmestna.Location = new System.Drawing.Point(621, 523);
            this.UrediVmestna.Name = "UrediVmestna";
            this.UrediVmestna.Size = new System.Drawing.Size(75, 23);
            this.UrediVmestna.TabIndex = 25;
            this.UrediVmestna.Text = "Uredi";
            this.UrediVmestna.UseVisualStyleBackColor = true;
            this.UrediVmestna.Click += new System.EventHandler(this.UrediVmestna_Click);
            // 
            // Vmestna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 591);
            this.Controls.Add(this.UrediVmestna);
            this.Controls.Add(this.DodajVmestna);
            this.Controls.Add(this.OdstraniVmestna);
            this.Controls.Add(this.FKAvtoSalonPolje);
            this.Controls.Add(this.FK_AvtoSalon);
            this.Controls.Add(this.FKAvtoPolje);
            this.Controls.Add(this.e);
            this.Controls.Add(this.VmestnaList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prikaz_AvtoSalonov);
            this.Controls.Add(this.Prikaz_Avtov);
            this.Name = "Vmestna";
            this.Text = "Vmestna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView Prikaz_AvtoSalonov;
        private System.Windows.Forms.ColumnHeader ID_Avtosalon;
        private System.Windows.Forms.ColumnHeader Avtosalon_Naziv;
        private System.Windows.Forms.ColumnHeader Avtosalon_Kraj;
        private System.Windows.Forms.ColumnHeader Avtosalon_Leto;
        public System.Windows.Forms.ListView Prikaz_Avtov;
        private System.Windows.Forms.ColumnHeader ID_Avta;
        private System.Windows.Forms.ColumnHeader Znamka;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Cena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView VmestnaList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.TextBox FKAvtoPolje;
        private System.Windows.Forms.Label FK_AvtoSalon;
        private System.Windows.Forms.TextBox FKAvtoSalonPolje;
        private System.Windows.Forms.Button OdstraniVmestna;
        private System.Windows.Forms.Button DodajVmestna;
        private System.Windows.Forms.Button UrediVmestna;
    }
}