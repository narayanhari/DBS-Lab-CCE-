namespace BankApp
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
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.user_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.change_password = new System.Windows.Forms.Button();
            this.Bank = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(141, 112);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(53, 13);
            this.username.TabIndex = 0;
            this.username.Text = "username";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(141, 158);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(52, 13);
            this.password.TabIndex = 1;
            this.password.Text = "password";
            // 
            // user_text
            // 
            this.user_text.Location = new System.Drawing.Point(257, 105);
            this.user_text.Name = "user_text";
            this.user_text.Size = new System.Drawing.Size(100, 20);
            this.user_text.TabIndex = 2;
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(257, 151);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(100, 20);
            this.password_text.TabIndex = 3;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(210, 202);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 5;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // change_password
            // 
            this.change_password.Location = new System.Drawing.Point(144, 231);
            this.change_password.Name = "change_password";
            this.change_password.Size = new System.Drawing.Size(213, 23);
            this.change_password.TabIndex = 6;
            this.change_password.Text = "change password";
            this.change_password.UseVisualStyleBackColor = true;
            this.change_password.Click += new System.EventHandler(this.change_password_Click);
            // 
            // Bank
            // 
            this.Bank.AutoSize = true;
            this.Bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bank.Location = new System.Drawing.Point(156, 9);
            this.Bank.Name = "Bank";
            this.Bank.Size = new System.Drawing.Size(183, 73);
            this.Bank.TabIndex = 7;
            this.Bank.Text = "Bank";
            this.Bank.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 382);
            this.Controls.Add(this.Bank);
            this.Controls.Add(this.change_password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.user_text);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "Form1";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox user_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button change_password;
        private System.Windows.Forms.Label Bank;
    }
}