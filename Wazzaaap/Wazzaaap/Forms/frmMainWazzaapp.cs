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

        public frmmainWazzaapp()
        {
            InitializeComponent();
            
        }

        private void frmmainWazzaapp_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frmmainWazzaapp_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlSideWazzaapp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlUser4Wazzaapp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblWazzaapp_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxSearchWazzaapp_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTxtBoxWazzaapp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUser2_Click(object sender, EventArgs e)
        {

        }

        private void pnlMainWazzaapp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chatBox1_Load(object sender, EventArgs e)
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
    }
    
}
