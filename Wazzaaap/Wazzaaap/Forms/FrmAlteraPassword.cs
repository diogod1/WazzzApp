using Newtonsoft.Json;
using Wazzaaap.BLL;

namespace Wazzaaap.Forms
{
    public partial class FrmAlteraPassword : Form
    {
        public FrmAlteraPassword()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPasswordNova.Text == txtPassRepeatNova.Text)
            {
                HttpClient client = new HttpClient();

                var json = new
                {
                    userid = user_bl.id,
                    new_password = txtPasswordNova.Text,
                    old_password = txtPasswordAntiga.Text,
                };

                var jsonString = JsonConvert.SerializeObject(json);
                var content = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json");

                var response = client.PutAsync($"https://localhost:7011/api/User/ChangePassword", content).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Nova password atualizada");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar a password");
                }
            }
            else
            {
                MessageBox.Show("As novas password's não são iguais");
            }
        }

        private void checkBoxShowPassLog_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassLog.Checked)
            {
                txtPasswordAntiga.PasswordChar = '\0';
                txtPassRepeatNova.PasswordChar = '\0';
                txtPasswordNova.PasswordChar = '\0';
            }
            else
            {
                txtPasswordNova.PasswordChar = '*';
                txtPassRepeatNova.PasswordChar = '*';
                txtPasswordAntiga.PasswordChar = '*';
            }
        }
    }
}
