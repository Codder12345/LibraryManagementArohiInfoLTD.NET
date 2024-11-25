namespace WindowsLibraryMnagementproject
{
    partial class Forgotpassword
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtverify = new System.Windows.Forms.TextBox();
            this.sendcode = new System.Windows.Forms.Button();
            this.Resendcode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEmail.Location = new System.Drawing.Point(220, 215);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 26);
            this.txtEmail.TabIndex = 0;
            // 
            // txtverify
            // 
            this.txtverify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtverify.Location = new System.Drawing.Point(273, 314);
            this.txtverify.Name = "txtverify";
            this.txtverify.Size = new System.Drawing.Size(147, 26);
            this.txtverify.TabIndex = 1;
            // 
            // sendcode
            // 
            this.sendcode.BackColor = System.Drawing.Color.OliveDrab;
            this.sendcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendcode.Location = new System.Drawing.Point(323, 258);
            this.sendcode.Name = "sendcode";
            this.sendcode.Size = new System.Drawing.Size(75, 23);
            this.sendcode.TabIndex = 2;
            this.sendcode.Text = "SendOTP";
            this.sendcode.UseVisualStyleBackColor = false;
            this.sendcode.Click += new System.EventHandler(this.sendcode_Click);
            // 
            // Resendcode
            // 
            this.Resendcode.BackColor = System.Drawing.Color.RoyalBlue;
            this.Resendcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Resendcode.Location = new System.Drawing.Point(323, 368);
            this.Resendcode.Name = "Resendcode";
            this.Resendcode.Size = new System.Drawing.Size(75, 23);
            this.Resendcode.TabIndex = 3;
            this.Resendcode.Text = "VerifyOTP";
            this.Resendcode.UseVisualStyleBackColor = false;
            this.Resendcode.Click += new System.EventHandler(this.Resendcode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(102, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "EnterEmail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(124, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter OTP";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 131);
            this.panel1.TabIndex = 6;
            // 
            // Forgotpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Resendcode);
            this.Controls.Add(this.sendcode);
            this.Controls.Add(this.txtverify);
            this.Controls.Add(this.txtEmail);
            this.Name = "Forgotpassword";
            this.Text = "Forhotpassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtverify;
        private System.Windows.Forms.Button sendcode;
        private System.Windows.Forms.Button Resendcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}