namespace Security_Task
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
            this.Hill_cipher = new System.Windows.Forms.Button();
            this.Others = new System.Windows.Forms.Button();
            this.Mult_inverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Hill_cipher
            // 
            this.Hill_cipher.Location = new System.Drawing.Point(154, 103);
            this.Hill_cipher.Name = "Hill_cipher";
            this.Hill_cipher.Size = new System.Drawing.Size(162, 67);
            this.Hill_cipher.TabIndex = 12;
            this.Hill_cipher.Text = "Hill_cipher";
            this.Hill_cipher.UseVisualStyleBackColor = true;
            this.Hill_cipher.Click += new System.EventHandler(this.Hill_cipher_Click);
            // 
            // Others
            // 
            this.Others.Location = new System.Drawing.Point(419, 107);
            this.Others.Name = "Others";
            this.Others.Size = new System.Drawing.Size(181, 63);
            this.Others.TabIndex = 17;
            this.Others.Text = "Others";
            this.Others.UseVisualStyleBackColor = true;
            this.Others.Click += new System.EventHandler(this.Others_Click);
            // 
            // Mult_inverse
            // 
            this.Mult_inverse.Location = new System.Drawing.Point(276, 213);
            this.Mult_inverse.Name = "Mult_inverse";
            this.Mult_inverse.Size = new System.Drawing.Size(168, 65);
            this.Mult_inverse.TabIndex = 18;
            this.Mult_inverse.Text = "Multiplicative_inverse";
            this.Mult_inverse.UseVisualStyleBackColor = true;
            this.Mult_inverse.Click += new System.EventHandler(this.Mult_inverse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 363);
            this.Controls.Add(this.Mult_inverse);
            this.Controls.Add(this.Others);
            this.Controls.Add(this.Hill_cipher);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Hill_cipher;
        private System.Windows.Forms.Button Others;
        private System.Windows.Forms.Button Mult_inverse;
    }
}

