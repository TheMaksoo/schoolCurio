namespace RekenMachineUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Input2 = new System.Windows.Forms.TextBox();
            this.Input1 = new System.Windows.Forms.TextBox();
            this.Plus = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.Keer = new System.Windows.Forms.Button();
            this.Delen = new System.Windows.Forms.Button();
            this.eersteGetalText = new System.Windows.Forms.Label();
            this.TweedeGetalText = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Resultaat = new System.Windows.Forms.Label();
            this.ResultaatText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Input2
            // 
            this.Input2.Location = new System.Drawing.Point(51, 138);
            this.Input2.Margin = new System.Windows.Forms.Padding(4);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(158, 22);
            this.Input2.TabIndex = 1;
            // 
            // Input1
            // 
            this.Input1.Location = new System.Drawing.Point(51, 44);
            this.Input1.Margin = new System.Windows.Forms.Padding(4);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(158, 22);
            this.Input1.TabIndex = 0;
            this.Input1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus.Location = new System.Drawing.Point(51, 187);
            this.Plus.Margin = new System.Windows.Forms.Padding(4);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(26, 28);
            this.Plus.TabIndex = 2;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Min
            // 
            this.Min.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min.Location = new System.Drawing.Point(85, 187);
            this.Min.Margin = new System.Windows.Forms.Padding(4);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(26, 28);
            this.Min.TabIndex = 3;
            this.Min.Text = "-";
            this.Min.UseVisualStyleBackColor = true;
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // Keer
            // 
            this.Keer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Keer.Location = new System.Drawing.Point(119, 187);
            this.Keer.Margin = new System.Windows.Forms.Padding(4);
            this.Keer.Name = "Keer";
            this.Keer.Size = new System.Drawing.Size(26, 28);
            this.Keer.TabIndex = 4;
            this.Keer.Text = "x";
            this.Keer.UseVisualStyleBackColor = true;
            this.Keer.Click += new System.EventHandler(this.Keer_Click);
            // 
            // Delen
            // 
            this.Delen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delen.Location = new System.Drawing.Point(153, 187);
            this.Delen.Margin = new System.Windows.Forms.Padding(4);
            this.Delen.Name = "Delen";
            this.Delen.Size = new System.Drawing.Size(26, 28);
            this.Delen.TabIndex = 5;
            this.Delen.Text = "/";
            this.Delen.UseVisualStyleBackColor = true;
            this.Delen.Click += new System.EventHandler(this.Delen_Click);
            // 
            // eersteGetalText
            // 
            this.eersteGetalText.AutoSize = true;
            this.eersteGetalText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eersteGetalText.Location = new System.Drawing.Point(14, 12);
            this.eersteGetalText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eersteGetalText.Name = "eersteGetalText";
            this.eersteGetalText.Size = new System.Drawing.Size(219, 19);
            this.eersteGetalText.TabIndex = 6;
            this.eersteGetalText.Text = "Voer hier het eerste getal in.";
            // 
            // TweedeGetalText
            // 
            this.TweedeGetalText.AutoSize = true;
            this.TweedeGetalText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TweedeGetalText.Location = new System.Drawing.Point(14, 105);
            this.TweedeGetalText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TweedeGetalText.Name = "TweedeGetalText";
            this.TweedeGetalText.Size = new System.Drawing.Size(227, 19);
            this.TweedeGetalText.TabIndex = 7;
            this.TweedeGetalText.Text = "Voer hier het tweede getal in.";
            this.TweedeGetalText.Click += new System.EventHandler(this.label2_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Resultaat
            // 
            this.Resultaat.AutoSize = true;
            this.Resultaat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultaat.Location = new System.Drawing.Point(92, 275);
            this.Resultaat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Resultaat.Name = "Resultaat";
            this.Resultaat.Size = new System.Drawing.Size(81, 19);
            this.Resultaat.TabIndex = 6;
            this.Resultaat.Text = "Resultaat";
            this.Resultaat.Click += new System.EventHandler(this.label3_Click);
            // 
            // ResultaatText
            // 
            this.ResultaatText.AutoSize = true;
            this.ResultaatText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultaatText.Location = new System.Drawing.Point(66, 236);
            this.ResultaatText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultaatText.Name = "ResultaatText";
            this.ResultaatText.Size = new System.Drawing.Size(128, 19);
            this.ResultaatText.TabIndex = 9;
            this.ResultaatText.Text = "Het resultaat is:";
            this.ResultaatText.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 297);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 109);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(187, 187);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "%";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(260, 418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ResultaatText);
            this.Controls.Add(this.Resultaat);
            this.Controls.Add(this.TweedeGetalText);
            this.Controls.Add(this.eersteGetalText);
            this.Controls.Add(this.Delen);
            this.Controls.Add(this.Keer);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Input1);
            this.Controls.Add(this.Input2);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input2;
        private System.Windows.Forms.TextBox Input1;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button Keer;
        private System.Windows.Forms.Button Delen;
        private System.Windows.Forms.Label eersteGetalText;
        private System.Windows.Forms.Label TweedeGetalText;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label Resultaat;
        private System.Windows.Forms.Label ResultaatText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

