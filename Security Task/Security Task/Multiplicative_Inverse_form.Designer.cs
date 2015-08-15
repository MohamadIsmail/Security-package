namespace Security_Task
{
    partial class Multiplicative_Inverse_form
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BaseTextBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.ResTextBox = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Number";
            // 
            // BaseTextBox
            // 
            this.BaseTextBox.Location = new System.Drawing.Point(259, 109);
            this.BaseTextBox.Name = "BaseTextBox";
            this.BaseTextBox.Size = new System.Drawing.Size(100, 20);
            this.BaseTextBox.TabIndex = 1;
            this.BaseTextBox.Text = "26";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(259, 53);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Base";
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(94, 109);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumberTextBox.TabIndex = 3;
            this.NumberTextBox.Text = "23";
            // 
            // ResTextBox
            // 
            this.ResTextBox.Location = new System.Drawing.Point(601, 109);
            this.ResTextBox.Name = "ResTextBox";
            this.ResTextBox.Size = new System.Drawing.Size(100, 20);
            this.ResTextBox.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(601, 53);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Result";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Get result";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Multiplicative_Inverse_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.ResTextBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.BaseTextBox);
            this.Controls.Add(this.textBox1);
            this.Name = "Multiplicative_Inverse_form";
            this.Text = "Multiplicative_Inverse_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox BaseTextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.TextBox ResTextBox;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
    }
}