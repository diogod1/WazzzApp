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
    public partial class bubble : UserControl
    {
        public bubble()
        {
            InitializeComponent();
        }

        public bubble(string message, string time, msgtype messagetype)
        {
            InitializeComponent();
            lblMessage.Text = message;
            lblTime.Text = time;

            if(messagetype.ToString()=="In")
            {
                //Entrada de Mensagem
                this.BackColor = Color.FromArgb(0, 171, 255);
            }
            else
            {
                //Saída de Mensagem
                this.BackColor = Color.Gray;
            }

            Setheight();
        }

        //Ajuste de altura
        void Setheight()
        {
            Size maxSize = new Size(495, int.MaxValue);
            Graphics g = CreateGraphics();
            SizeF size = g.MeasureString(lblMessage.Text, lblMessage.Font, lblMessage.Width);

            lblMessage.Height = int.Parse(Math.Round(size.Height + 2, 0).ToString());
            lblTime.Top = lblMessage.Bottom +10;
            this.Height = lblTime.Height + 10;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bubble_Load(object sender, EventArgs e)
        {

        }

        private void lblMessage_Resize(object sender, EventArgs e)
        {
            Setheight();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
    }

    public enum msgtype
    {
        In,
        Out
    }
}
