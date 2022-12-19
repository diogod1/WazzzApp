using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Wazzaaap.Model;
using MySqlX.XDevAPI.Common;

namespace Wazzaaap.Forms
{
    public partial class frmmainWazzaapp : Form
    {
        bool mouseDown;
        private Point offset;
        int chatid;

        public frmmainWazzaapp()
        {
            InitializeComponent();
            
        }
     
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblWazzaapp_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxSearchWazzaapp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUser2_Click(object sender, EventArgs e)
        {
            //chat general
            chatid = 2;
            Size tamanho = new Size(862, 636);
            chatBox ch2 = new chatBox();
            ch2.Size = tamanho;
            ch2.GetHist(chatid);
            ch2.Refresh();
            ch2.Show();
            this.Controls.Add(ch2);
            pnlMainWazzaapp.Controls.Add((Control)ch2);
        }

        private void pnlMainWazzaapp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picBoxMinimizeWazzaapp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void pnlHeaderWazzaapp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUser1_Click(object sender, EventArgs e)
        {
            //size 862; 636
            //chat general2
            pnlMainWazzaapp.Controls.Clear();
            chatid = 1;
            Size tamanho = new Size(862, 636);
            chatBox ch1 = new chatBox();
            ch1.Size = tamanho;
            ch1.GetHist(chatid);
            ch1.Refresh();
            ch1.Show();
            this.Controls.Add(ch1); 
            pnlMainWazzaapp.Controls.Add((Control)ch1);
            
        }

        private void btnUser4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmUserProfile fup = new FrmUserProfile();
            fup.Show();
        }
    }
    
}
