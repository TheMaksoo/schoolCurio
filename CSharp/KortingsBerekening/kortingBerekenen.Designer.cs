namespace KortingsBerekening
{
    partial class kortingBerekenen
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
            this.inputBedrag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.kortingPercentage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kortingEuro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.betalen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputBedrag
            // 
            this.inputBedrag.Location = new System.Drawing.Point(319, 25);
            this.inputBedrag.Name = "inputBedrag";
            this.inputBedrag.Size = new System.Drawing.Size(100, 20);
            this.inputBedrag.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bedrag.";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(319, 61);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(100, 23);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Bereken Korting.";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Korting  percentage.";
            // 
            // kortingPercentage
            // 
            this.kortingPercentage.AutoSize = true;
            this.kortingPercentage.Location = new System.Drawing.Point(348, 129);
            this.kortingPercentage.Name = "kortingPercentage";
            this.kortingPercentage.Size = new System.Drawing.Size(42, 13);
            this.kortingPercentage.TabIndex = 4;
            this.kortingPercentage.Text = "00.00%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Korting  in  euro.";
            // 
            // kortingEuro
            // 
            this.kortingEuro.AutoSize = true;
            this.kortingEuro.Location = new System.Drawing.Point(348, 190);
            this.kortingEuro.Name = "kortingEuro";
            this.kortingEuro.Size = new System.Drawing.Size(40, 13);
            this.kortingEuro.TabIndex = 6;
            this.kortingEuro.Text = "00.00€";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tebetalen.";
            // 
            // betalen
            // 
            this.betalen.AutoSize = true;
            this.betalen.Location = new System.Drawing.Point(348, 255);
            this.betalen.Name = "betalen";
            this.betalen.Size = new System.Drawing.Size(40, 13);
            this.betalen.TabIndex = 8;
            this.betalen.Text = "00.00€";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.betalen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kortingEuro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kortingPercentage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputBedrag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBedrag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label kortingPercentage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label kortingEuro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label betalen;
    }
}

