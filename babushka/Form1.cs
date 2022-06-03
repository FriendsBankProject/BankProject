using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using this_is_baba.forms;


namespace this_is_baba
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
       
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btndashboard_Click(object sender, EventArgs e)
        {
            var Btndashboard = new loan();
            Btndashboard.Show();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var button1 = new account();
            button1.Show();
        }

        private void Btndashboard_Leave(object sender, EventArgs e)
        {
            loan.BackColor = Color.FromArgb(75, 0, 130);
        }

        private void gay_list_Click(object sender, EventArgs e)
        {
            var gay_list = new Adress();
            gay_list.Show();
        }

        private void hentai_Click(object sender, EventArgs e)
        {
            var hentai = new transaction();
            hentai.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var button1 = new Banker();
            button1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var button2 = new check();
            button2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var button3 = new Branch();
            button3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var button4 = new customer();
            button4.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
