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
using Wazzaaap.BLL;
using System.Reflection.Metadata;
using System.Net.Http.Json;
using System.Timers;
using System.Runtime.CompilerServices;
using System.Web;
using System.Net.Security;

namespace Wazzaaap.Forms
{
    public  partial class chatBox : UserControl
    {
        private static readonly HttpClient client = new HttpClient();
        public chatBox()
        {
            if (!this.DesignMode)
            { 
                InitializeComponent();
                bubble1.Visible = false;
                
            }
        }

        int curtop = 10;
        bubble bbl_old = new bubble();
        public int chatid { get; set; }
        private System.Timers.Timer _timer;
        private DateTime _lastChecked;

        public void PoolingApi()
        {
            // Set up the timer to execute the CheckForNewRows task every 30 seconds
            _timer = new System.Timers.Timer(1000);
            _timer.Elapsed += CheckForNewRows;
            _timer.Start();

            // Set the initial value of _lastChecked to the current time
            _lastChecked = DateTime.Now;
        }

        public void CheckForNewRows(object sender, ElapsedEventArgs e)
        {
            Task<string> response_task = CallMethodAPI();
            string response_string = response_task.Result;

            if (response_string != null)
            {
                var jsonresponse = JsonConvert.DeserializeObject<messages[]>(response_string);
                foreach(var item in jsonresponse)
                {
                    if(item.id != user_bl.id)
                    {
                        addOutMessage(item.content,item.sentAt.ToString());
                    }
                }
            }
            //trocar a chamada da api para um novo metodo
            //a seguir basta ----> CASO A API TRAGA RESULTADOS BASTAS ADICIONAR NO METODO ADD IN MESSAGE
            //Nao esquecer de tratar do encoding url
        }

        public async Task<string> CallMethodAPI()
        {
            var response = await client.GetAsync("https://localhost:7011/api/Message/get-message-chatid?_chatid=" + chatid + "&_lastchecked=" + HttpUtility.UrlEncode(_lastChecked.ToString("hh:mm:ss")) +"");
            string jsonresponse = await response.Content.ReadAsStringAsync();

            return jsonresponse;
        }

        public void addInMessage(string message,string time)
        {
            bubble bbl = new bubble(message,time,msgtype.In);
            bbl.Location = bubble1.Location;
            bbl.Size = bubble1.Size;
            bbl.Anchor = bubble1.Anchor;
            bbl.Top = bbl_old.Bottom + 10;
            panel2.Controls.Add(bbl);
            PicBottom.Top = bbl.Bottom + 30;

            panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;

            bbl_old = bbl;
        }

        public void addOutMessage(string message, string time)
        {
            bubble bbl = new bubble(message, time, msgtype.Out );
            bbl.Location = bubble1.Location; bbl.Left += 270;
            bbl.Size = bubble1.Size;
            bbl.Anchor = bubble1.Anchor;
            bbl.Top = bbl_old.Bottom + 10;
            panel2.Controls.Add(bbl); //THREAD ERROR : POSSIBLE SOLUTION INVOKE THREAD'S!

            PicBottom.Top = bbl.Bottom + 30;

            bbl_old = bbl;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;
            SendMessage(chatid);
            addInMessage(richTextBox1.Text, DateTime.Now.ToString());
            richTextBox1.Clear();
        }

        public async Task GetHist(int _chatid)
        {
            //teste API diogo duarte--------------------------------------------------
            try
            {
                var response = await client.GetAsync("https://localhost:7011/api/Message/get-all-messages");
                string jsonresponse = await response.Content.ReadAsStringAsync();
                var hist = JsonConvert.DeserializeObject<messages[]>(jsonresponse);
                
                foreach (var item in hist)
                {
                    if (item.userid == user_bl.id && item.chatid == _chatid)
                    {
                        addInMessage(item.content, item.sentAt.ToString());
                    }
                    else if(item.chatid == _chatid && item.userid != user_bl.id)
                    {
                        addOutMessage(item.content, item.sentAt.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            //teste API diogo duarte----------------------------------------------------------
        }

        public async Task SendMessage(int _chatid)
        {
            using (var client = new HttpClient())
            {
                messages p = new messages { userid = user_bl.id, chatid = _chatid, content = richTextBox1.Text, sentAt = DateTime.Now };
                client.BaseAddress = new Uri("https://localhost:7011/");
                var response = client.PostAsJsonAsync("api/Message", p).Result;
                if (response.IsSuccessStatusCode)
                {
                }
                else
                {
                    MessageBox.Show("Erro no envio da mensagem");
                } 
            }
        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (richTextBox1.Text != null)
                {
                    SendMessage(chatid);
                    addInMessage(richTextBox1.Text, DateTime.Now.ToString());
                    richTextBox1.Clear();
                }
            }
        }
    }
}
