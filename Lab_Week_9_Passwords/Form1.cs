using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Week_9_Passwords
{
    public partial class frmLogin : Form
    {
        public frmLogin()

        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                MessageBox.Show("Please input a valid password");
                return;
            }

            else if (txtLogin.Text == "COMP1030")
            {
                MessageBox.Show("Valid password please continue..");
            }

            else if (txtLogin.Text != "COMP1030")

            {
                MessageBox.Show("Invalid Password");
                return;
            }

        }
    }
}