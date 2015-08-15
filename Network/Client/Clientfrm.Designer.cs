namespace Client
{
    partial class Clientfrm
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
            this.btn_Connect = new System.Windows.Forms.Button();
            this.tb_clientmsg = new System.Windows.Forms.TextBox();
            this.btn_Recieve = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.RSA_button = new System.Windows.Forms.Button();
            this.AES_button = new System.Windows.Forms.Button();
            this.MD5_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PTtextBox = new System.Windows.Forms.TextBox();
            this.QTextBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.PTextBox = new System.Windows.Forms.TextBox();
            this.AESPTextBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.MD5Text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(56, 152);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(87, 74);
            this.btn_Connect.TabIndex = 0;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // tb_clientmsg
            // 
            this.tb_clientmsg.Location = new System.Drawing.Point(56, 35);
            this.tb_clientmsg.Multiline = true;
            this.tb_clientmsg.Name = "tb_clientmsg";
            this.tb_clientmsg.Size = new System.Drawing.Size(193, 111);
            this.tb_clientmsg.TabIndex = 1;
            // 
            // btn_Recieve
            // 
            this.btn_Recieve.Location = new System.Drawing.Point(162, 152);
            this.btn_Recieve.Name = "btn_Recieve";
            this.btn_Recieve.Size = new System.Drawing.Size(87, 74);
            this.btn_Recieve.TabIndex = 2;
            this.btn_Recieve.Text = "Receive";
            this.btn_Recieve.UseVisualStyleBackColor = true;
            this.btn_Recieve.Click += new System.EventHandler(this.btn_Recieve_Click);
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(938, 2);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(84, 20);
            this.textBox6.TabIndex = 26;
            this.textBox6.Text = "Enter P";
            // 
            // RSA_button
            // 
            this.RSA_button.Location = new System.Drawing.Point(833, 82);
            this.RSA_button.Name = "RSA_button";
            this.RSA_button.Size = new System.Drawing.Size(127, 47);
            this.RSA_button.TabIndex = 18;
            this.RSA_button.Text = "Encrypt using RSA";
            this.RSA_button.UseVisualStyleBackColor = true;
            this.RSA_button.Click += new System.EventHandler(this.RSA_button_Click);
            // 
            // AES_button
            // 
            this.AES_button.Location = new System.Drawing.Point(778, 317);
            this.AES_button.Name = "AES_button";
            this.AES_button.Size = new System.Drawing.Size(127, 47);
            this.AES_button.TabIndex = 19;
            this.AES_button.Text = "Encrypt using AES";
            this.AES_button.UseVisualStyleBackColor = true;
            this.AES_button.Click += new System.EventHandler(this.AES_button_Click);
            // 
            // MD5_button
            // 
            this.MD5_button.Location = new System.Drawing.Point(416, 124);
            this.MD5_button.Name = "MD5_button";
            this.MD5_button.Size = new System.Drawing.Size(127, 47);
            this.MD5_button.TabIndex = 20;
            this.MD5_button.Text = "Encrypt using MD5";
            this.MD5_button.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(717, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "Decryption Result";
            // 
            // PTtextBox
            // 
            this.PTtextBox.Location = new System.Drawing.Point(717, 28);
            this.PTtextBox.Multiline = true;
            this.PTtextBox.Name = "PTtextBox";
            this.PTtextBox.Size = new System.Drawing.Size(116, 34);
            this.PTtextBox.TabIndex = 22;
            // 
            // QTextBox
            // 
            this.QTextBox.Location = new System.Drawing.Point(854, 35);
            this.QTextBox.Multiline = true;
            this.QTextBox.Name = "QTextBox";
            this.QTextBox.Size = new System.Drawing.Size(78, 20);
            this.QTextBox.TabIndex = 23;
            this.QTextBox.Text = "11";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(854, 2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(78, 20);
            this.textBox4.TabIndex = 24;
            this.textBox4.Text = "Enter Q";
            // 
            // PTextBox
            // 
            this.PTextBox.Location = new System.Drawing.Point(938, 35);
            this.PTextBox.Multiline = true;
            this.PTextBox.Name = "PTextBox";
            this.PTextBox.Size = new System.Drawing.Size(84, 20);
            this.PTextBox.TabIndex = 25;
            this.PTextBox.Text = "17";
            // 
            // AESPTextBox
            // 
            this.AESPTextBox.Location = new System.Drawing.Point(579, 227);
            this.AESPTextBox.Multiline = true;
            this.AESPTextBox.Name = "AESPTextBox";
            this.AESPTextBox.Size = new System.Drawing.Size(214, 58);
            this.AESPTextBox.TabIndex = 30;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(894, 191);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(83, 20);
            this.textBox3.TabIndex = 29;
            this.textBox3.Text = "Key";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(813, 227);
            this.KeyTextBox.Multiline = true;
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(219, 58);
            this.KeyTextBox.TabIndex = 28;
            this.KeyTextBox.Text = "FEDCBA9876543210FEDCBA9876543210";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(659, 191);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(83, 20);
            this.textBox5.TabIndex = 27;
            this.textBox5.Text = "Plain Text";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(428, 35);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 31;
            this.textBox2.Text = "The Text";
            // 
            // MD5Text
            // 
            this.MD5Text.Location = new System.Drawing.Point(375, 61);
            this.MD5Text.Multiline = true;
            this.MD5Text.Name = "MD5Text";
            this.MD5Text.Size = new System.Drawing.Size(188, 45);
            this.MD5Text.TabIndex = 32;
            // 
            // Clientfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 394);
            this.Controls.Add(this.MD5Text);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.AESPTextBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.PTextBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.QTextBox);
            this.Controls.Add(this.PTtextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MD5_button);
            this.Controls.Add(this.AES_button);
            this.Controls.Add(this.RSA_button);
            this.Controls.Add(this.btn_Recieve);
            this.Controls.Add(this.tb_clientmsg);
            this.Controls.Add(this.btn_Connect);
            this.Name = "Clientfrm";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Clientfrm_FormClosed);
            this.Load += new System.EventHandler(this.Clientfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox tb_clientmsg;
        private System.Windows.Forms.Button btn_Recieve;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button RSA_button;
        private System.Windows.Forms.Button AES_button;
        private System.Windows.Forms.Button MD5_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox PTtextBox;
        private System.Windows.Forms.TextBox QTextBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox PTextBox;
        private System.Windows.Forms.TextBox AESPTextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox MD5Text;
    }
}

