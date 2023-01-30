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
        bool mouseDown;
        private Point offset;

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
            if(textBoxPassReg.Text != textBoxPassReg2.Text)
            {
                MessageBox.Show("Erro");
            }
            else
            {
                user_bl.username = textBoxUserReg.Text;
                user_bl.name = textBoxNameReg.Text;
                user_bl.password = textBoxPassReg.Text;
                var register = user_bl.register();
                if(register == 2)
                {
                    lblPassConditionReg.ForeColor = System.Drawing.Color.Red;
                }
                else if (register == 1)
                {
                    this.Close();
                    Form frmsucess = new FrmSuccess();
                    frmsucess.Show();
                }
                else if(register == 0)
                {
                    MessageBox.Show("Erro no registo");
                }            
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNameReg_Click(object sender, EventArgs e)
        {

        }

        private void picBoxMinimizeRegister_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }
    }
}
