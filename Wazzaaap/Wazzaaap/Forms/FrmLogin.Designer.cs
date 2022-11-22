namespace Wazzaaap.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnlLoginHeader = new System.Windows.Forms.Panel();
            this.pnlLoginSide = new System.Windows.Forms.Panel();
            this.pnlLoginMain = new System.Windows.Forms.Panel();
            this.lblLoginHeader = new System.Windows.Forms.Label();
            this.picBoxUserNameLogo = new System.Windows.Forms.PictureBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pnlLoginElements = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.picBoxPassLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.picBoxCompanyLogo = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblCreateAcc = new System.Windows.Forms.Label();
            this.pnlLoginHeader.SuspendLayout();
            this.pnlLoginSide.SuspendLayout();
            this.pnlLoginMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUserNameLogo)).BeginInit();
            this.pnlLoginElements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCompanyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLoginHeader
            // 
            this.pnlLoginHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.pnlLoginHeader.Controls.Add(this.pictureBox1);
            this.pnlLoginHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLoginHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginHeader.Name = "pnlLoginHeader";
            this.pnlLoginHeader.Size = new System.Drawing.Size(1092, 32);
            this.pnlLoginHeader.TabIndex = 0;
            // 
            // pnlLoginSide
            // 
            this.pnlLoginSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.pnlLoginSide.Controls.Add(this.picBoxCompanyLogo);
            this.pnlLoginSide.Controls.Add(this.lblCompanyName);
            this.pnlLoginSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLoginSide.Location = new System.Drawing.Point(0, 32);
            this.pnlLoginSide.Name = "pnlLoginSide";
            this.pnlLoginSide.Size = new System.Drawing.Size(243, 490);
            this.pnlLoginSide.TabIndex = 1;
            this.pnlLoginSide.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLoginSide_Paint);
            // 
            // pnlLoginMain
            // 
            this.pnlLoginMain.Controls.Add(this.lblCreateAcc);
            this.pnlLoginMain.Controls.Add(this.btnLogin);
            this.pnlLoginMain.Controls.Add(this.pnlLoginElements);
            this.pnlLoginMain.Controls.Add(this.lblLoginHeader);
            this.pnlLoginMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoginMain.Location = new System.Drawing.Point(243, 32);
            this.pnlLoginMain.Name = "pnlLoginMain";
            this.pnlLoginMain.Size = new System.Drawing.Size(849, 490);
            this.pnlLoginMain.TabIndex = 2;
            // 
            // lblLoginHeader
            // 
            this.lblLoginHeader.AutoSize = true;
            this.lblLoginHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginHeader.Location = new System.Drawing.Point(319, 31);
            this.lblLoginHeader.Name = "lblLoginHeader";
            this.lblLoginHeader.Size = new System.Drawing.Size(84, 37);
            this.lblLoginHeader.TabIndex = 0;
            this.lblLoginHeader.Text = "Login";
            // 
            // picBoxUserNameLogo
            // 
            this.picBoxUserNameLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxUserNameLogo.Image")));
            this.picBoxUserNameLogo.Location = new System.Drawing.Point(16, 21);
            this.picBoxUserNameLogo.Name = "picBoxUserNameLogo";
            this.picBoxUserNameLogo.Size = new System.Drawing.Size(41, 38);
            this.picBoxUserNameLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxUserNameLogo.TabIndex = 0;
            this.picBoxUserNameLogo.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Location = new System.Drawing.Point(73, 36);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(235, 16);
            this.txtUserName.TabIndex = 2;
            // 
            // pnlLoginElements
            // 
            this.pnlLoginElements.Controls.Add(this.txtPassword);
            this.pnlLoginElements.Controls.Add(this.picBoxPassLogo);
            this.pnlLoginElements.Controls.Add(this.txtUserName);
            this.pnlLoginElements.Controls.Add(this.picBoxUserNameLogo);
            this.pnlLoginElements.Location = new System.Drawing.Point(167, 111);
            this.pnlLoginElements.Name = "pnlLoginElements";
            this.pnlLoginElements.Size = new System.Drawing.Size(363, 156);
            this.pnlLoginElements.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(73, 91);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(235, 16);
            this.txtPassword.TabIndex = 4;
            // 
            // picBoxPassLogo
            // 
            this.picBoxPassLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPassLogo.Image")));
            this.picBoxPassLogo.Location = new System.Drawing.Point(16, 76);
            this.picBoxPassLogo.Name = "picBoxPassLogo";
            this.picBoxPassLogo.Size = new System.Drawing.Size(41, 38);
            this.picBoxPassLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPassLogo.TabIndex = 3;
            this.picBoxPassLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1063, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCompanyName.Location = new System.Drawing.Point(60, 57);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(114, 28);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "WAZZAAPP";
            // 
            // picBoxCompanyLogo
            // 
            this.picBoxCompanyLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCompanyLogo.Image")));
            this.picBoxCompanyLogo.Location = new System.Drawing.Point(51, 122);
            this.picBoxCompanyLogo.Name = "picBoxCompanyLogo";
            this.picBoxCompanyLogo.Size = new System.Drawing.Size(134, 103);
            this.picBoxCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxCompanyLogo.TabIndex = 1;
            this.picBoxCompanyLogo.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(279, 303);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 37);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblCreateAcc
            // 
            this.lblCreateAcc.AutoSize = true;
            this.lblCreateAcc.Location = new System.Drawing.Point(303, 359);
            this.lblCreateAcc.Name = "lblCreateAcc";
            this.lblCreateAcc.Size = new System.Drawing.Size(112, 15);
            this.lblCreateAcc.TabIndex = 3;
            this.lblCreateAcc.Text = "Create new account";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1092, 522);
            this.Controls.Add(this.pnlLoginMain);
            this.Controls.Add(this.pnlLoginSide);
            this.Controls.Add(this.pnlLoginHeader);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlLoginHeader.ResumeLayout(false);
            this.pnlLoginSide.ResumeLayout(false);
            this.pnlLoginSide.PerformLayout();
            this.pnlLoginMain.ResumeLayout(false);
            this.pnlLoginMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUserNameLogo)).EndInit();
            this.pnlLoginElements.ResumeLayout(false);
            this.pnlLoginElements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCompanyLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlLoginHeader;
        private Panel pnlLoginSide;
        private Panel pnlLoginMain;
        private Label lblLoginHeader;
        private PictureBox pictureBox1;
        private PictureBox picBoxCompanyLogo;
        private Label lblCompanyName;
        private Label lblCreateAcc;
        private Button btnLogin;
        private Panel pnlLoginElements;
        private TextBox txtPassword;
        private PictureBox picBoxPassLogo;
        private TextBox txtUserName;
        private PictureBox picBoxUserNameLogo;
    }
}