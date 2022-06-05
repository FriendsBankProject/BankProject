namespace BankMekllat.view
{
    partial class LoanForm
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
            this.Submit_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BankerNationalCode_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DueDate_txt = new System.Windows.Forms.TextBox();
            this.BorrowerNationalCode_txt = new System.Windows.Forms.TextBox();
            this.Amount_txt = new System.Windows.Forms.TextBox();
            this.LoanNumber_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoanGurantorCode_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(285, 325);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(75, 23);
            this.Submit_btn.TabIndex = 4;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LoanGurantorCode_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BankerNationalCode_txt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.DueDate_txt);
            this.groupBox1.Controls.Add(this.BorrowerNationalCode_txt);
            this.groupBox1.Controls.Add(this.Amount_txt);
            this.groupBox1.Controls.Add(this.LoanNumber_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(633, 252);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BankerNationalCode_txt
            // 
            this.BankerNationalCode_txt.Location = new System.Drawing.Point(125, 166);
            this.BankerNationalCode_txt.Margin = new System.Windows.Forms.Padding(2);
            this.BankerNationalCode_txt.Name = "BankerNationalCode_txt";
            this.BankerNationalCode_txt.Size = new System.Drawing.Size(114, 20);
            this.BankerNationalCode_txt.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 169);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Banker national code:";
            // 
            // DueDate_txt
            // 
            this.DueDate_txt.Location = new System.Drawing.Point(365, 64);
            this.DueDate_txt.Margin = new System.Windows.Forms.Padding(2);
            this.DueDate_txt.Multiline = true;
            this.DueDate_txt.Name = "DueDate_txt";
            this.DueDate_txt.Size = new System.Drawing.Size(189, 61);
            this.DueDate_txt.TabIndex = 15;
            // 
            // BorrowerNationalCode_txt
            // 
            this.BorrowerNationalCode_txt.Location = new System.Drawing.Point(138, 80);
            this.BorrowerNationalCode_txt.Margin = new System.Windows.Forms.Padding(2);
            this.BorrowerNationalCode_txt.Name = "BorrowerNationalCode_txt";
            this.BorrowerNationalCode_txt.Size = new System.Drawing.Size(114, 20);
            this.BorrowerNationalCode_txt.TabIndex = 14;
            // 
            // Amount_txt
            // 
            this.Amount_txt.Location = new System.Drawing.Point(371, 27);
            this.Amount_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Amount_txt.Name = "Amount_txt";
            this.Amount_txt.Size = new System.Drawing.Size(114, 20);
            this.Amount_txt.TabIndex = 13;
            // 
            // LoanNumber_txt
            // 
            this.LoanNumber_txt.Location = new System.Drawing.Point(96, 31);
            this.LoanNumber_txt.Margin = new System.Windows.Forms.Padding(2);
            this.LoanNumber_txt.Name = "LoanNumber_txt";
            this.LoanNumber_txt.Size = new System.Drawing.Size(114, 20);
            this.LoanNumber_txt.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DueDate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = " Borrower National Code :";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan number :";
            // 
            // LoanGurantorCode_txt
            // 
            this.LoanGurantorCode_txt.Location = new System.Drawing.Point(437, 166);
            this.LoanGurantorCode_txt.Margin = new System.Windows.Forms.Padding(2);
            this.LoanGurantorCode_txt.Name = "LoanGurantorCode_txt";
            this.LoanGurantorCode_txt.Size = new System.Drawing.Size(114, 20);
            this.LoanGurantorCode_txt.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Loan guarantor national code:";
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 414);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoanForm";
            this.Text = "LoanForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoanForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox BankerNationalCode_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DueDate_txt;
        private System.Windows.Forms.TextBox BorrowerNationalCode_txt;
        private System.Windows.Forms.TextBox Amount_txt;
        private System.Windows.Forms.TextBox LoanNumber_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoanGurantorCode_txt;
        private System.Windows.Forms.Label label2;
    }
}