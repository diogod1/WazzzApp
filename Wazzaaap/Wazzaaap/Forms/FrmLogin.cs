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
        bool mouseDown;
        private Point offset;

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
            user_bl.username = txtBoxUserLogin.Text;
            user_bl.password = textBoxPassLogin.Text;
            user_bl.login();

            if (user_bl.login() == 1)
            {
                user_bl.init_user(user_bl.username);
                this.Hide();
                frmmainWazzaapp f2 = new frmmainWazzaapp();
                f2.Show();
            }
            else
            {
                frmError f4 = new frmError();
                f4.Show(); 
            }

        }

        private void picBoxMinimizeLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlDragLogin_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void lblUsernameLogin_Click(object sender, EventArgs e)
        {

        }
    }
}

