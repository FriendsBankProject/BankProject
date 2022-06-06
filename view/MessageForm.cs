using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankMekllat.view
{
    public partial class MessageForm : Form
    {
        
        private Action<Result> onClick;
       public enum Result
        {
            ok,edit,delete
        }
        public MessageForm(string message, Action<Result> onClick)
        {
            InitializeComponent();
            message_lbl.Text = message;
            this.onClick = onClick;
        }


     

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            Close();
            onClick(Result.edit);
           
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            Close();
            onClick(Result.delete);
            
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            Close();
            onClick(Result.ok);
           
        }
    }
}
