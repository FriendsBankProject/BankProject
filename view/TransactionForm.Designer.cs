
namespace BankMekllat.view
{
    partial class TransactionForm
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
            this.destination_txt = new System.Windows.Forms.TextBox();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.accountno_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.destination_txt);
            this.groupBox1.Controls.Add(this.amount_txt);
            this.groupBox1.Controls.Add(this.accountno_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(291, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "information";
            // 
            // destination_txt
            // 
            this.destination_txt.Location = new System.Drawing.Point(122, 140);
            this.destination_txt.Margin = new System.Windows.Forms.Padding(2);
            this.destination_txt.Name = "destination_txt";
            this.destination_txt.Size = new System.Drawing.Size(140, 20);
            this.destination_txt.TabIndex = 11;
            // 
            // amount_txt
            // 
            this.amount_txt.Location = new System.Drawing.Point(123, 92);
            this.amount_txt.Margin = new System.Windows.Forms.Padding(2);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(140, 20);
            this.amount_txt.TabIndex = 9;
            // 
            // accountno_txt
            // 
            this.accountno_txt.Location = new System.Drawing.Point(104, 44);
            this.accountno_txt.Margin = new System.Windows.Forms.Padding(2);
            this.accountno_txt.Name = "accountno_txt";
            this.accountno_txt.Size = new System.Drawing.Size(160, 20);
            this.accountno_txt.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Destination Card No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Transaction Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account No.";
            // 
            // btn_submit
            // 
            this.btn_submit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_submit.Location = new System.Drawing.Point(100, 336);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(123, 34);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "Submit Transaction";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.Btn_submit_Click);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 423);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TransactionForm";
            this.Text = "Transaction";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TransactionForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox destination_txt;
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.TextBox accountno_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_submit;
    }
}