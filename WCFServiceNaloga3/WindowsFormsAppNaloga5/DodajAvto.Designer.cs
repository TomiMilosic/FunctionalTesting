namespace WindowsFormsAppNaloga5
{
    partial class DodajAvto
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.neke = new System.Windows.Forms.Label();
            this.ZnamkaAvtaPolje = new System.Windows.Forms.TextBox();
            this.ModelAvtaPolje = new System.Windows.Forms.TextBox();
            this.CenaAvtaPolje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj avto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Znamka avta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model:";
            // 
            // neke
            // 
            this.neke.AutoSize = true;
            this.neke.Location = new System.Drawing.Point(72, 182);
            this.neke.Name = "neke";
            this.neke.Size = new System.Drawing.Size(59, 13);
            this.neke.TabIndex = 3;
            this.neke.Text = "Cena avta:";
            // 
            // ZnamkaAvtaPolje
            // 
            this.ZnamkaAvtaPolje.Location = new System.Drawing.Point(75, 78);
            this.ZnamkaAvtaPolje.Name = "ZnamkaAvtaPolje";
            this.ZnamkaAvtaPolje.Size = new System.Drawing.Size(100, 20);
            this.ZnamkaAvtaPolje.TabIndex = 4;
            // 
            // ModelAvtaPolje
            // 
            this.ModelAvtaPolje.Location = new System.Drawing.Point(75, 140);
            this.ModelAvtaPolje.Name = "ModelAvtaPolje";
            this.ModelAvtaPolje.Size = new System.Drawing.Size(100, 20);
            this.ModelAvtaPolje.TabIndex = 5;
            // 
            // CenaAvtaPolje
            // 
            this.CenaAvtaPolje.Location = new System.Drawing.Point(75, 208);
            this.CenaAvtaPolje.Name = "CenaAvtaPolje";
            this.CenaAvtaPolje.Size = new System.Drawing.Size(100, 20);
            this.CenaAvtaPolje.TabIndex = 6;
            // 
            // DodajAvto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 371);
            this.Controls.Add(this.CenaAvtaPolje);
            this.Controls.Add(this.ModelAvtaPolje);
            this.Controls.Add(this.ZnamkaAvtaPolje);
            this.Controls.Add(this.neke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "DodajAvto";
            this.Text = "DodajAvto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label neke;
        private System.Windows.Forms.TextBox ZnamkaAvtaPolje;
        private System.Windows.Forms.TextBox ModelAvtaPolje;
        private System.Windows.Forms.TextBox CenaAvtaPolje;
    }
}