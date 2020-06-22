namespace WindowsFormsAppNaloga5
{
    partial class DodajAvtosalon
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
            this.NazivAvtoSalonaPolje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DodajAvtoSalonaBTN = new System.Windows.Forms.Button();
            this.KrajAvtosalonaPolje = new System.Windows.Forms.TextBox();
            this.LetoUstanovitvePolje = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NazivAvtoSalonaPolje
            // 
            this.NazivAvtoSalonaPolje.Location = new System.Drawing.Point(15, 36);
            this.NazivAvtoSalonaPolje.Name = "NazivAvtoSalonaPolje";
            this.NazivAvtoSalonaPolje.Size = new System.Drawing.Size(100, 20);
            this.NazivAvtoSalonaPolje.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv avtosalona:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kraj avtosalona:";
            // 
            // DodajAvtoSalonaBTN
            // 
            this.DodajAvtoSalonaBTN.Location = new System.Drawing.Point(12, 212);
            this.DodajAvtoSalonaBTN.Name = "DodajAvtoSalonaBTN";
            this.DodajAvtoSalonaBTN.Size = new System.Drawing.Size(75, 23);
            this.DodajAvtoSalonaBTN.TabIndex = 3;
            this.DodajAvtoSalonaBTN.Text = "Dodaj Avtosalona";
            this.DodajAvtoSalonaBTN.UseVisualStyleBackColor = true;
            this.DodajAvtoSalonaBTN.Click += new System.EventHandler(this.DodajAvtoSalonaBTN_Click);
            // 
            // KrajAvtosalonaPolje
            // 
            this.KrajAvtosalonaPolje.Location = new System.Drawing.Point(15, 106);
            this.KrajAvtosalonaPolje.Name = "KrajAvtosalonaPolje";
            this.KrajAvtosalonaPolje.Size = new System.Drawing.Size(100, 20);
            this.KrajAvtosalonaPolje.TabIndex = 4;
            // 
            // LetoUstanovitvePolje
            // 
            this.LetoUstanovitvePolje.Location = new System.Drawing.Point(15, 170);
            this.LetoUstanovitvePolje.Name = "LetoUstanovitvePolje";
            this.LetoUstanovitvePolje.Size = new System.Drawing.Size(100, 20);
            this.LetoUstanovitvePolje.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Leto ustanovitve:";
            // 
            // DodajAvtosalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(143, 248);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LetoUstanovitvePolje);
            this.Controls.Add(this.KrajAvtosalonaPolje);
            this.Controls.Add(this.DodajAvtoSalonaBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NazivAvtoSalonaPolje);
            this.Name = "DodajAvtosalon";
            this.Text = "DodajAvtosalon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NazivAvtoSalonaPolje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DodajAvtoSalonaBTN;
        private System.Windows.Forms.TextBox KrajAvtosalonaPolje;
        private System.Windows.Forms.TextBox LetoUstanovitvePolje;
        private System.Windows.Forms.Label label3;
    }
}