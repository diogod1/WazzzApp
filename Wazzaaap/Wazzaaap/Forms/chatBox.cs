using Newtonsoft.Json;
using System.Data;
using System.Net.Http.Json;
using System.Timers;
using System.Web;
using Wazzaaap.BLL;
using Wazzaaap.Model;

namespace Wazzaaap.Forms
{
    public partial class chatBox : UserControl
    {
        private static readonly HttpClient client = new HttpClient();
        public chatBox()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
                bubble1.Visible = false;
                PoolingApi();
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
            _timer = new System.Timers.Timer(2 * 1000);
            _timer.Elapsed += CheckForNewRows;
            _timer.Start();

            // Set the initial value o f _lastChecked to the current time
            /// _lastChecked = DateTime.Now;
        }

        public void CheckForNewRows(object sender, ElapsedEventArgs e)
        {
            try
            {
                Task<string> response_task = CallMethodAPI();
                if (response_task.Result != null)
                {
                    string response_string = response_task.Result;
                    var jsonresponse = JsonConvert.DeserializeObject<messages[]>(response_string);
                    var last_message = JsonConvert.DeserializeObject<List<messages>>(response_string);
                    var mostRecentMessage = last_message.Where(m => m.chatid == chatid).OrderByDescending(m => m.sentAt).FirstOrDefault();
                    _lastChecked = mostRecentMessage.sentAt;
                    foreach (var item in jsonresponse)
                    {
                        if (item.userid != user_bl.id)
                        {
                            addOutMessage(item.content, item.sentAt.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //trocar a chamada da api para um novo metodo
            //a seguir basta ----> CASO A API TRAGA RESULTADOS BASTAS ADICIONAR NO METODO ADD IN MESSAGE
            //Nao esquecer de tratar do encoding url
        }

        public async Task<string> CallMethodAPI()
        {
            string date = _lastChecked.ToString("yyyy-MM-dd");
            string time = _lastChecked.ToString("HH:mm:ss");

            // Encode the time part only
            string encodedTime = HttpUtility.UrlEncode(time);

            // Concatenate the date and time parts back together, using the "T" character as a separator
            string formattedTime = date + "T" + encodedTime;

            var response = await client.GetAsync("https://localhost:7011/api/Message/get-chatid?_chatid=" + chatid + "&_lastchecked=" + formattedTime + "");
            if (response.IsSuccessStatusCode)
            {
                string jsonresponse = await response.Content.ReadAsStringAsync();
                return jsonresponse;
            }
            else
            {
                return await Task.FromResult<string>(null);
            }
        }

        public void addInMessage(string message, string time)
        {
            if (panel2.InvokeRequired)
            {
                panel2.Invoke((MethodInvoker)delegate
                {
                    bubble bbl = new bubble(message, time, msgtype.In);
                    bbl.Location = bubble1.Location;
                    bbl.Size = bubble1.Size;
                    bbl.Anchor = bubble1.Anchor;
                    bbl.Top = bbl_old.Bottom + 10;
                    panel2.Controls.Add(bbl);
                    PicBottom.Top = bbl.Bottom + 30;

                    panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;

                    bbl_old = bbl;
                });
            }
            else
            {
                bubble bbl = new bubble(message, time, msgtype.In);
                bbl.Location = bubble1.Location;
                bbl.Size = bubble1.Size;
                bbl.Anchor = bubble1.Anchor;
                bbl.Top = bbl_old.Bottom + 10;
                panel2.Controls.Add(bbl);
                PicBottom.Top = bbl.Bottom + 30;

                panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;

                bbl_old = bbl;
            }

        }

        public void addOutMessage(string message, string time)
        {
            if (panel2.InvokeRequired)
            {
                panel2.Invoke((MethodInvoker)delegate
                {
                    bubble bbl = new bubble(message, time, msgtype.Out);
                    bbl.Location = bubble1.Location; bbl.Left += 270;
                    bbl.Size = bubble1.Size;
                    bbl.Anchor = bubble1.Anchor;
                    bbl.Top = bbl_old.Bottom + 10;
                    panel2.Controls.Add(bbl);
                    PicBottom.Top = bbl.Bottom + 30;
                    bbl_old = bbl;
                });
            }
            else
            {
                bubble bbl2 = new bubble(message, time, msgtype.Out);
                bbl2.Location = bubble1.Location; bbl2.Left += 270;
                bbl2.Size = bubble1.Size;
                bbl2.Anchor = bubble1.Anchor;
                bbl2.Top = bbl_old.Bottom + 10;
                panel2.Controls.Add(bbl2);
                PicBottom.Top = bbl2.Bottom + 30;
                bbl_old = bbl2;
            }
            //THREAD ERROR : POSSIBLE SOLUTION INVOKE THREAD'S!
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;
            SendMessage(chatid);
            richTextBox1.Clear();
        }

        public async Task GetHist(int _chatid)
        {
            //teste API diogo duarte--------------------------------------------------
            try
            {
                var response = await client.GetAsync("https://localhost:7011/api/Message/get-all");
                if (response.IsSuccessStatusCode)
                {
                    string jsonresponse = await response.Content.ReadAsStringAsync();
                    var hist = JsonConvert.DeserializeObject<messages[]>(jsonresponse);
                    var last_message = JsonConvert.DeserializeObject<List<messages>>(jsonresponse);
                    var mostRecentMessage = last_message.Where(m => m.chatid == chatid).OrderByDescending(m => m.sentAt).FirstOrDefault();
                    if (mostRecentMessage != null)
                    {
                        _lastChecked = mostRecentMessage.sentAt;
                    }
                    foreach (var item in hist)
                    {
                        if (item.userid == user_bl.id && item.chatid == _chatid)
                        {
                            addInMessage(item.content, item.sentAt.ToString());
                        }
                        else if (item.chatid == _chatid && item.userid != user_bl.id)
                        {
                            addOutMessage(item.content, item.sentAt.ToString());
                        }
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
                var sendmessage = new messages { userid = user_bl.id, chatid = _chatid, content = richTextBox1.Text, sentAt = DateTime.Now };
                client.BaseAddress = new Uri("https://localhost:7011/");
                var response = client.PostAsJsonAsync("api/Message/Send", sendmessage).Result;
                if (response.IsSuccessStatusCode)
                {
                    addInMessage(richTextBox1.Text, DateTime.Now.ToString());
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
                    richTextBox1.Clear();
                }
            }
        }
    }
}
