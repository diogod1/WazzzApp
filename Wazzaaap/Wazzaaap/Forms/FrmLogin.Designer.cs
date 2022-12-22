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
            this.picBoxPassword = new System.Windows.Forms.PictureBox();
            this.picBoxExitLogin = new System.Windows.Forms.PictureBox();
            this.linkLblCreateAcc = new System.Windows.Forms.LinkLabel();
            this.txtBoxUserLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassLogin = new System.Windows.Forms.TextBox();
            this.checkBoxShowPassLog = new System.Windows.Forms.CheckBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.picBoxMinimizeLogin = new System.Windows.Forms.PictureBox();
            this.lblPassLogin = new System.Windows.Forms.Label();
            this.lblUsernameLogin = new System.Windows.Forms.Label();
            this.pnlDragLogin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIconLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassword)).BeginInit();
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
            
            this.btnLogin.Location = new System.Drawing.Point(112, 329);
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
            this.lblLogin.Location = new System.Drawing.Point(137, 150);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(63, 25);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.lblCreateAcc_Click);
            // 
            // picBoxIconLogin
            // 
            this.picBoxIconLogin.Image = ((System.Drawing.Image)(resources.GetObject("picBoxIconLogin.Image")));
            this.picBoxIconLogin.Location = new System.Drawing.Point(141, 72);
            this.picBoxIconLogin.Name = "picBoxIconLogin";
            this.picBoxIconLogin.Size = new System.Drawing.Size(59, 58);
            this.picBoxIconLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxIconLogin.TabIndex = 4;
            this.picBoxIconLogin.TabStop = false;
            // 
            // picBoxUsername
            // 
            this.picBoxUsername.Image = ((System.Drawing.Image)(resources.GetObject("picBoxUsername.Image")));
            this.picBoxUsername.Location = new System.Drawing.Point(48, 203);
            this.picBoxUsername.Name = "picBoxUsername";
            this.picBoxUsername.Size = new System.Drawing.Size(32, 29);
            this.picBoxUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxUsername.TabIndex = 5;
            this.picBoxUsername.TabStop = false;
            // 
            // picBoxPassword
            // 
            this.picBoxPassword.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPassword.Image")));
            this.picBoxPassword.Location = new System.Drawing.Point(48, 248);
            this.picBoxPassword.Name = "picBoxPassword";
            this.picBoxPassword.Size = new System.Drawing.Size(32, 33);
            this.picBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPassword.TabIndex = 6;
            this.picBoxPassword.TabStop = false;
            // 
            // picBoxExitLogin
            // 
            this.picBoxExitLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.picBoxExitLogin.Image = ((System.Drawing.Image)(resources.GetObject("picBoxExitLogin.Image")));
            this.picBoxExitLogin.Location = new System.Drawing.Point(306, 3);
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
            this.linkLblCreateAcc.Location = new System.Drawing.Point(125, 365);
            this.linkLblCreateAcc.Name = "linkLblCreateAcc";
            this.linkLblCreateAcc.Size = new System.Drawing.Size(89, 15);
            this.linkLblCreateAcc.TabIndex = 8;
            this.linkLblCreateAcc.TabStop = true;
            this.linkLblCreateAcc.Text = "Create Account";
            this.linkLblCreateAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblCreateAcc_LinkClicked);
            // 
            // txtBoxUserLogin
            // 
            this.txtBoxUserLogin.BackColor = System.Drawing.Color.LightGray;
            this.txtBoxUserLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxUserLogin.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxUserLogin.Location = new System.Drawing.Point(86, 204);
            this.txtBoxUserLogin.Name = "txtBoxUserLogin";
            this.txtBoxUserLogin.Size = new System.Drawing.Size(190, 28);
            this.txtBoxUserLogin.TabIndex = 10;
            this.txtBoxUserLogin.TextChanged += new System.EventHandler(this.textBoxUserLogin_TextChanged);
            // 
            // textBoxPassLogin
            // 
            this.textBoxPassLogin.BackColor = System.Drawing.Color.LightGray;
            this.textBoxPassLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassLogin.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassLogin.Location = new System.Drawing.Point(86, 253);
            this.textBoxPassLogin.Name = "textBoxPassLogin";
            this.textBoxPassLogin.PasswordChar = '*';
            this.textBoxPassLogin.Size = new System.Drawing.Size(190, 28);
            this.textBoxPassLogin.TabIndex = 11;
            this.textBoxPassLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassLogin_KeyPress);
            // 
            // checkBoxShowPassLog
            // 
            this.checkBoxShowPassLog.AutoSize = true;
            this.checkBoxShowPassLog.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxShowPassLog.ForeColor = System.Drawing.Color.Black;
            this.checkBoxShowPassLog.Location = new System.Drawing.Point(169, 287);
            this.checkBoxShowPassLog.Name = "checkBoxShowPassLog";
            this.checkBoxShowPassLog.Size = new System.Drawing.Size(107, 17);
            this.checkBoxShowPassLog.TabIndex = 12;
            this.checkBoxShowPassLog.Text = "Show Password";
            this.checkBoxShowPassLog.UseVisualStyleBackColor = true;
            this.checkBoxShowPassLog.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.checkBoxShowPassLog);
            this.pnlLogin.Controls.Add(this.picBoxMinimizeLogin);
            this.pnlLogin.Controls.Add(this.picBoxPassword);
            this.pnlLogin.Controls.Add(this.textBoxPassLogin);
            this.pnlLogin.Controls.Add(this.lblPassLogin);
            this.pnlLogin.Controls.Add(this.linkLblCreateAcc);
            this.pnlLogin.Controls.Add(this.picBoxUsername);
            this.pnlLogin.Controls.Add(this.txtBoxUserLogin);
            this.pnlLogin.Controls.Add(this.lblUsernameLogin);
            this.pnlLogin.Controls.Add(this.picBoxExitLogin);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.picBoxIconLogin);
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Controls.Add(this.pnlDragLogin);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(339, 444);
            this.pnlLogin.TabIndex = 13;
            this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
            // 
            // picBoxMinimizeLogin
            // 
            this.picBoxMinimizeLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.picBoxMinimizeLogin.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMinimizeLogin.Image")));
            this.picBoxMinimizeLogin.Location = new System.Drawing.Point(272, 3);
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
            this.lblPassLogin.Location = new System.Drawing.Point(86, 235);
            this.lblPassLogin.Name = "lblPassLogin";
            this.lblPassLogin.Size = new System.Drawing.Size(57, 15);
            this.lblPassLogin.TabIndex = 1;
            this.lblPassLogin.Text = "Password";
            // 
            // lblUsernameLogin
            // 
            this.lblUsernameLogin.AutoSize = true;
            this.lblUsernameLogin.ForeColor = System.Drawing.Color.DimGray;
            this.lblUsernameLogin.Location = new System.Drawing.Point(86, 186);
            this.lblUsernameLogin.Name = "lblUsernameLogin";
            this.lblUsernameLogin.Size = new System.Drawing.Size(60, 15);
            this.lblUsernameLogin.TabIndex = 0;
            this.lblUsernameLogin.Text = "Username";
            this.lblUsernameLogin.Click += new System.EventHandler(this.lblUsernameLogin_Click);
            // 
            // pnlDragLogin
            // 
            this.pnlDragLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlDragLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDragLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlDragLogin.Name = "pnlDragLogin";
            this.pnlDragLogin.Size = new System.Drawing.Size(339, 35);
            this.pnlDragLogin.TabIndex = 13;
            this.pnlDragLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDragLogin_Paint);
            this.pnlDragLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.pnlDragLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.pnlDragLogin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(339, 444);
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
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExitLogin)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizeLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnLogin;
        private Label lblLogin;
        private PictureBox picBoxIconLogin;
        private PictureBox picBoxUsername;
        private PictureBox picBoxPassword;
        private PictureBox picBoxExitLogin;
        private LinkLabel linkLblCreateAcc;
        private TextBox txtBoxUserLogin;
        private TextBox textBoxPassLogin;
        private CheckBox checkBoxShowPassLog;
        private Panel pnlLogin;
        private Label lblPassLogin;
        private Label lblUsernameLogin;
        private PictureBox picBoxMinimizeLogin;
        private Panel pnlDragLogin;
    }
}