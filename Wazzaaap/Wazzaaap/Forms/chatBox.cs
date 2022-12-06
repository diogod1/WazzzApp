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
using Newtonsoft.Json;
using Wazzaaap.Model;

namespace Wazzaaap.Forms
{
    public  partial class chatBox : UserControl
    {
        public chatBox()
        {
           // GetHist();
            if (!this.DesignMode)
            { 
                InitializeComponent();
                bubble1.Visible = false;
            }
        }

        int curtop = 10;
        bubble bbl_old = new bubble();
        public void addInMessage(string message,string time)
        {
            bubble bbl = new bubble(message,time,msgtype.In);
            bbl.Location = bubble1.Location;
            bbl.Size = bubble1.Size;
            bbl.Anchor = bubble1.Anchor;
            bbl.Top = bbl_old.Bottom + 10;
            panel2.Controls.Add(bbl);

            panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;

            bbl_old = bbl;
        }

        public void addOutMessage(string message, string time)
        {
            bubble bbl = new bubble(message, time, msgtype.Out );
            bbl.Location = bubble1.Location; bbl.Left += 400;
            bbl.Size = bubble1.Size;
            bbl.Anchor = bubble1.Anchor;
            bbl.Top = bbl_old.Bottom + 10;
            panel2.Controls.Add(bbl);

            PicBottom.Top = bbl.Bottom + 30;

            bbl_old = bbl;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;
        }

        public async Task GetHist()
        {
            //teste API diogo duarte--------------------------------------------------
            HttpClient client = new HttpClient();
            var userid = 1;
            try
            {
                var response = await client.GetAsync("https://localhost:7011/api/Message/get-all-messages");
                string jsonresponse = await response.Content.ReadAsStringAsync();
                var hist = JsonConvert.DeserializeObject<messages[]>(jsonresponse);

                foreach (var item in hist)
                {
                    if (item.userid == userid)
                    {
                        addInMessage(item.content, item.sentAt.ToString());
                    }
                    else
                    {
                        addOutMessage(item.content, item.sentAt.ToString());
                    }
                }
            }
            catch (Exception e)
            {

            }

            //teste API diogo duarte----------------------------------------------------------
        }
    }
}
