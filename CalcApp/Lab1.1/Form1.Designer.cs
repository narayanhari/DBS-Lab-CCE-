namespace Lab1._1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.op1 = new System.Windows.Forms.Label();
            this.opr = new System.Windows.Forms.Label();
            this.op2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ans = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(389, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(239, 148);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // op1
            // 
            this.op1.AutoSize = true;
            this.op1.Location = new System.Drawing.Point(110, 120);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(25, 13);
            this.op1.TabIndex = 3;
            this.op1.Text = "op1";
            this.op1.Click += new System.EventHandler(this.label1_Click);
            // 
            // opr
            // 
            this.opr.AutoSize = true;
            this.opr.Location = new System.Drawing.Point(272, 120);
            this.opr.Name = "opr";
            this.opr.Size = new System.Drawing.Size(22, 13);
            this.opr.TabIndex = 4;
            this.opr.Text = "opr";
            this.opr.Click += new System.EventHandler(this.label2_Click);
            // 
            // op2
            // 
            this.op2.AutoSize = true;
            this.op2.Location = new System.Drawing.Point(411, 120);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(25, 13);
            this.op2.TabIndex = 5;
            this.op2.Text = "op2";
            this.op2.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(537, 148);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 6;
            // 
            // ans
            // 
            this.ans.AutoSize = true;
            this.ans.Location = new System.Drawing.Point(560, 120);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(24, 13);
            this.ans.TabIndex = 7;
            this.ans.Text = "ans";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(324, 194);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 8;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 418);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.op2);
            this.Controls.Add(this.opr);
            this.Controls.Add(this.op1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label op1;
        private System.Windows.Forms.Label opr;
        private System.Windows.Forms.Label op2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label ans;
        private System.Windows.Forms.Button submit;
    }
}

