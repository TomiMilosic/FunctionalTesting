namespace WindowsFormsAppNaloga5
{
    partial class UrediAvtosalon
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrediLetoPolje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShraniSpremembeSalon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.UrediZnamko = new System.Windows.Forms.Label();
            this.UrediKrajPolje = new System.Windows.Forms.TextBox();
            this.UrediNazivPolje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Prikaz_AvtoSalonov
            // 
            this.Prikaz_AvtoSalonov.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.Prikaz_AvtoSalonov.FullRowSelect = true;
            this.Prikaz_AvtoSalonov.GridLines = true;
            this.Prikaz_AvtoSalonov.HideSelection = false;
            this.Prikaz_AvtoSalonov.Location = new System.Drawing.Point(246, 41);
            this.Prikaz_AvtoSalonov.Name = "Prikaz_AvtoSalonov";
            this.Prikaz_AvtoSalonov.Size = new System.Drawing.Size(530, 160);
            this.Prikaz_AvtoSalonov.TabIndex = 16;
            this.Prikaz_AvtoSalonov.UseCompatibleStateImageBehavior = false;
            this.Prikaz_AvtoSalonov.View = System.Windows.Forms.View.Details;
            this.Prikaz_AvtoSalonov.Click += new System.EventHandler(this.Prikaz_AvtoSalonov_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv";
            this.columnHeader2.Width = 124;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kraj";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Leto Ustanovitve";
            this.columnHeader4.Width = 149;
            // 
            // UrediLetoPolje
            // 
            this.UrediLetoPolje.Location = new System.Drawing.Point(56, 129);
            this.UrediLetoPolje.Name = "UrediLetoPolje";
            this.UrediLetoPolje.Size = new System.Drawing.Size(133, 20);
            this.UrediLetoPolje.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Leto Ustanovitve:";
            // 
            // ShraniSpremembeSalon
            // 
            this.ShraniSpremembeSalon.Location = new System.Drawing.Point(56, 178);
            this.ShraniSpremembeSalon.Name = "ShraniSpremembeSalon";
            this.ShraniSpremembeSalon.Size = new System.Drawing.Size(133, 23);
            this.ShraniSpremembeSalon.TabIndex = 13;
            this.ShraniSpremembeSalon.Text = "Shrani spremembe";
            this.ShraniSpremembeSalon.UseVisualStyleBackColor = true;
            this.ShraniSpremembeSalon.Click += new System.EventHandler(this.ShraniSpremembeSalon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kraj:";
            // 
            // UrediZnamko
            // 
            this.UrediZnamko.AutoSize = true;
            this.UrediZnamko.Location = new System.Drawing.Point(53, 28);
            this.UrediZnamko.Name = "UrediZnamko";
            this.UrediZnamko.Size = new System.Drawing.Size(37, 13);
            this.UrediZnamko.TabIndex = 11;
            this.UrediZnamko.Text = "Naziv:";
            // 
            // UrediKrajPolje
            // 
            this.UrediKrajPolje.Location = new System.Drawing.Point(56, 80);
            this.UrediKrajPolje.Name = "UrediKrajPolje";
            this.UrediKrajPolje.Size = new System.Drawing.Size(133, 20);
            this.UrediKrajPolje.TabIndex = 10;
            // 
            // UrediNazivPolje
            // 
            this.UrediNazivPolje.Location = new System.Drawing.Point(56, 41);
            this.UrediNazivPolje.Name = "UrediNazivPolje";
            this.UrediNazivPolje.Size = new System.Drawing.Size(133, 20);
            this.UrediNazivPolje.TabIndex = 9;
            // 
            // UrediAvtosalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 231);
            this.Controls.Add(this.Prikaz_AvtoSalonov);
            this.Controls.Add(this.UrediLetoPolje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShraniSpremembeSalon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UrediZnamko);
            this.Controls.Add(this.UrediKrajPolje);
            this.Controls.Add(this.UrediNazivPolje);
            this.Name = "UrediAvtosalon";
            this.Text = "UrediAvtosalon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Prikaz_AvtoSalonov;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox UrediLetoPolje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShraniSpremembeSalon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UrediZnamko;
        private System.Windows.Forms.TextBox UrediKrajPolje;
        private System.Windows.Forms.TextBox UrediNazivPolje;
    }
}