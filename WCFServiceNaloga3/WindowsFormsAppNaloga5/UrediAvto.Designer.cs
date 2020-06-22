namespace WindowsFormsAppNaloga5
{
    partial class UrediAvto
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
            this.UrediZnamkoPolje = new System.Windows.Forms.TextBox();
            this.UrediModelPolje = new System.Windows.Forms.TextBox();
            this.UrediZnamko = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShraniSpremembe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UrediCenoPolje = new System.Windows.Forms.TextBox();
            this.Prikaz_Avtov = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // UrediZnamkoPolje
            // 
            this.UrediZnamkoPolje.Location = new System.Drawing.Point(34, 34);
            this.UrediZnamkoPolje.Name = "UrediZnamkoPolje";
            this.UrediZnamkoPolje.Size = new System.Drawing.Size(133, 20);
            this.UrediZnamkoPolje.TabIndex = 0;
            // 
            // UrediModelPolje
            // 
            this.UrediModelPolje.Location = new System.Drawing.Point(34, 73);
            this.UrediModelPolje.Name = "UrediModelPolje";
            this.UrediModelPolje.Size = new System.Drawing.Size(133, 20);
            this.UrediModelPolje.TabIndex = 1;
            // 
            // UrediZnamko
            // 
            this.UrediZnamko.AutoSize = true;
            this.UrediZnamko.Location = new System.Drawing.Point(31, 21);
            this.UrediZnamko.Name = "UrediZnamko";
            this.UrediZnamko.Size = new System.Drawing.Size(49, 13);
            this.UrediZnamko.TabIndex = 2;
            this.UrediZnamko.Text = "Znamka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model:";
            // 
            // ShraniSpremembe
            // 
            this.ShraniSpremembe.Location = new System.Drawing.Point(34, 171);
            this.ShraniSpremembe.Name = "ShraniSpremembe";
            this.ShraniSpremembe.Size = new System.Drawing.Size(133, 23);
            this.ShraniSpremembe.TabIndex = 5;
            this.ShraniSpremembe.Text = "Shrani spremembe";
            this.ShraniSpremembe.UseVisualStyleBackColor = true;
            this.ShraniSpremembe.Click += new System.EventHandler(this.ShraniSpremembe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cena";
            // 
            // UrediCenoPolje
            // 
            this.UrediCenoPolje.Location = new System.Drawing.Point(34, 122);
            this.UrediCenoPolje.Name = "UrediCenoPolje";
            this.UrediCenoPolje.Size = new System.Drawing.Size(133, 20);
            this.UrediCenoPolje.TabIndex = 7;
            // 
            // Prikaz_Avtov
            // 
            this.Prikaz_Avtov.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.Prikaz_Avtov.FullRowSelect = true;
            this.Prikaz_Avtov.GridLines = true;
            this.Prikaz_Avtov.HideSelection = false;
            this.Prikaz_Avtov.Location = new System.Drawing.Point(224, 34);
            this.Prikaz_Avtov.Name = "Prikaz_Avtov";
            this.Prikaz_Avtov.Size = new System.Drawing.Size(544, 160);
            this.Prikaz_Avtov.TabIndex = 8;
            this.Prikaz_Avtov.UseCompatibleStateImageBehavior = false;
            this.Prikaz_Avtov.View = System.Windows.Forms.View.Details;
            this.Prikaz_Avtov.Click += new System.EventHandler(this.Prikaz_Avtov_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Znamka";
            this.columnHeader2.Width = 124;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Model";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cena";
            this.columnHeader4.Width = 149;
            // 
            // UrediAvto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 227);
            this.Controls.Add(this.Prikaz_Avtov);
            this.Controls.Add(this.UrediCenoPolje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShraniSpremembe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UrediZnamko);
            this.Controls.Add(this.UrediModelPolje);
            this.Controls.Add(this.UrediZnamkoPolje);
            this.Name = "UrediAvto";
            this.Text = "UrediAvto";
            this.Load += new System.EventHandler(this.UrediAvto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UrediZnamkoPolje;
        private System.Windows.Forms.TextBox UrediModelPolje;
        private System.Windows.Forms.Label UrediZnamko;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ShraniSpremembe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UrediCenoPolje;
        private System.Windows.Forms.ListView Prikaz_Avtov;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}