namespace WindowsFormsAppNaloga5
{
    partial class Admin
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
            this.Prikaz_Avtov = new System.Windows.Forms.ListView();
            this.ID_Avta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Znamka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.Prikaz_AvtoSalonov = new System.Windows.Forms.ListView();
            this.ID_Avtosalon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Avtosalon_Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Avtosalon_Kraj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Avtosalon_Leto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.DodajAvtoBTN = new System.Windows.Forms.Button();
            this.DodajAvtoSalonBTN = new System.Windows.Forms.Button();
            this.OdstraniAvtoBTN = new System.Windows.Forms.Button();
            this.OdstraniAvtosalonBTN = new System.Windows.Forms.Button();
            this.UrediAvtoBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.Prikaz_Avtov.Location = new System.Drawing.Point(35, 77);
            this.Prikaz_Avtov.Name = "Prikaz_Avtov";
            this.Prikaz_Avtov.Size = new System.Drawing.Size(319, 270);
            this.Prikaz_Avtov.TabIndex = 0;
            this.Prikaz_Avtov.UseCompatibleStateImageBehavior = false;
            this.Prikaz_Avtov.View = System.Windows.Forms.View.Details;
            this.Prikaz_Avtov.SelectedIndexChanged += new System.EventHandler(this.Prikaz_Avtov_SelectedIndexChanged);
            this.Prikaz_Avtov.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Prikaz_Avtov_MouseClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Avti";
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
            this.Prikaz_AvtoSalonov.Location = new System.Drawing.Point(472, 77);
            this.Prikaz_AvtoSalonov.Name = "Prikaz_AvtoSalonov";
            this.Prikaz_AvtoSalonov.Size = new System.Drawing.Size(316, 270);
            this.Prikaz_AvtoSalonov.TabIndex = 3;
            this.Prikaz_AvtoSalonov.UseCompatibleStateImageBehavior = false;
            this.Prikaz_AvtoSalonov.View = System.Windows.Forms.View.Details;
            this.Prikaz_AvtoSalonov.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(600, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Avtosaloni";
            // 
            // DodajAvtoBTN
            // 
            this.DodajAvtoBTN.Location = new System.Drawing.Point(35, 366);
            this.DodajAvtoBTN.Name = "DodajAvtoBTN";
            this.DodajAvtoBTN.Size = new System.Drawing.Size(75, 23);
            this.DodajAvtoBTN.TabIndex = 5;
            this.DodajAvtoBTN.Text = "Dodaj avto";
            this.DodajAvtoBTN.UseVisualStyleBackColor = true;
            this.DodajAvtoBTN.Click += new System.EventHandler(this.DodajAvtoBTN_Click);
            // 
            // DodajAvtoSalonBTN
            // 
            this.DodajAvtoSalonBTN.Location = new System.Drawing.Point(472, 366);
            this.DodajAvtoSalonBTN.Name = "DodajAvtoSalonBTN";
            this.DodajAvtoSalonBTN.Size = new System.Drawing.Size(94, 23);
            this.DodajAvtoSalonBTN.TabIndex = 6;
            this.DodajAvtoSalonBTN.Text = "Dodaj Avtosalon";
            this.DodajAvtoSalonBTN.UseVisualStyleBackColor = true;
            this.DodajAvtoSalonBTN.Click += new System.EventHandler(this.DodajAvtoSalonBTN_Click);
            // 
            // OdstraniAvtoBTN
            // 
            this.OdstraniAvtoBTN.Location = new System.Drawing.Point(245, 366);
            this.OdstraniAvtoBTN.Name = "OdstraniAvtoBTN";
            this.OdstraniAvtoBTN.Size = new System.Drawing.Size(109, 23);
            this.OdstraniAvtoBTN.TabIndex = 7;
            this.OdstraniAvtoBTN.Text = "Odstrani Avto";
            this.OdstraniAvtoBTN.UseVisualStyleBackColor = true;
            this.OdstraniAvtoBTN.Click += new System.EventHandler(this.OdstraniAvtoBTN_Click);
            // 
            // OdstraniAvtosalonBTN
            // 
            this.OdstraniAvtosalonBTN.Location = new System.Drawing.Point(682, 366);
            this.OdstraniAvtosalonBTN.Name = "OdstraniAvtosalonBTN";
            this.OdstraniAvtosalonBTN.Size = new System.Drawing.Size(106, 23);
            this.OdstraniAvtosalonBTN.TabIndex = 8;
            this.OdstraniAvtosalonBTN.Text = "Odstrani Avtosalon";
            this.OdstraniAvtosalonBTN.UseVisualStyleBackColor = true;
            this.OdstraniAvtosalonBTN.Click += new System.EventHandler(this.OdstraniAvtosalonBTN_Click);
            // 
            // UrediAvtoBTN
            // 
            this.UrediAvtoBTN.Location = new System.Drawing.Point(148, 366);
            this.UrediAvtoBTN.Name = "UrediAvtoBTN";
            this.UrediAvtoBTN.Size = new System.Drawing.Size(75, 23);
            this.UrediAvtoBTN.TabIndex = 9;
            this.UrediAvtoBTN.Text = "Uredi Avto";
            this.UrediAvtoBTN.UseVisualStyleBackColor = true;
            this.UrediAvtoBTN.Click += new System.EventHandler(this.UrediAvtoBTN_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Uredi avto salon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Vmestna";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UrediAvtoBTN);
            this.Controls.Add(this.OdstraniAvtosalonBTN);
            this.Controls.Add(this.OdstraniAvtoBTN);
            this.Controls.Add(this.DodajAvtoSalonBTN);
            this.Controls.Add(this.DodajAvtoBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Prikaz_AvtoSalonov);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prikaz_Avtov);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader ID_Avta;
        private System.Windows.Forms.ColumnHeader Znamka;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Cena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Prikaz_AvtoSalonov;
        private System.Windows.Forms.ColumnHeader ID_Avtosalon;
        private System.Windows.Forms.ColumnHeader Avtosalon_Naziv;
        private System.Windows.Forms.ColumnHeader Avtosalon_Kraj;
        private System.Windows.Forms.ColumnHeader Avtosalon_Leto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DodajAvtoBTN;
        private System.Windows.Forms.Button DodajAvtoSalonBTN;
        private System.Windows.Forms.Button OdstraniAvtoBTN;
        private System.Windows.Forms.Button OdstraniAvtosalonBTN;
        private System.Windows.Forms.Button UrediAvtoBTN;
        public System.Windows.Forms.ListView Prikaz_Avtov;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}