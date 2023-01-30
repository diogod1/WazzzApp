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
    public partial class FrmSuccess : Form
    {
        public FrmSuccess()
        {
            InitializeComponent();
        }

        private void FrmSuccess_Load(object sender, EventArgs e)
        {

        }

        private void lblRegSuccess_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            Form login = new frmLogin();
            login.Show();
        }
    }
}
