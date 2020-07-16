using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToEntities
{
    public partial class fLogin : Form
    {
        
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Authentication();        
        }

        private void Authentication()
        {
            string u = txtUsername.Text;
            string p = txtPassword.Text;
            if ( u == "admin" && p == "admin")
            {
                MainForm f = new MainForm();
                f.Show();
                MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG");
                this.Hide();
               
            }else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "THÔNG BÁO" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
            Authentication();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
