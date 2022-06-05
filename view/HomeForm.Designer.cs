namespace BankMekllat.view
{
    partial class HomeForm
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
            this.Bankers_list = new System.Windows.Forms.ListBox();
            this.Customers_list = new System.Windows.Forms.ListBox();
            this.Accounts_list = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.branches_list = new System.Windows.Forms.ListBox();
            this.info_lbl = new System.Windows.Forms.Label();
            this.account_btn = new System.Windows.Forms.Button();
            this.branch_btn = new System.Windows.Forms.Button();
            this.banker_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.check_btn = new System.Windows.Forms.Button();
            this.loan_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bankers_list
            // 
            this.Bankers_list.FormattingEnabled = true;
            this.Bankers_list.Location = new System.Drawing.Point(209, 94);
            this.Bankers_list.Name = "Bankers_list";
            this.Bankers_list.Size = new System.Drawing.Size(182, 121);
            this.Bankers_list.TabIndex = 3;
            this.Bankers_list.SelectedIndexChanged += new System.EventHandler(this.Bankers_list_SelectedIndexChanged);
            // 
            // Customers_list
            // 
            this.Customers_list.FormattingEnabled = true;
            this.Customers_list.Location = new System.Drawing.Point(627, 94);
            this.Customers_list.Name = "Customers_list";
            this.Customers_list.Size = new System.Drawing.Size(180, 121);
            this.Customers_list.TabIndex = 4;
            this.Customers_list.SelectedIndexChanged += new System.EventHandler(this.Customers_list_SelectedIndexChanged);
            // 
            // Accounts_list
            // 
            this.Accounts_list.FormattingEnabled = true;
            this.Accounts_list.Location = new System.Drawing.Point(410, 94);
            this.Accounts_list.Name = "Accounts_list";
            this.Accounts_list.Size = new System.Drawing.Size(194, 121);
            this.Accounts_list.TabIndex = 5;
            this.Accounts_list.SelectedIndexChanged += new System.EventHandler(this.Accounts_list_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Accounts:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bankers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Branches:";
            // 
            // branches_list
            // 
            this.branches_list.FormattingEnabled = true;
            this.branches_list.Location = new System.Drawing.Point(12, 94);
            this.branches_list.Name = "branches_list";
            this.branches_list.Size = new System.Drawing.Size(182, 121);
            this.branches_list.TabIndex = 9;
            this.branches_list.SelectedIndexChanged += new System.EventHandler(this.Branches_list_SelectedIndexChanged);
            // 
            // info_lbl
            // 
            this.info_lbl.AutoSize = true;
            this.info_lbl.Location = new System.Drawing.Point(24, 245);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(0, 13);
            this.info_lbl.TabIndex = 11;
            // 
            // account_btn
            // 
            this.account_btn.Location = new System.Drawing.Point(731, 275);
            this.account_btn.Name = "account_btn";
            this.account_btn.Size = new System.Drawing.Size(75, 23);
            this.account_btn.TabIndex = 12;
            this.account_btn.Text = "Account";
            this.account_btn.UseVisualStyleBackColor = true;
            this.account_btn.Click += new System.EventHandler(this.Account_btn_Click);
            // 
            // branch_btn
            // 
            this.branch_btn.Location = new System.Drawing.Point(731, 314);
            this.branch_btn.Name = "branch_btn";
            this.branch_btn.Size = new System.Drawing.Size(75, 23);
            this.branch_btn.TabIndex = 13;
            this.branch_btn.Text = "Branch";
            this.branch_btn.UseVisualStyleBackColor = true;
            this.branch_btn.Click += new System.EventHandler(this.branch_btn_Click);
            // 
            // banker_btn
            // 
            this.banker_btn.Location = new System.Drawing.Point(731, 353);
            this.banker_btn.Name = "banker_btn";
            this.banker_btn.Size = new System.Drawing.Size(75, 23);
            this.banker_btn.TabIndex = 14;
            this.banker_btn.Text = "Banker";
            this.banker_btn.UseVisualStyleBackColor = true;
            this.banker_btn.Click += new System.EventHandler(this.banker_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(731, 393);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 15;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // check_btn
            // 
            this.check_btn.Location = new System.Drawing.Point(627, 275);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(75, 23);
            this.check_btn.TabIndex = 16;
            this.check_btn.Text = "Check";
            this.check_btn.UseVisualStyleBackColor = true;
            this.check_btn.Click += new System.EventHandler(this.Check_btn_Click);
            // 
            // loan_btn
            // 
            this.loan_btn.Location = new System.Drawing.Point(627, 314);
            this.loan_btn.Name = "loan_btn";
            this.loan_btn.Size = new System.Drawing.Size(75, 23);
            this.loan_btn.TabIndex = 17;
            this.loan_btn.Text = "Loan";
            this.loan_btn.UseVisualStyleBackColor = true;
            this.loan_btn.Click += new System.EventHandler(this.Loan_btn_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.loan_btn);
            this.Controls.Add(this.check_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.banker_btn);
            this.Controls.Add(this.branch_btn);
            this.Controls.Add(this.account_btn);
            this.Controls.Add(this.info_lbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.branches_list);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Accounts_list);
            this.Controls.Add(this.Customers_list);
            this.Controls.Add(this.Bankers_list);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeForm_FormClosed);
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Bankers_list;
        private System.Windows.Forms.ListBox Customers_list;
        private System.Windows.Forms.ListBox Accounts_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox branches_list;
        private System.Windows.Forms.Label info_lbl;
        private System.Windows.Forms.Button account_btn;
        private System.Windows.Forms.Button branch_btn;
        private System.Windows.Forms.Button banker_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.Button loan_btn;
    }
}