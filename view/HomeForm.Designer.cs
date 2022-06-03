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
            this.btn_AddAcc = new System.Windows.Forms.Button();
            this.btn_AddBanker = new System.Windows.Forms.Button();
            this.btn_AddBranch = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bankers_list
            // 
            this.Bankers_list.FormattingEnabled = true;
            this.Bankers_list.ItemHeight = 16;
            this.Bankers_list.Location = new System.Drawing.Point(279, 116);
            this.Bankers_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bankers_list.Name = "Bankers_list";
            this.Bankers_list.Size = new System.Drawing.Size(241, 148);
            this.Bankers_list.TabIndex = 3;
            this.Bankers_list.SelectedIndexChanged += new System.EventHandler(this.Bankers_list_SelectedIndexChanged);
            // 
            // Customers_list
            // 
            this.Customers_list.FormattingEnabled = true;
            this.Customers_list.ItemHeight = 16;
            this.Customers_list.Location = new System.Drawing.Point(836, 116);
            this.Customers_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Customers_list.Name = "Customers_list";
            this.Customers_list.Size = new System.Drawing.Size(239, 148);
            this.Customers_list.TabIndex = 4;
            this.Customers_list.SelectedIndexChanged += new System.EventHandler(this.Customers_list_SelectedIndexChanged);
            // 
            // Accounts_list
            // 
            this.Accounts_list.FormattingEnabled = true;
            this.Accounts_list.ItemHeight = 16;
            this.Accounts_list.Location = new System.Drawing.Point(547, 116);
            this.Accounts_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Accounts_list.Name = "Accounts_list";
            this.Accounts_list.Size = new System.Drawing.Size(257, 148);
            this.Accounts_list.TabIndex = 5;
            this.Accounts_list.SelectedIndexChanged += new System.EventHandler(this.Accounts_list_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(889, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(619, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Accounts:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bankers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Branches:";
            // 
            // branches_list
            // 
            this.branches_list.FormattingEnabled = true;
            this.branches_list.ItemHeight = 16;
            this.branches_list.Location = new System.Drawing.Point(16, 116);
            this.branches_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.branches_list.Name = "branches_list";
            this.branches_list.Size = new System.Drawing.Size(241, 148);
            this.branches_list.TabIndex = 9;
            this.branches_list.SelectedIndexChanged += new System.EventHandler(this.Branches_list_SelectedIndexChanged);
            // 
            // info_lbl
            // 
            this.info_lbl.AutoSize = true;
            this.info_lbl.Location = new System.Drawing.Point(32, 302);
            this.info_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(0, 17);
            this.info_lbl.TabIndex = 11;
            // 
            // btn_AddAcc
            // 
            this.btn_AddAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(144)))), ((int)(((byte)(128)))));
            this.btn_AddAcc.Location = new System.Drawing.Point(54, 608);
            this.btn_AddAcc.Name = "btn_AddAcc";
            this.btn_AddAcc.Size = new System.Drawing.Size(175, 51);
            this.btn_AddAcc.TabIndex = 12;
            this.btn_AddAcc.Text = "New Account";
            this.btn_AddAcc.UseVisualStyleBackColor = true;
            this.btn_AddAcc.Click += new System.EventHandler(this.btn_AddAcc_Click);
            // 
            // btn_AddBanker
            // 
            this.btn_AddBanker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(144)))), ((int)(((byte)(128)))));
            this.btn_AddBanker.Location = new System.Drawing.Point(655, 608);
            this.btn_AddBanker.Name = "btn_AddBanker";
            this.btn_AddBanker.Size = new System.Drawing.Size(175, 51);
            this.btn_AddBanker.TabIndex = 13;
            this.btn_AddBanker.Text = "New Banker";
            this.btn_AddBanker.UseVisualStyleBackColor = true;
            // 
            // btn_AddBranch
            // 
            this.btn_AddBranch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(144)))), ((int)(((byte)(128)))));
            this.btn_AddBranch.Location = new System.Drawing.Point(863, 608);
            this.btn_AddBranch.Name = "btn_AddBranch";
            this.btn_AddBranch.Size = new System.Drawing.Size(175, 51);
            this.btn_AddBranch.TabIndex = 14;
            this.btn_AddBranch.Text = "New Branch";
            this.btn_AddBranch.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(144)))), ((int)(((byte)(128)))));
            this.btn_Delete.Location = new System.Drawing.Point(448, 608);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(175, 51);
            this.btn_Delete.TabIndex = 15;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(144)))), ((int)(((byte)(128)))));
            this.btn_Edit.Location = new System.Drawing.Point(248, 608);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(175, 51);
            this.btn_Edit.TabIndex = 16;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 698);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_AddBranch);
            this.Controls.Add(this.btn_AddBanker);
            this.Controls.Add(this.btn_AddAcc);
            this.Controls.Add(this.info_lbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.branches_list);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Accounts_list);
            this.Controls.Add(this.Customers_list);
            this.Controls.Add(this.Bankers_list);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
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
        private System.Windows.Forms.Button btn_AddAcc;
        private System.Windows.Forms.Button btn_AddBanker;
        private System.Windows.Forms.Button btn_AddBranch;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
    }
}