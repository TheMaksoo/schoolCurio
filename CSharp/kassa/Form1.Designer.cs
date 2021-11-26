namespace kassa
{
    partial class Form1
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
            this.tosti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prijs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tosti
            // 
            this.tosti.Location = new System.Drawing.Point(194, 25);
            this.tosti.Name = "tosti";
            this.tosti.Size = new System.Drawing.Size(100, 20);
            this.tosti.TabIndex = 5;
            this.tosti.TextChanged += new System.EventHandler(this.tosti_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Voor een item in.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 78);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product Prijs\r\ntosti 6,50\r\nuitsmijter 7,95\r\nkoffie 2,25\r\nmelk 2,00\r\nfrisdrank 2,5" +
    "0";
            // 
            // prijs
            // 
            this.prijs.AutoSize = true;
            this.prijs.Location = new System.Drawing.Point(191, 48);
            this.prijs.Name = "prijs";
            this.prijs.Size = new System.Drawing.Size(50, 13);
            this.prijs.TabIndex = 8;
            this.prijs.Text = "Prijs: ....€";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prijs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tosti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tosti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label prijs;
    }
}

