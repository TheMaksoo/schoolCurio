namespace TafelsGenerator
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
            this.input = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.wis = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(397, 41);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 20);
            this.input.TabIndex = 0;
            this.input.Text = "5";
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(412, 81);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 1;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // wis
            // 
            this.wis.Location = new System.Drawing.Point(412, 126);
            this.wis.Name = "wis";
            this.wis.Size = new System.Drawing.Size(75, 23);
            this.wis.TabIndex = 2;
            this.wis.Text = "wis";
            this.wis.UseVisualStyleBackColor = true;
            this.wis.Click += new System.EventHandler(this.wis_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(516, 42);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(195, 217);
            this.result.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.wis);
            this.Controls.Add(this.start);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button wis;
        private System.Windows.Forms.TextBox result;
    }
}

