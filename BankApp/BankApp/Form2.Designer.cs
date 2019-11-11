namespace BankApp
{
    partial class Form2
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
            this.username = new System.Windows.Forms.Label();
            this.new_password = new System.Windows.Forms.Label();
            this.confirm_password = new System.Windows.Forms.Label();
            this.username_text = new System.Windows.Forms.TextBox();
            this.new_pwd_text = new System.Windows.Forms.TextBox();
            this.confirm_pwd_text = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(50, 28);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(53, 13);
            this.username.TabIndex = 0;
            this.username.Text = "username";
            // 
            // new_password
            // 
            this.new_password.AutoSize = true;
            this.new_password.Location = new System.Drawing.Point(50, 77);
            this.new_password.Name = "new_password";
            this.new_password.Size = new System.Drawing.Size(75, 13);
            this.new_password.TabIndex = 1;
            this.new_password.Text = "new password";
            // 
            // confirm_password
            // 
            this.confirm_password.AutoSize = true;
            this.confirm_password.Location = new System.Drawing.Point(50, 130);
            this.confirm_password.Name = "confirm_password";
            this.confirm_password.Size = new System.Drawing.Size(89, 13);
            this.confirm_password.TabIndex = 2;
            this.confirm_password.Text = "confirm password";
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(200, 28);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(100, 20);
            this.username_text.TabIndex = 3;
            this.username_text.TextChanged += new System.EventHandler(this.username_text_TextChanged);
            // 
            // new_pwd_text
            // 
            this.new_pwd_text.Location = new System.Drawing.Point(200, 77);
            this.new_pwd_text.Name = "new_pwd_text";
            this.new_pwd_text.Size = new System.Drawing.Size(100, 20);
            this.new_pwd_text.TabIndex = 4;
            // 
            // confirm_pwd_text
            // 
            this.confirm_pwd_text.Location = new System.Drawing.Point(200, 130);
            this.confirm_pwd_text.Name = "confirm_pwd_text";
            this.confirm_pwd_text.Size = new System.Drawing.Size(100, 20);
            this.confirm_pwd_text.TabIndex = 5;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(121, 179);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 6;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 357);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.confirm_pwd_text);
            this.Controls.Add(this.new_pwd_text);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.confirm_password);
            this.Controls.Add(this.new_password);
            this.Controls.Add(this.username);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label new_password;
        private System.Windows.Forms.Label confirm_password;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.TextBox new_pwd_text;
        private System.Windows.Forms.TextBox confirm_pwd_text;
        private System.Windows.Forms.Button submit;
    }
}