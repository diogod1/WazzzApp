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
        }

        public enum msgtype
        {
            In,
            Out
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bubble_Load(object sender, EventArgs e)
        {

        }

        //Ajuste de altura do componente bubble
        void Setheight(Label _label)
        {
            Size maxSize = new Size(495, int.MaxValue);
            Graphics g = CreateGraphics();
            SizeF size = g.MeasureString(_label.Text, _label.Font, _label.Width);

            _label.Height = int.Parse(Math.Round(size.Height + 2, 0).ToString());

            this.Height = lblMessage.Height + lblMessage.Top;
        }

    }
}
