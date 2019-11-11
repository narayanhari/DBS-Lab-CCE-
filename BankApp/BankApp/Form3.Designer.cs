namespace BankApp
{
    partial class Form3
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
            this.Details = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.last_access = new System.Windows.Forms.Label();
            this.transactions = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.balanceText = new System.Windows.Forms.TextBox();
            this.last_accessText = new System.Windows.Forms.TextBox();
            this.transactionsText = new System.Windows.Forms.TextBox();
            this.transact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Details
            // 
            this.Details.AutoSize = true;
            this.Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Details.Location = new System.Drawing.Point(205, 9);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(228, 73);
            this.Details.TabIndex = 0;
            this.Details.Text = "Details";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(131, 121);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(53, 13);
            this.username.TabIndex = 1;
            this.username.Text = "useranme";
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Location = new System.Drawing.Point(131, 153);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(45, 13);
            this.balance.TabIndex = 2;
            this.balance.Text = "balance";
            // 
            // last_access
            // 
            this.last_access.AutoSize = true;
            this.last_access.Location = new System.Drawing.Point(131, 183);
            this.last_access.Name = "last_access";
            this.last_access.Size = new System.Drawing.Size(63, 13);
            this.last_access.TabIndex = 3;
            this.last_access.Text = "last_access";
            // 
            // transactions
            // 
            this.transactions.AutoSize = true;
            this.transactions.Location = new System.Drawing.Point(134, 214);
            this.transactions.Name = "transactions";
            this.transactions.Size = new System.Drawing.Size(64, 13);
            this.transactions.TabIndex = 4;
            this.transactions.Text = "transactions";
            this.transactions.Click += new System.EventHandler(this.label1_Click);
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(286, 118);
            this.usernameText.Name = "usernameText";
            this.usernameText.ReadOnly = true;
            this.usernameText.Size = new System.Drawing.Size(252, 20);
            this.usernameText.TabIndex = 5;
            // 
            // balanceText
            // 
            this.balanceText.Location = new System.Drawing.Point(286, 150);
            this.balanceText.Name = "balanceText";
            this.balanceText.ReadOnly = true;
            this.balanceText.Size = new System.Drawing.Size(252, 20);
            this.balanceText.TabIndex = 6;
            // 
            // last_accessText
            // 
            this.last_accessText.Location = new System.Drawing.Point(286, 180);
            this.last_accessText.Name = "last_accessText";
            this.last_accessText.ReadOnly = true;
            this.last_accessText.Size = new System.Drawing.Size(252, 20);
            this.last_accessText.TabIndex = 7;
            // 
            // transactionsText
            // 
            this.transactionsText.AcceptsReturn = true;
            this.transactionsText.AcceptsTab = true;
            this.transactionsText.AllowDrop = true;
            this.transactionsText.Location = new System.Drawing.Point(286, 207);
            this.transactionsText.Multiline = true;
            this.transactionsText.Name = "transactionsText";
            this.transactionsText.ReadOnly = true;
            this.transactionsText.Size = new System.Drawing.Size(252, 102);
            this.transactionsText.TabIndex = 8;
            // 
            // transact
            // 
            this.transact.Location = new System.Drawing.Point(252, 332);
            this.transact.Name = "transact";
            this.transact.Size = new System.Drawing.Size(75, 23);
            this.transact.TabIndex = 9;
            this.transact.Text = "Transact";
            this.transact.UseVisualStyleBackColor = true;
            this.transact.Click += new System.EventHandler(this.transact_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 378);
            this.Controls.Add(this.transact);
            this.Controls.Add(this.transactionsText);
            this.Controls.Add(this.last_accessText);
            this.Controls.Add(this.balanceText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.transactions);
            this.Controls.Add(this.last_access);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.username);
            this.Controls.Add(this.Details);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Details;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label last_access;
        private System.Windows.Forms.Label transactions;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox balanceText;
        private System.Windows.Forms.TextBox last_accessText;
        private System.Windows.Forms.TextBox transactionsText;
        private System.Windows.Forms.Button transact;
    }
}