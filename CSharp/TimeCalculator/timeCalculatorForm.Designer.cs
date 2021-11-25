namespace TimeCalculator
{
    partial class timeCalculatorForm
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
            this.input = new System.Windows.Forms.DateTimePicker();
            this.btnJaar = new System.Windows.Forms.Button();
            this.btnLeeftijd = new System.Windows.Forms.Button();
            this.btnSchrikkeljaar = new System.Windows.Forms.Button();
            this.btnWeek = new System.Windows.Forms.Button();
            this.btnWeeknummer = new System.Windows.Forms.Button();
            this.btnDagenTotDatum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(306, 12);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(200, 20);
            this.input.TabIndex = 0;
            // 
            // btnJaar
            // 
            this.btnJaar.Location = new System.Drawing.Point(306, 49);
            this.btnJaar.Name = "btnJaar";
            this.btnJaar.Size = new System.Drawing.Size(200, 23);
            this.btnJaar.TabIndex = 1;
            this.btnJaar.Text = "Bereken Jaartal.";
            this.btnJaar.UseVisualStyleBackColor = true;
            this.btnJaar.Click += new System.EventHandler(this.btnJaar_Click);
            // 
            // btnLeeftijd
            // 
            this.btnLeeftijd.Location = new System.Drawing.Point(306, 90);
            this.btnLeeftijd.Name = "btnLeeftijd";
            this.btnLeeftijd.Size = new System.Drawing.Size(200, 23);
            this.btnLeeftijd.TabIndex = 2;
            this.btnLeeftijd.Text = "Bereken Leeftijd.";
            this.btnLeeftijd.UseVisualStyleBackColor = true;
            this.btnLeeftijd.Click += new System.EventHandler(this.btnLeeftijd_Click);
            // 
            // btnSchrikkeljaar
            // 
            this.btnSchrikkeljaar.Location = new System.Drawing.Point(306, 133);
            this.btnSchrikkeljaar.Name = "btnSchrikkeljaar";
            this.btnSchrikkeljaar.Size = new System.Drawing.Size(200, 23);
            this.btnSchrikkeljaar.TabIndex = 3;
            this.btnSchrikkeljaar.Text = "Bereken Schrikkeljaar.";
            this.btnSchrikkeljaar.UseVisualStyleBackColor = true;
            this.btnSchrikkeljaar.Click += new System.EventHandler(this.btnSchrikkeljaar_Click);
            // 
            // btnWeek
            // 
            this.btnWeek.Location = new System.Drawing.Point(306, 176);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(200, 23);
            this.btnWeek.TabIndex = 4;
            this.btnWeek.Text = "Bereken Dag van de week.";
            this.btnWeek.UseVisualStyleBackColor = true;
            this.btnWeek.Click += new System.EventHandler(this.btnWeek_Click);
            // 
            // btnWeeknummer
            // 
            this.btnWeeknummer.Location = new System.Drawing.Point(306, 219);
            this.btnWeeknummer.Name = "btnWeeknummer";
            this.btnWeeknummer.Size = new System.Drawing.Size(200, 23);
            this.btnWeeknummer.TabIndex = 5;
            this.btnWeeknummer.Text = "Bereken Weeknummer";
            this.btnWeeknummer.UseVisualStyleBackColor = true;
            this.btnWeeknummer.Click += new System.EventHandler(this.btnWeeknummer_Click);
            // 
            // btnDagenTotDatum
            // 
            this.btnDagenTotDatum.Location = new System.Drawing.Point(306, 259);
            this.btnDagenTotDatum.Name = "btnDagenTotDatum";
            this.btnDagenTotDatum.Size = new System.Drawing.Size(200, 23);
            this.btnDagenTotDatum.TabIndex = 6;
            this.btnDagenTotDatum.Text = "Bereken Dagen tot datum.";
            this.btnDagenTotDatum.UseVisualStyleBackColor = true;
            this.btnDagenTotDatum.Click += new System.EventHandler(this.btnDagenTotDatum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Resultaat:";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(369, 329);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(43, 13);
            this.result.TabIndex = 8;
            this.result.Text = "............";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDagenTotDatum);
            this.Controls.Add(this.btnWeeknummer);
            this.Controls.Add(this.btnWeek);
            this.Controls.Add(this.btnSchrikkeljaar);
            this.Controls.Add(this.btnLeeftijd);
            this.Controls.Add(this.btnJaar);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker input;
        private System.Windows.Forms.Button btnJaar;
        private System.Windows.Forms.Button btnLeeftijd;
        private System.Windows.Forms.Button btnSchrikkeljaar;
        private System.Windows.Forms.Button btnWeek;
        private System.Windows.Forms.Button btnWeeknummer;
        private System.Windows.Forms.Button btnDagenTotDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label result;
    }
}

