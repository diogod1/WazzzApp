﻿using System;
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
    public partial class frmError : Form
    {
        public frmError()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin f3 = new frmLogin();
            f3.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
