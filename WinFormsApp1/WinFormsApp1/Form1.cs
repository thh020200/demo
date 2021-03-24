using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string pass = "admin";
            if (user.Equals(txtusername.Text) && pass.Equals(txtpassword.Text))
            {
                MessageBox.Show("Đăng nhạp thành công!");
                Form2 f2 = new Form2();
                f2.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Đăng nhập thất bại!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
