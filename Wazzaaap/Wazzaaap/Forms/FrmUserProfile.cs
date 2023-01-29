using Newtonsoft.Json;
using Wazzaaap.BLL;

namespace Wazzaaap.Forms
{
    public partial class FrmUserProfile : Form
    {
        bool mouseDown;
        private Point offset;

        public FrmUserProfile()
        {
            InitializeComponent();
            initObjects();
        }
        public void initObjects()
        {
            txtBoxBio.Text = user_bl.bio;
            txtBoxUsername.Text = user_bl.username;
            txtBoxNome.Text = user_bl.name;
            // picBoxPhoto.Image = user_bl.photopath;
            comboBoxStatus.Text = user_bl.status;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBoxPhoto_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog file_dialog = new OpenFileDialog();
            file_dialog.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png";
            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                var file_path = file_dialog.FileName;
                byte[] imageBytes = File.ReadAllBytes(file_path);
                /*CHAMAR API PARA GUARDAR IMAGEM*/
                picBoxPhoto.Image = Image.FromFile(file_path);
            }
        }

        private void pnlDragProfile_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void pnlDragProfile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlDragProfile_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pnlDragProfile_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtBoxBio.ReadOnly = false;
                txtBoxNome.ReadOnly = false;
                comboBoxStatus.Enabled = true;
            }
            else
            {
                txtBoxBio.ReadOnly = true;
                txtBoxNome.ReadOnly = true;
                comboBoxStatus.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            var json = new
            {
                name = txtBoxNome.Text,
                bio = txtBoxBio.Text,
                status = comboBoxStatus.Text,
                photo_path = ""
            };

            var jsonString = JsonConvert.SerializeObject(json);
            var content = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json");

            var response = client.PutAsync($"https://localhost:7011/api/User/Update?id={user_bl.id}", content).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Dados guardados com sucesso");
                user_bl.bio = txtBoxBio.Text;
                user_bl.username = txtBoxUsername.Text;
                user_bl.name = txtBoxNome.Text;
                user_bl.status = comboBoxStatus.Text;
            }
            else
            {
                MessageBox.Show("Falha a guardar os dados");
            }
        }

        private void btnAlteraPassword_Click(object sender, EventArgs e)
        {
            var frm = new FrmAlteraPassword();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}