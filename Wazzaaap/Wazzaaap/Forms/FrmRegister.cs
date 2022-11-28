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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void lblLoginHeader_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBoxShowPassReg_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassReg.Checked)
            {
                textBoxPassReg.PasswordChar = '\0';
                textBoxPassReg2.PasswordChar = '\0';
            }
            else
            {
                textBoxPassReg.PasswordChar = '*';
                textBoxPassReg2.PasswordChar = '*';
            }
        }

        private void picBoxExitReg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmRegister = new frmLogin();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new frmLogin();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void textBoxUserReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassReg2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            user_bl teste = new user_bl();
            teste.username = textBoxUserReg.Text;
            teste.password = textBoxPassReg.Text;
            teste.name = textBoxPassReg2.Text;
            teste.register();
        }
    }
}
