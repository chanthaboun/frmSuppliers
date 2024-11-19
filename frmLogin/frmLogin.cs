using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmLogin
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string pwd = txtPwd.Text;
            if (username == "admin" && pwd == "admin")
            {
                MessageBox.Show("ຍີນດີຕ້ອນຮັບທ່ານເຂົ້າສູ່ລະບົບ!");
                frmMainMenu frm = new frmMainMenu();
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
                //this.Close();   
                this.Hide();

            }
            else 
            {
                MessageBox.Show("Username And Password Wrong");
            }

        }
    }
}
