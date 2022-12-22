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
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Tls;
using Wazzaaap.BLL;

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
            init_chats_messages();
        }
        
        public async void init_chats_messages()
        {
            HttpClient client= new HttpClient();
            try
            {
                var response = await client.GetAsync("https://localhost:7011/api/Message/get-all-chats");
                string jsonresponse = await response.Content.ReadAsStringAsync();
                var chats = JsonConvert.DeserializeObject<chat[]>(jsonresponse);
                var location = new Point(0, 0);

                foreach (var item in chats)
                {
                    string name = $"BtnChat{item.id}";
                    Button btn = new Button();
                    btn.Name= name;
                    btn.Text = item.name;
                    btn.Size = new Size(307,58);
                    btn.Location = location;
                    location.Y = location.Y + 58;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Font = new Font("Dubai Medium",14);
                    btn.Click += Btn_Click;
                    pnlSideUsersWazzaapp.Controls.Add(btn);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            pnlMainWazzaapp.Controls.Clear();
            string cut = button.Name.Substring(7);
            chatid = (int)Int64.Parse(cut);
            Size tamanho = new Size(862, 636);
            chatBox chat_dynamic = new chatBox();
            chat_dynamic.Size = tamanho;
            chat_dynamic.GetHist(chatid);
            chat_dynamic.Refresh();
            chat_dynamic.Show();
            this.Controls.Add(chat_dynamic);
            pnlMainWazzaapp.Controls.Add((Control)chat_dynamic);
            chat_dynamic.chatid = chatid;
            lblNameChat.Text = button.Text;

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmUserProfile fup = new FrmUserProfile();
            fup.Show();
        }
    }
    
}
