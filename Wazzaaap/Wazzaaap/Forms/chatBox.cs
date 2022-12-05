using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace Wazzaaap.Forms
{
    public partial class chatBox : UserControl
    {
        
        public chatBox()

        {
            if (!this.DesignMode)
            { 

                 InitializeComponent();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
