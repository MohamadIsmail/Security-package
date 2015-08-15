namespace Security_Task
{
    partial class vfr
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
            this.DecResTextBox = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.EncResTextbox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Ceaser_button = new System.Windows.Forms.Button();
            this.PtTextBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Columnar_button = new System.Windows.Forms.Button();
            this.Rail_fence_button = new System.Windows.Forms.Button();
            this.Playfair_button = new System.Windows.Forms.Button();
            this.Repeating_key_button = new System.Windows.Forms.Button();
            this.Autokey_button = new System.Windows.Forms.Button();
            this.Monoalphabetic_button = new System.Windows.Forms.Button();
            this.ceaser_dec_button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Mono_dec_button = new System.Windows.Forms.Button();
            this.AutokeyDecButton = new System.Windows.Forms.Button();
            this.RepeastingKeyButton = new System.Windows.Forms.Button();
            this.RailFenceDecButton = new System.Windows.Forms.Button();
            this.Columnar_Dec_button = new System.Windows.Forms.Button();
            this.PlayFair_dec_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DecResTextBox
            // 
            this.DecResTextBox.Location = new System.Drawing.Point(728, 427);
            this.DecResTextBox.Multiline = true;
            this.DecResTextBox.Name = "DecResTextBox";
            this.DecResTextBox.Size = new System.Drawing.Size(247, 48);
            this.DecResTextBox.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(799, 401);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(110, 20);
            this.textBox7.TabIndex = 18;
            this.textBox7.Text = "Decryption Result";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // EncResTextbox
            // 
            this.EncResTextbox.Location = new System.Drawing.Point(113, 430);
            this.EncResTextbox.Multiline = true;
            this.EncResTextbox.Name = "EncResTextbox";
            this.EncResTextbox.Size = new System.Drawing.Size(247, 45);
            this.EncResTextbox.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(176, 404);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(110, 20);
            this.textBox5.TabIndex = 16;
            this.textBox5.Text = "Encryption Result";
            // 
            // Ceaser_button
            // 
            this.Ceaser_button.Location = new System.Drawing.Point(15, 166);
            this.Ceaser_button.Name = "Ceaser_button";
            this.Ceaser_button.Size = new System.Drawing.Size(148, 44);
            this.Ceaser_button.TabIndex = 15;
            this.Ceaser_button.Text = "General_ceaser";
            this.Ceaser_button.UseVisualStyleBackColor = true;
            this.Ceaser_button.Click += new System.EventHandler(this.Ceaser_button_Click);
            // 
            // PtTextBox
            // 
            this.PtTextBox.Location = new System.Drawing.Point(278, 38);
            this.PtTextBox.Multiline = true;
            this.PtTextBox.Name = "PtTextBox";
            this.PtTextBox.Size = new System.Drawing.Size(214, 58);
            this.PtTextBox.TabIndex = 14;
            this.PtTextBox.Text = "abcxz";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(580, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(83, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "Key";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(509, 38);
            this.KeyTextBox.Multiline = true;
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(219, 58);
            this.KeyTextBox.TabIndex = 12;
            this.KeyTextBox.Text = "bcdefghijklmnopqrstuvwxyza";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(344, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Plain Text";
            // 
            // Columnar_button
            // 
            this.Columnar_button.Location = new System.Drawing.Point(358, 231);
            this.Columnar_button.Name = "Columnar_button";
            this.Columnar_button.Size = new System.Drawing.Size(148, 44);
            this.Columnar_button.TabIndex = 21;
            this.Columnar_button.Text = "Columnar";
            this.Columnar_button.UseVisualStyleBackColor = true;
            this.Columnar_button.Click += new System.EventHandler(this.Columnar_button_Click);
            // 
            // Rail_fence_button
            // 
            this.Rail_fence_button.Location = new System.Drawing.Point(190, 231);
            this.Rail_fence_button.Name = "Rail_fence_button";
            this.Rail_fence_button.Size = new System.Drawing.Size(148, 44);
            this.Rail_fence_button.TabIndex = 22;
            this.Rail_fence_button.Text = "Rail Fence";
            this.Rail_fence_button.UseVisualStyleBackColor = true;
            this.Rail_fence_button.Click += new System.EventHandler(this.Rail_fence_button_Click);
            // 
            // Playfair_button
            // 
            this.Playfair_button.Location = new System.Drawing.Point(190, 310);
            this.Playfair_button.Name = "Playfair_button";
            this.Playfair_button.Size = new System.Drawing.Size(148, 44);
            this.Playfair_button.TabIndex = 23;
            this.Playfair_button.Text = "Playfair";
            this.Playfair_button.UseVisualStyleBackColor = true;
            this.Playfair_button.Click += new System.EventHandler(this.Playfair_button_Click);
            // 
            // Repeating_key_button
            // 
            this.Repeating_key_button.Location = new System.Drawing.Point(15, 231);
            this.Repeating_key_button.Name = "Repeating_key_button";
            this.Repeating_key_button.Size = new System.Drawing.Size(148, 44);
            this.Repeating_key_button.TabIndex = 24;
            this.Repeating_key_button.Text = "Repeating_key vigenere";
            this.Repeating_key_button.UseVisualStyleBackColor = true;
            this.Repeating_key_button.Click += new System.EventHandler(this.Repeating_key_button_Click);
            // 
            // Autokey_button
            // 
            this.Autokey_button.Location = new System.Drawing.Point(358, 166);
            this.Autokey_button.Name = "Autokey_button";
            this.Autokey_button.Size = new System.Drawing.Size(148, 44);
            this.Autokey_button.TabIndex = 25;
            this.Autokey_button.Text = "Autokey vigenere";
            this.Autokey_button.UseVisualStyleBackColor = true;
            this.Autokey_button.Click += new System.EventHandler(this.Autokey_button_Click);
            // 
            // Monoalphabetic_button
            // 
            this.Monoalphabetic_button.Location = new System.Drawing.Point(190, 166);
            this.Monoalphabetic_button.Name = "Monoalphabetic_button";
            this.Monoalphabetic_button.Size = new System.Drawing.Size(148, 44);
            this.Monoalphabetic_button.TabIndex = 26;
            this.Monoalphabetic_button.Text = "Monoalphabetic";
            this.Monoalphabetic_button.UseVisualStyleBackColor = true;
            this.Monoalphabetic_button.Click += new System.EventHandler(this.Monoalphabetic_button_Click);
            // 
            // ceaser_dec_button
            // 
            this.ceaser_dec_button.Location = new System.Drawing.Point(605, 166);
            this.ceaser_dec_button.Name = "ceaser_dec_button";
            this.ceaser_dec_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ceaser_dec_button.Size = new System.Drawing.Size(148, 44);
            this.ceaser_dec_button.TabIndex = 27;
            this.ceaser_dec_button.Text = "General_ceaser";
            this.ceaser_dec_button.UseVisualStyleBackColor = true;
            this.ceaser_dec_button.Click += new System.EventHandler(this.ceaser_dec_button_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(205, 116);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 29);
            this.textBox2.TabIndex = 33;
            this.textBox2.Text = "Encryption Methods";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(770, 116);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(117, 29);
            this.textBox4.TabIndex = 34;
            this.textBox4.Text = "Decryption Methods";
            // 
            // Mono_dec_button
            // 
            this.Mono_dec_button.Location = new System.Drawing.Point(761, 166);
            this.Mono_dec_button.Name = "Mono_dec_button";
            this.Mono_dec_button.Size = new System.Drawing.Size(148, 44);
            this.Mono_dec_button.TabIndex = 35;
            this.Mono_dec_button.Text = "Monoalphabetic";
            this.Mono_dec_button.UseVisualStyleBackColor = true;
            this.Mono_dec_button.Click += new System.EventHandler(this.Mono_dec_button_Click);
            // 
            // AutokeyDecButton
            // 
            this.AutokeyDecButton.Location = new System.Drawing.Point(913, 166);
            this.AutokeyDecButton.Name = "AutokeyDecButton";
            this.AutokeyDecButton.Size = new System.Drawing.Size(148, 44);
            this.AutokeyDecButton.TabIndex = 36;
            this.AutokeyDecButton.Text = "Autokey vigenere";
            this.AutokeyDecButton.UseVisualStyleBackColor = true;
            this.AutokeyDecButton.Click += new System.EventHandler(this.AutokeyDecButton_Click);
            // 
            // RepeastingKeyButton
            // 
            this.RepeastingKeyButton.Location = new System.Drawing.Point(605, 231);
            this.RepeastingKeyButton.Name = "RepeastingKeyButton";
            this.RepeastingKeyButton.Size = new System.Drawing.Size(148, 44);
            this.RepeastingKeyButton.TabIndex = 37;
            this.RepeastingKeyButton.Text = "Repeating_key vigenere";
            this.RepeastingKeyButton.UseVisualStyleBackColor = true;
            this.RepeastingKeyButton.Click += new System.EventHandler(this.RepeastingKeyButton_Click);
            // 
            // RailFenceDecButton
            // 
            this.RailFenceDecButton.Location = new System.Drawing.Point(759, 231);
            this.RailFenceDecButton.Name = "RailFenceDecButton";
            this.RailFenceDecButton.Size = new System.Drawing.Size(148, 44);
            this.RailFenceDecButton.TabIndex = 38;
            this.RailFenceDecButton.Text = "Rail Fence";
            this.RailFenceDecButton.UseVisualStyleBackColor = true;
            this.RailFenceDecButton.Click += new System.EventHandler(this.RailFenceDecButton_Click);
            // 
            // Columnar_Dec_button
            // 
            this.Columnar_Dec_button.Location = new System.Drawing.Point(913, 231);
            this.Columnar_Dec_button.Name = "Columnar_Dec_button";
            this.Columnar_Dec_button.Size = new System.Drawing.Size(148, 44);
            this.Columnar_Dec_button.TabIndex = 39;
            this.Columnar_Dec_button.Text = "Columnar";
            this.Columnar_Dec_button.UseVisualStyleBackColor = true;
            this.Columnar_Dec_button.Click += new System.EventHandler(this.Columnar_Dec_button_Click);
            // 
            // PlayFair_dec_button
            // 
            this.PlayFair_dec_button.Location = new System.Drawing.Point(759, 310);
            this.PlayFair_dec_button.Name = "PlayFair_dec_button";
            this.PlayFair_dec_button.Size = new System.Drawing.Size(148, 44);
            this.PlayFair_dec_button.TabIndex = 40;
            this.PlayFair_dec_button.Text = "Playfair";
            this.PlayFair_dec_button.UseVisualStyleBackColor = true;
            this.PlayFair_dec_button.Click += new System.EventHandler(this.PlayFair_dec_button_Click);
            // 
            // vfr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 515);
            this.Controls.Add(this.PlayFair_dec_button);
            this.Controls.Add(this.Columnar_Dec_button);
            this.Controls.Add(this.RailFenceDecButton);
            this.Controls.Add(this.RepeastingKeyButton);
            this.Controls.Add(this.AutokeyDecButton);
            this.Controls.Add(this.Mono_dec_button);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ceaser_dec_button);
            this.Controls.Add(this.Monoalphabetic_button);
            this.Controls.Add(this.Autokey_button);
            this.Controls.Add(this.Repeating_key_button);
            this.Controls.Add(this.Playfair_button);
            this.Controls.Add(this.Rail_fence_button);
            this.Controls.Add(this.Columnar_button);
            this.Controls.Add(this.DecResTextBox);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.EncResTextbox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Ceaser_button);
            this.Controls.Add(this.PtTextBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.textBox1);
            this.Name = "vfr";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.vfr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DecResTextBox;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox EncResTextbox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button Ceaser_button;
        private System.Windows.Forms.TextBox PtTextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Columnar_button;
        private System.Windows.Forms.Button Rail_fence_button;
        private System.Windows.Forms.Button Playfair_button;
        private System.Windows.Forms.Button Repeating_key_button;
        private System.Windows.Forms.Button Autokey_button;
        private System.Windows.Forms.Button Monoalphabetic_button;
        private System.Windows.Forms.Button ceaser_dec_button;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Mono_dec_button;
        private System.Windows.Forms.Button AutokeyDecButton;
        private System.Windows.Forms.Button RepeastingKeyButton;
        private System.Windows.Forms.Button RailFenceDecButton;
        private System.Windows.Forms.Button Columnar_Dec_button;
        private System.Windows.Forms.Button PlayFair_dec_button;
    }
}