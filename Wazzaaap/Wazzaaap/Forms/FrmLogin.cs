using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wazzaaap.BLL;

namespace Wazzaaap.Forms
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void pnlLoginSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCreateAcc_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassLog.Checked)
            {
                textBoxPassLogin.PasswordChar = '\0';
            }
            else
            {
                textBoxPassLogin.PasswordChar = '*';
            }
        }
    

        private void textBoxUserLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void picBoxExitLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLblCreateAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new frmRegister();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            user_bl teste = new user_bl();
            teste.username = textBoxUserLogin.Text;
            teste.password = textBoxPassLogin.Text;
            teste.login();
        }
    }
}

