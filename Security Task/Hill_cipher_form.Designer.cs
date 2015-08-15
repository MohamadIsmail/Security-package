namespace Security_Task
{
    partial class Hill_cipher_form
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
            this.PlaintextBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.KeytextBox = new System.Windows.Forms.TextBox();
            this.Encrypt = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.EncResultTextBox = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.DecResTextBox = new System.Windows.Forms.TextBox();
            this.Decrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(38, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Enter The plain text";
            // 
            // PlaintextBox
            // 
            this.PlaintextBox.Location = new System.Drawing.Point(12, 98);
            this.PlaintextBox.Multiline = true;
            this.PlaintextBox.Name = "PlaintextBox";
            this.PlaintextBox.Size = new System.Drawing.Size(181, 52);
            this.PlaintextBox.TabIndex = 1;
            this.PlaintextBox.Text = "pay";
            this.PlaintextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(213, 49);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Key\'s matrix dimension";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(236, 98);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(75, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "3";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(362, 49);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Key matrix elements";
            // 
            // KeytextBox
            // 
            this.KeytextBox.Location = new System.Drawing.Point(353, 87);
            this.KeytextBox.Multiline = true;
            this.KeytextBox.Name = "KeytextBox";
            this.KeytextBox.Size = new System.Drawing.Size(118, 44);
            this.KeytextBox.TabIndex = 5;
            this.KeytextBox.Text = "17 17 5 21 18 21 2 2 19";
            this.KeytextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(38, 184);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(103, 23);
            this.Encrypt.TabIndex = 6;
            this.Encrypt.Text = "Encrypt plain text";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(541, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "The encryption result";
            // 
            // EncResultTextBox
            // 
            this.EncResultTextBox.Location = new System.Drawing.Point(508, 171);
            this.EncResultTextBox.Multiline = true;
            this.EncResultTextBox.Name = "EncResultTextBox";
            this.EncResultTextBox.Size = new System.Drawing.Size(162, 52);
            this.EncResultTextBox.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(236, 297);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(113, 20);
            this.textBox6.TabIndex = 10;
            this.textBox6.Text = "The decryption result";
            // 
            // DecResTextBox
            // 
            this.DecResTextBox.Location = new System.Drawing.Point(204, 340);
            this.DecResTextBox.Multiline = true;
            this.DecResTextBox.Name = "DecResTextBox";
            this.DecResTextBox.Size = new System.Drawing.Size(175, 47);
            this.DecResTextBox.TabIndex = 11;
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(508, 247);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(130, 23);
            this.Decrypt.TabIndex = 13;
            this.Decrypt.Text = "Decrypt the enc result";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Hill_cipher_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 414);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.DecResTextBox);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.EncResultTextBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.KeytextBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.PlaintextBox);
            this.Controls.Add(this.textBox1);
            this.Name = "Hill_cipher_form";
            this.Text = "Hill_cipher_form";
            this.Load += new System.EventHandler(this.Hill_cipher_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox PlaintextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox KeytextBox;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox EncResultTextBox;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox DecResTextBox;
        private System.Windows.Forms.Button Decrypt;
    }
}