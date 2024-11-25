namespace WindowsLibraryMnagementproject
{
    partial class Resetpassword
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
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.txtverifypass = new System.Windows.Forms.TextBox();
            this.txtReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnewpass
            // 
            this.txtnewpass.Location = new System.Drawing.Point(283, 89);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(226, 20);
            this.txtnewpass.TabIndex = 0;
            // 
            // txtverifypass
            // 
            this.txtverifypass.Location = new System.Drawing.Point(283, 147);
            this.txtverifypass.Name = "txtverifypass";
            this.txtverifypass.Size = new System.Drawing.Size(226, 20);
            this.txtverifypass.TabIndex = 1;
            // 
            // txtReset
            // 
            this.txtReset.BackColor = System.Drawing.Color.Blue;
            this.txtReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtReset.Location = new System.Drawing.Point(209, 230);
            this.txtReset.Name = "txtReset";
            this.txtReset.Size = new System.Drawing.Size(122, 40);
            this.txtReset.TabIndex = 2;
            this.txtReset.Text = "Resetpassword";
            this.txtReset.UseVisualStyleBackColor = false;
            this.txtReset.Click += new System.EventHandler(this.txtReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "NewPassword";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "VerifyNewPassword";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(380, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Resetpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReset);
            this.Controls.Add(this.txtverifypass);
            this.Controls.Add(this.txtnewpass);
            this.Name = "Resetpassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resetpassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.TextBox txtverifypass;
        private System.Windows.Forms.Button txtReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}