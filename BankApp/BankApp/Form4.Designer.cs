namespace BankApp
{
    partial class Form4
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
            this.beneficiary = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.benefText = new System.Windows.Forms.TextBox();
            this.amountText = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // beneficiary
            // 
            this.beneficiary.AutoSize = true;
            this.beneficiary.Location = new System.Drawing.Point(180, 63);
            this.beneficiary.Name = "beneficiary";
            this.beneficiary.Size = new System.Drawing.Size(58, 13);
            this.beneficiary.TabIndex = 0;
            this.beneficiary.Text = "beneficiary";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(180, 128);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(42, 13);
            this.amount.TabIndex = 1;
            this.amount.Text = "amount";
            // 
            // benefText
            // 
            this.benefText.Location = new System.Drawing.Point(293, 63);
            this.benefText.Name = "benefText";
            this.benefText.Size = new System.Drawing.Size(146, 20);
            this.benefText.TabIndex = 2;
            // 
            // amountText
            // 
            this.amountText.Location = new System.Drawing.Point(293, 125);
            this.amountText.Name = "amountText";
            this.amountText.Size = new System.Drawing.Size(146, 20);
            this.amountText.TabIndex = 3;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(273, 195);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 4;
            this.send.Text = "send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 388);
            this.Controls.Add(this.send);
            this.Controls.Add(this.amountText);
            this.Controls.Add(this.benefText);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.beneficiary);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label beneficiary;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.TextBox benefText;
        private System.Windows.Forms.TextBox amountText;
        private System.Windows.Forms.Button send;
    }
}