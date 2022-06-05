
namespace BankMekllat.view
{
    partial class Transaction
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_transnum = new System.Windows.Forms.TextBox();
            this.txt_national = new System.Windows.Forms.TextBox();
            this.txt_accountno = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txt_destination = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_destination);
            this.groupBox1.Controls.Add(this.txt_date);
            this.groupBox1.Controls.Add(this.txt_amount);
            this.groupBox1.Controls.Add(this.txt_accountno);
            this.groupBox1.Controls.Add(this.txt_national);
            this.groupBox1.Controls.Add(this.txt_transnum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer National No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Transaction Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Transaction Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Destination Card No.";
            // 
            // txt_transnum
            // 
            this.txt_transnum.Location = new System.Drawing.Point(138, 47);
            this.txt_transnum.Name = "txt_transnum";
            this.txt_transnum.Size = new System.Drawing.Size(212, 22);
            this.txt_transnum.TabIndex = 6;
            // 
            // txt_national
            // 
            this.txt_national.Location = new System.Drawing.Point(177, 96);
            this.txt_national.Name = "txt_national";
            this.txt_national.Size = new System.Drawing.Size(173, 22);
            this.txt_national.TabIndex = 7;
            // 
            // txt_accountno
            // 
            this.txt_accountno.Location = new System.Drawing.Point(138, 151);
            this.txt_accountno.Name = "txt_accountno";
            this.txt_accountno.Size = new System.Drawing.Size(212, 22);
            this.txt_accountno.TabIndex = 8;
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(164, 210);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(186, 22);
            this.txt_amount.TabIndex = 9;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(146, 269);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(204, 22);
            this.txt_date.TabIndex = 10;
            // 
            // txt_destination
            // 
            this.txt_destination.Location = new System.Drawing.Point(164, 327);
            this.txt_destination.Name = "txt_destination";
            this.txt_destination.Size = new System.Drawing.Size(186, 22);
            this.txt_destination.TabIndex = 11;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(136, 445);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(164, 42);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "Submit Transaction";
            this.btn_submit.UseVisualStyleBackColor = true;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 521);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_destination;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_accountno;
        private System.Windows.Forms.TextBox txt_national;
        private System.Windows.Forms.TextBox txt_transnum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_submit;
    }
}