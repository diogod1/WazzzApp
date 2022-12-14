using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wazzaaap.Forms
{
    public partial class FrmUserProfile : Form
    {
        bool mouseDown;
        private Point offset;

        public FrmUserProfile()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBoxPhoto_Click(object sender, EventArgs e)
        {
           
        }

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog file_dialog = new OpenFileDialog();
            file_dialog.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png";
            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                var file_path = file_dialog.FileName;
            }
        }

        private void pnlDragProfile_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void pnlDragProfile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlDragProfile_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pnlDragProfile_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtBoxBio.ReadOnly = false;
                txtBoxNome.ReadOnly = false;
                comboBoxStatus.Enabled = true;
            }
            else
            {
                txtBoxBio.ReadOnly = true;
                txtBoxNome.ReadOnly = true;
                comboBoxStatus.Enabled = false;
            }
        }
    }
}
