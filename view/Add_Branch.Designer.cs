
namespace BankMekllat.view
{
    partial class Add_Branch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_branchname = new System.Windows.Forms.TextBox();
            this.txt_branchcode = new System.Windows.Forms.TextBox();
            this.txt_branchzip = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_branchzip);
            this.groupBox1.Controls.Add(this.txt_branchcode);
            this.groupBox1.Controls.Add(this.txt_branchname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(323, 272);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(126, 42);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branch Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Branc code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Branch ZipCode:";
            // 
            // txt_branchname
            // 
            this.txt_branchname.Location = new System.Drawing.Point(149, 51);
            this.txt_branchname.Name = "txt_branchname";
            this.txt_branchname.Size = new System.Drawing.Size(137, 22);
            this.txt_branchname.TabIndex = 3;
            // 
            // txt_branchcode
            // 
            this.txt_branchcode.Location = new System.Drawing.Point(491, 53);
            this.txt_branchcode.Name = "txt_branchcode";
            this.txt_branchcode.Size = new System.Drawing.Size(137, 22);
            this.txt_branchcode.TabIndex = 4;
            // 
            // txt_branchzip
            // 
            this.txt_branchzip.Location = new System.Drawing.Point(161, 123);
            this.txt_branchzip.Name = "txt_branchzip";
            this.txt_branchzip.Size = new System.Drawing.Size(137, 22);
            this.txt_branchzip.TabIndex = 5;
            // 
            // Add_Branch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.groupBox1);
            this.Name = "Add_Branch";
            this.Text = "Add_Branch";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_branchzip;
        private System.Windows.Forms.TextBox txt_branchcode;
        private System.Windows.Forms.TextBox txt_branchname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_submit;
    }
}