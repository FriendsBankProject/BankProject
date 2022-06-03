namespace BankMekllat.view
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
            this.username_txt = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(319, 107);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(100, 20);
            this.username_txt.TabIndex = 0;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(330, 214);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 1;
            this.login_btn.Text = "login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wellcome\r\nplease enter username and password to connect to database\r\n";
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(319, 153);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(100, 20);
            this.pass_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "password:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.username_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}