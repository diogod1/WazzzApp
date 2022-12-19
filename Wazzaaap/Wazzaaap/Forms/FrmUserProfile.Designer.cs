namespace Wazzaaap.Forms
{
    partial class FrmUserProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserProfile));
            this.pnlDragProfile = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBoxMinimizeWazzaapp = new System.Windows.Forms.PictureBox();
            this.picBoxExitWazzaapp = new System.Windows.Forms.PictureBox();
            this.lblWazzaapp = new System.Windows.Forms.Label();
            this.picBoxIconWazzaap = new System.Windows.Forms.PictureBox();
            this.picBoxPhoto = new System.Windows.Forms.PictureBox();
            this.btnChangePhoto = new System.Windows.Forms.Button();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtBoxBio = new System.Windows.Forms.TextBox();
            this.lblBio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlDragProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizeWazzaapp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExitWazzaapp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIconWazzaap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDragProfile
            // 
            this.pnlDragProfile.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlDragProfile.Controls.Add(this.pictureBox1);
            this.pnlDragProfile.Controls.Add(this.picBoxMinimizeWazzaapp);
            this.pnlDragProfile.Controls.Add(this.picBoxExitWazzaapp);
            this.pnlDragProfile.Controls.Add(this.lblWazzaapp);
            this.pnlDragProfile.Controls.Add(this.picBoxIconWazzaap);
            this.pnlDragProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDragProfile.Location = new System.Drawing.Point(0, 0);
            this.pnlDragProfile.Name = "pnlDragProfile";
            this.pnlDragProfile.Size = new System.Drawing.Size(507, 33);
            this.pnlDragProfile.TabIndex = 1;
            this.pnlDragProfile.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDragProfile_Paint);
            this.pnlDragProfile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDragProfile_MouseDown);
            this.pnlDragProfile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDragProfile_MouseMove);
            this.pnlDragProfile.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDragProfile_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(470, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picBoxMinimizeWazzaapp
            // 
            this.picBoxMinimizeWazzaapp.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMinimizeWazzaapp.Image")));
            this.picBoxMinimizeWazzaapp.Location = new System.Drawing.Point(1094, 2);
            this.picBoxMinimizeWazzaapp.Name = "picBoxMinimizeWazzaapp";
            this.picBoxMinimizeWazzaapp.Size = new System.Drawing.Size(32, 31);
            this.picBoxMinimizeWazzaapp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMinimizeWazzaapp.TabIndex = 3;
            this.picBoxMinimizeWazzaapp.TabStop = false;
            // 
            // picBoxExitWazzaapp
            // 
            this.picBoxExitWazzaapp.Image = ((System.Drawing.Image)(resources.GetObject("picBoxExitWazzaapp.Image")));
            this.picBoxExitWazzaapp.Location = new System.Drawing.Point(1132, 0);
            this.picBoxExitWazzaapp.Name = "picBoxExitWazzaapp";
            this.picBoxExitWazzaapp.Size = new System.Drawing.Size(34, 30);
            this.picBoxExitWazzaapp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxExitWazzaapp.TabIndex = 2;
            this.picBoxExitWazzaapp.TabStop = false;
            // 
            // lblWazzaapp
            // 
            this.lblWazzaapp.AutoSize = true;
            this.lblWazzaapp.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWazzaapp.ForeColor = System.Drawing.Color.White;
            this.lblWazzaapp.Location = new System.Drawing.Point(60, 5);
            this.lblWazzaapp.Name = "lblWazzaapp";
            this.lblWazzaapp.Size = new System.Drawing.Size(102, 25);
            this.lblWazzaapp.TabIndex = 1;
            this.lblWazzaapp.Text = "Wazzaapp";
            // 
            // picBoxIconWazzaap
            // 
            this.picBoxIconWazzaap.Image = ((System.Drawing.Image)(resources.GetObject("picBoxIconWazzaap.Image")));
            this.picBoxIconWazzaap.Location = new System.Drawing.Point(11, 2);
            this.picBoxIconWazzaap.Name = "picBoxIconWazzaap";
            this.picBoxIconWazzaap.Size = new System.Drawing.Size(43, 28);
            this.picBoxIconWazzaap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxIconWazzaap.TabIndex = 0;
            this.picBoxIconWazzaap.TabStop = false;
            // 
            // picBoxPhoto
            // 
            this.picBoxPhoto.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPhoto.Image")));
            this.picBoxPhoto.Location = new System.Drawing.Point(60, 85);
            this.picBoxPhoto.Name = "picBoxPhoto";
            this.picBoxPhoto.Size = new System.Drawing.Size(144, 128);
            this.picBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPhoto.TabIndex = 2;
            this.picBoxPhoto.TabStop = false;
            this.picBoxPhoto.Click += new System.EventHandler(this.picBoxPhoto_Click);
            // 
            // btnChangePhoto
            // 
            this.btnChangePhoto.BackColor = System.Drawing.Color.SteelBlue;
            this.btnChangePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePhoto.ForeColor = System.Drawing.Color.White;
            this.btnChangePhoto.Location = new System.Drawing.Point(60, 233);
            this.btnChangePhoto.Name = "btnChangePhoto";
            this.btnChangePhoto.Size = new System.Drawing.Size(144, 33);
            this.btnChangePhoto.TabIndex = 3;
            this.btnChangePhoto.Text = "Alterar foto de perfil";
            this.btnChangePhoto.UseVisualStyleBackColor = false;
            this.btnChangePhoto.Click += new System.EventHandler(this.btnChangePhoto_Click);
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.BackColor = System.Drawing.Color.LightGray;
            this.txtBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxUsername.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxUsername.Location = new System.Drawing.Point(259, 103);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.ReadOnly = true;
            this.txtBoxUsername.Size = new System.Drawing.Size(190, 28);
            this.txtBoxUsername.TabIndex = 12;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.Color.DimGray;
            this.lblUsername.Location = new System.Drawing.Point(259, 85);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 15);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Username";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.BackColor = System.Drawing.Color.LightGray;
            this.txtBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNome.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxNome.Location = new System.Drawing.Point(259, 165);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.ReadOnly = true;
            this.txtBoxNome.Size = new System.Drawing.Size(190, 28);
            this.txtBoxNome.TabIndex = 14;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.DimGray;
            this.lblNome.Location = new System.Drawing.Point(259, 147);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome";
            // 
            // txtBoxBio
            // 
            this.txtBoxBio.BackColor = System.Drawing.Color.LightGray;
            this.txtBoxBio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxBio.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxBio.Location = new System.Drawing.Point(60, 321);
            this.txtBoxBio.Name = "txtBoxBio";
            this.txtBoxBio.ReadOnly = true;
            this.txtBoxBio.Size = new System.Drawing.Size(389, 28);
            this.txtBoxBio.TabIndex = 16;
            // 
            // lblBio
            // 
            this.lblBio.AutoSize = true;
            this.lblBio.ForeColor = System.Drawing.Color.DimGray;
            this.lblBio.Location = new System.Drawing.Point(60, 303);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(24, 15);
            this.lblBio.TabIndex = 15;
            this.lblBio.Text = "Bio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(259, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Status";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxStatus.Enabled = false;
            this.comboBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxStatus.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Online",
            "Ausente",
            "Ocupado",
            "Offline"});
            this.comboBoxStatus.Location = new System.Drawing.Point(259, 235);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(190, 28);
            this.comboBoxStatus.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox1.Location = new System.Drawing.Point(60, 387);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 19);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Editar Informações";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(352, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 33);
            this.button1.TabIndex = 20;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 429);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxBio);
            this.Controls.Add(this.lblBio);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnChangePhoto);
            this.Controls.Add(this.picBoxPhoto);
            this.Controls.Add(this.pnlDragProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUserProfile";
            this.Text = "FrmUserProfile";
            this.pnlDragProfile.ResumeLayout(false);
            this.pnlDragProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizeWazzaapp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExitWazzaapp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIconWazzaap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlDragProfile;
        private PictureBox picBoxMinimizeWazzaapp;
        private PictureBox picBoxExitWazzaapp;
        private Label lblWazzaapp;
        private PictureBox picBoxIconWazzaap;
        private PictureBox pictureBox1;
        private PictureBox picBoxPhoto;
        private Button btnChangePhoto;
        private TextBox txtBoxUsername;
        private Label lblUsername;
        private TextBox txtBoxNome;
        private Label lblNome;
        private TextBox txtBoxBio;
        private Label lblBio;
        private Label label1;
        private ComboBox comboBoxStatus;
        private CheckBox checkBox1;
        private Button button1;
    }
}