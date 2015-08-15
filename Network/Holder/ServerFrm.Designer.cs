namespace HelloNetworks
{
    partial class ServerFrm
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
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.tb_msg = new System.Windows.Forms.TextBox();
            this.btn_accept = new System.Windows.Forms.Button();
            this.RSA_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PTtextBox = new System.Windows.Forms.TextBox();
            this.QTextBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.PTextBox = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.AESPTexBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.AES_button = new System.Windows.Forms.Button();
            this.MD5Text = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.MD5_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(22, 12);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(244, 53);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start Server";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(131, 178);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(135, 59);
            this.btn_Send.TabIndex = 1;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // tb_msg
            // 
            this.tb_msg.Location = new System.Drawing.Point(22, 79);
            this.tb_msg.Multiline = true;
            this.tb_msg.Name = "tb_msg";
            this.tb_msg.Size = new System.Drawing.Size(244, 93);
            this.tb_msg.TabIndex = 2;
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(22, 178);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(103, 59);
            this.btn_accept.TabIndex = 3;
            this.btn_accept.Text = "Accept Connection";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // RSA_button
            // 
            this.RSA_button.Location = new System.Drawing.Point(831, 92);
            this.RSA_button.Name = "RSA_button";
            this.RSA_button.Size = new System.Drawing.Size(127, 47);
            this.RSA_button.TabIndex = 4;
            this.RSA_button.Text = "Encrypt using RSA";
            this.RSA_button.UseVisualStyleBackColor = true;
            this.RSA_button.Click += new System.EventHandler(this.RSA_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(693, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Decryption Result";
            // 
            // PTtextBox
            // 
            this.PTtextBox.Location = new System.Drawing.Point(642, 38);
            this.PTtextBox.Multiline = true;
            this.PTtextBox.Name = "PTtextBox";
            this.PTtextBox.Size = new System.Drawing.Size(183, 34);
            this.PTtextBox.TabIndex = 9;
            this.PTtextBox.Text = "88";
            // 
            // QTextBox
            // 
            this.QTextBox.Location = new System.Drawing.Point(831, 38);
            this.QTextBox.Multiline = true;
            this.QTextBox.Name = "QTextBox";
            this.QTextBox.Size = new System.Drawing.Size(78, 20);
            this.QTextBox.TabIndex = 10;
            this.QTextBox.Text = "11";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(831, 12);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(78, 20);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "Enter Q";
            // 
            // PTextBox
            // 
            this.PTextBox.Location = new System.Drawing.Point(927, 38);
            this.PTextBox.Multiline = true;
            this.PTextBox.Name = "PTextBox";
            this.PTextBox.Size = new System.Drawing.Size(84, 20);
            this.PTextBox.TabIndex = 12;
            this.PTextBox.Text = "17";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(927, 12);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(84, 20);
            this.textBox6.TabIndex = 13;
            this.textBox6.Text = "Enter P";
            // 
            // AESPTexBox
            // 
            this.AESPTexBox.Location = new System.Drawing.Point(583, 248);
            this.AESPTexBox.Multiline = true;
            this.AESPTexBox.Name = "AESPTexBox";
            this.AESPTexBox.Size = new System.Drawing.Size(214, 58);
            this.AESPTexBox.TabIndex = 35;
            this.AESPTexBox.Text = "0123456789ABCDEFFEDCBA9876543210";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(897, 217);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(83, 20);
            this.textBox3.TabIndex = 34;
            this.textBox3.Text = "Key";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(803, 248);
            this.KeyTextBox.Multiline = true;
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(219, 58);
            this.KeyTextBox.TabIndex = 33;
            this.KeyTextBox.Text = "FEDCBA9876543210FEDCBA9876543210";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(666, 222);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(83, 20);
            this.textBox5.TabIndex = 32;
            this.textBox5.Text = "Plain Text";
            // 
            // AES_button
            // 
            this.AES_button.Location = new System.Drawing.Point(682, 338);
            this.AES_button.Name = "AES_button";
            this.AES_button.Size = new System.Drawing.Size(127, 47);
            this.AES_button.TabIndex = 31;
            this.AES_button.Text = "Encrypt using AES";
            this.AES_button.UseVisualStyleBackColor = true;
            this.AES_button.Click += new System.EventHandler(this.AES_button_Click);
            // 
            // MD5Text
            // 
            this.MD5Text.Location = new System.Drawing.Point(337, 127);
            this.MD5Text.Multiline = true;
            this.MD5Text.Name = "MD5Text";
            this.MD5Text.Size = new System.Drawing.Size(188, 45);
            this.MD5Text.TabIndex = 38;
            this.MD5Text.Text = "The quick brown fox jumps over the lazy dog";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(382, 92);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 37;
            this.textBox2.Text = "The Text";
            // 
            // MD5_button
            // 
            this.MD5_button.Location = new System.Drawing.Point(364, 184);
            this.MD5_button.Name = "MD5_button";
            this.MD5_button.Size = new System.Drawing.Size(127, 47);
            this.MD5_button.TabIndex = 36;
            this.MD5_button.Text = "Encrypt using MD5";
            this.MD5_button.UseVisualStyleBackColor = true;
            this.MD5_button.Click += new System.EventHandler(this.MD5_button_Click);
            // 
            // ServerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 440);
            this.Controls.Add(this.MD5Text);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.MD5_button);
            this.Controls.Add(this.AESPTexBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.AES_button);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.PTextBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.QTextBox);
            this.Controls.Add(this.PTtextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RSA_button);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.tb_msg);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.btn_Start);
            this.Name = "ServerFrm";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServerFrm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox tb_msg;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Button RSA_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox PTtextBox;
        private System.Windows.Forms.TextBox QTextBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox PTextBox;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox AESPTexBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button AES_button;
        private System.Windows.Forms.TextBox MD5Text;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button MD5_button;
    }
}

