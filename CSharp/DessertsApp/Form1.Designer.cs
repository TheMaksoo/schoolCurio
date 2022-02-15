namespace DessertsApp
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
            this.dgvIjsjes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.naamInput = new System.Windows.Forms.TextBox();
            this.ijssoortInput = new System.Windows.Forms.TextBox();
            this.ingredient_1Input = new System.Windows.Forms.TextBox();
            this.ingredient_2Input = new System.Windows.Forms.TextBox();
            this.addIcecream = new System.Windows.Forms.Button();
            this.errorMsg = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.NumericUpDown();
            this.remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIjsjes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIjsjes
            // 
            this.dgvIjsjes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIjsjes.Location = new System.Drawing.Point(23, 13);
            this.dgvIjsjes.Name = "dgvIjsjes";
            this.dgvIjsjes.Size = new System.Drawing.Size(389, 272);
            this.dgvIjsjes.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Voeg een nieuw ijsje toe!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Naam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ijssoort";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(701, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ingrediënt 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(835, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ingrediënt 2";
            // 
            // naamInput
            // 
            this.naamInput.Location = new System.Drawing.Point(434, 95);
            this.naamInput.Name = "naamInput";
            this.naamInput.Size = new System.Drawing.Size(100, 20);
            this.naamInput.TabIndex = 6;
            // 
            // ijssoortInput
            // 
            this.ijssoortInput.Location = new System.Drawing.Point(555, 95);
            this.ijssoortInput.Name = "ijssoortInput";
            this.ijssoortInput.Size = new System.Drawing.Size(100, 20);
            this.ijssoortInput.TabIndex = 7;
            // 
            // ingredient_1Input
            // 
            this.ingredient_1Input.Location = new System.Drawing.Point(679, 95);
            this.ingredient_1Input.Name = "ingredient_1Input";
            this.ingredient_1Input.Size = new System.Drawing.Size(100, 20);
            this.ingredient_1Input.TabIndex = 8;
            // 
            // ingredient_2Input
            // 
            this.ingredient_2Input.Location = new System.Drawing.Point(815, 95);
            this.ingredient_2Input.Name = "ingredient_2Input";
            this.ingredient_2Input.Size = new System.Drawing.Size(100, 20);
            this.ingredient_2Input.TabIndex = 9;
            // 
            // addIcecream
            // 
            this.addIcecream.Location = new System.Drawing.Point(442, 143);
            this.addIcecream.Name = "addIcecream";
            this.addIcecream.Size = new System.Drawing.Size(75, 23);
            this.addIcecream.TabIndex = 10;
            this.addIcecream.Text = "Voeg toe ";
            this.addIcecream.UseVisualStyleBackColor = true;
            this.addIcecream.Click += new System.EventHandler(this.addIcecream_Click);
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.Location = new System.Drawing.Point(439, 43);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(0, 13);
            this.errorMsg.TabIndex = 11;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(555, 189);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(39, 20);
            this.number.TabIndex = 12;
            this.number.ValueChanged += new System.EventHandler(this.number_ValueChanged);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(434, 186);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(100, 23);
            this.remove.TabIndex = 13;
            this.remove.Text = "Remove number";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(996, 333);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.number);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.addIcecream);
            this.Controls.Add(this.ingredient_2Input);
            this.Controls.Add(this.ingredient_1Input);
            this.Controls.Add(this.ijssoortInput);
            this.Controls.Add(this.naamInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvIjsjes);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIjsjes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        

        private System.Windows.Forms.DataGridView dgvIjsjes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox naamInput;
        private System.Windows.Forms.TextBox ijssoortInput;
        private System.Windows.Forms.TextBox ingredient_1Input;
        private System.Windows.Forms.TextBox ingredient_2Input;
        private System.Windows.Forms.Button addIcecream;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.Button remove;
    }
}

