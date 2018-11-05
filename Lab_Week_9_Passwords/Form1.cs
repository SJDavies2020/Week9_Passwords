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
            InitializeComponent(); //Initialize the Application and Vaiables
        }

        private void btnLogin_Click(object sender, EventArgs e) // Button Code
        {
            if (txtLogin.Text == "")
            {
                MessageBox.Show("Please input a valid password"); // Text on no password
                return;
            }

            else if (txtLogin.Text == "COMP1030")
            {
                MessageBox.Show("Valid password please continue.."); //Text on Valid Password
            }

            else if (txtLogin.Text != "COMP1030")

            {
                MessageBox.Show("Invalid Password"); //  Text on Invalid Password.
                return;
            }

        }
    }
}