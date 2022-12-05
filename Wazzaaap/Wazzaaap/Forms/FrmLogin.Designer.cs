namespace Wazzaaap.Forms
{
    partial class frmLogin
    {

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.picBoxIconLogin = new System.Windows.Forms.PictureBox();
            this.picBoxUsername = new System.Windows.Forms.PictureBox();
            this.picboxPassword = new System.Windows.Forms.PictureBox();
            this.picBoxExitLogin = new System.Windows.Forms.PictureBox();
            this.linkLblCreateAcc = new System.Windows.Forms.LinkLabel();
            this.textBoxUserLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassLogin = new System.Windows.Forms.TextBox();
            this.checkBoxShowPassLog = new System.Windows.Forms.CheckBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.picBoxMinimizeLogin = new System.Windows.Forms.PictureBox();
            this.lblPassLogin = new System.Windows.Forms.Label();
            this.lblUsernameLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIconLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExitLogin)).BeginInit();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizeLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(87, 301);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(118, 33);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(116, 111);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(63, 25);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.lblCreateAcc_Click);
            // 
            // picBoxIconLogin
            // 
            this.picBoxIconLogin.Image = ((System.Drawing.Image)(resources.GetObject("picBoxIconLogin.Image")));
            this.picBoxIconLogin.Location = new System.Drawing.Point(116, 24);
            this.picBoxIconLogin.Name = "picBoxIconLogin";
            this.picBoxIconLogin.Size = new System.Drawing.Size(59, 58);
            this.picBoxIconLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxIconLogin.TabIndex = 4;
            this.picBoxIconLogin.TabStop = false;
            // 
            // picBoxUsername
            // 
            this.picBoxUsername.Image = ((System.Drawing.Image)(resources.GetObject("picBoxUsername.Image")));
            this.picBoxUsername.Location = new System.Drawing.Point(31, 160);
            this.picBoxUsername.Name = "picBoxUsername";
            this.picBoxUsername.Size = new System.Drawing.Size(32, 29);
            this.picBoxUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxUsername.TabIndex = 5;
            this.picBoxUsername.TabStop = false;
            // 
            // picboxPassword
            // 
            this.picboxPassword.Image = ((System.Drawing.Image)(resources.GetObject("picboxPassword.Image")));
            this.picboxPassword.Location = new System.Drawing.Point(31, 200);
            this.picboxPassword.Name = "picboxPassword";
            this.picboxPassword.Size = new System.Drawing.Size(32, 33);
            this.picboxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxPassword.TabIndex = 6;
            this.picboxPassword.TabStop = false;
            // 
            // picBoxExitLogin
            // 
            this.picBoxExitLogin.BackColor = System.Drawing.Color.White;
            this.picBoxExitLogin.Image = ((System.Drawing.Image)(resources.GetObject("picBoxExitLogin.Image")));
            this.picBoxExitLogin.Location = new System.Drawing.Point(255, 3);
            this.picBoxExitLogin.Name = "picBoxExitLogin";
            this.picBoxExitLogin.Size = new System.Drawing.Size(30, 26);
            this.picBoxExitLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxExitLogin.TabIndex = 7;
            this.picBoxExitLogin.TabStop = false;
            this.picBoxExitLogin.Click += new System.EventHandler(this.picBoxExitLogin_Click);
            // 
            // linkLblCreateAcc
            // 
            this.linkLblCreateAcc.AutoSize = true;
            this.linkLblCreateAcc.LinkColor = System.Drawing.Color.Black;
            this.linkLblCreateAcc.Location = new System.Drawing.Point(101, 337);
            this.linkLblCreateAcc.Name = "linkLblCreateAcc";
            this.linkLblCreateAcc.Size = new System.Drawing.Size(89, 15);
            this.linkLblCreateAcc.TabIndex = 8;
            this.linkLblCreateAcc.TabStop = true;
            this.linkLblCreateAcc.Text = "Create Account";
            this.linkLblCreateAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblCreateAcc_LinkClicked);
            // 
            // textBoxUserLogin
            // 
            this.textBoxUserLogin.BackColor = System.Drawing.Color.LightGray;
            this.textBoxUserLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserLogin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUserLogin.Location = new System.Drawing.Point(69, 166);
            this.textBoxUserLogin.Name = "textBoxUserLogin";
            this.textBoxUserLogin.Size = new System.Drawing.Size(190, 22);
            this.textBoxUserLogin.TabIndex = 10;
            this.textBoxUserLogin.TextChanged += new System.EventHandler(this.textBoxUserLogin_TextChanged);
            // 
            // textBoxPassLogin
            // 
            this.textBoxPassLogin.BackColor = System.Drawing.Color.LightGray;
            this.textBoxPassLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassLogin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassLogin.Location = new System.Drawing.Point(69, 210);
            this.textBoxPassLogin.Name = "textBoxPassLogin";
            this.textBoxPassLogin.PasswordChar = '*';
            this.textBoxPassLogin.Size = new System.Drawing.Size(190, 22);
            this.textBoxPassLogin.TabIndex = 11;
            // 
            // checkBoxShowPassLog
            // 
            this.checkBoxShowPassLog.AutoSize = true;
            this.checkBoxShowPassLog.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxShowPassLog.ForeColor = System.Drawing.Color.Black;
            this.checkBoxShowPassLog.Location = new System.Drawing.Point(152, 238);
            this.checkBoxShowPassLog.Name = "checkBoxShowPassLog";
            this.checkBoxShowPassLog.Size = new System.Drawing.Size(107, 17);
            this.checkBoxShowPassLog.TabIndex = 12;
            this.checkBoxShowPassLog.Text = "Show Password";
            this.checkBoxShowPassLog.UseVisualStyleBackColor = true;
            this.checkBoxShowPassLog.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.picBoxMinimizeLogin);
            this.pnlLogin.Controls.Add(this.lblPassLogin);
            this.pnlLogin.Controls.Add(this.lblUsernameLogin);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(290, 409);
            this.pnlLogin.TabIndex = 13;
            this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
            // 
            // picBoxMinimizeLogin
            // 
            this.picBoxMinimizeLogin.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMinimizeLogin.Image")));
            this.picBoxMinimizeLogin.Location = new System.Drawing.Point(221, 3);
            this.picBoxMinimizeLogin.Name = "picBoxMinimizeLogin";
            this.picBoxMinimizeLogin.Size = new System.Drawing.Size(28, 26);
            this.picBoxMinimizeLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMinimizeLogin.TabIndex = 2;
            this.picBoxMinimizeLogin.TabStop = false;
            this.picBoxMinimizeLogin.Click += new System.EventHandler(this.picBoxMinimizeLogin_Click);
            // 
            // lblPassLogin
            // 
            this.lblPassLogin.AutoSize = true;
            this.lblPassLogin.BackColor = System.Drawing.Color.White;
            this.lblPassLogin.ForeColor = System.Drawing.Color.DimGray;
            this.lblPassLogin.Location = new System.Drawing.Point(69, 192);
            this.lblPassLogin.Name = "lblPassLogin";
            this.lblPassLogin.Size = new System.Drawing.Size(57, 15);
            this.lblPassLogin.TabIndex = 1;
            this.lblPassLogin.Text = "Password";
            // 
            // lblUsernameLogin
            // 
            this.lblUsernameLogin.AutoSize = true;
            this.lblUsernameLogin.ForeColor = System.Drawing.Color.DimGray;
            this.lblUsernameLogin.Location = new System.Drawing.Point(69, 148);
            this.lblUsernameLogin.Name = "lblUsernameLogin";
            this.lblUsernameLogin.Size = new System.Drawing.Size(60, 15);
            this.lblUsernameLogin.TabIndex = 0;
            this.lblUsernameLogin.Text = "Username";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(290, 409);
            this.Controls.Add(this.checkBoxShowPassLog);
            this.Controls.Add(this.textBoxPassLogin);
            this.Controls.Add(this.textBoxUserLogin);
            this.Controls.Add(this.linkLblCreateAcc);
            this.Controls.Add(this.picBoxExitLogin);
            this.Controls.Add(this.picboxPassword);
            this.Controls.Add(this.picBoxUsername);
            this.Controls.Add(this.picBoxIconLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnlLogin);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wazzaapp";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIconLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExitLogin)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizeLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogin;
        private Label lblLogin;
        private PictureBox picBoxIconLogin;
        private PictureBox picBoxUsername;
        private PictureBox picboxPassword;
        private PictureBox picBoxExitLogin;
        private LinkLabel linkLblCreateAcc;
        private TextBox textBoxUserLogin;
        private TextBox textBoxPassLogin;
        private CheckBox checkBoxShowPassLog;
        private Panel pnlLogin;
        private Label lblPassLogin;
        private Label lblUsernameLogin;
        private PictureBox picBoxMinimizeLogin;
    }
}