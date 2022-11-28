namespace Wazzaaap.Forms
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.picBoxIconReg = new System.Windows.Forms.PictureBox();
            this.picBoxExitReg = new System.Windows.Forms.PictureBox();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.picBoxUsername = new System.Windows.Forms.PictureBox();
            this.picBoxPass = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.picBoxPass2 = new System.Windows.Forms.PictureBox();
            this.textBoxUserReg = new System.Windows.Forms.TextBox();
            this.textBoxPassReg = new System.Windows.Forms.TextBox();
            this.textBoxPassReg2 = new System.Windows.Forms.TextBox();
            this.checkBoxShowPassReg = new System.Windows.Forms.CheckBox();
            this.lblRegister = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIconReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExitReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPass2)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxIconReg
            // 
            this.picBoxIconReg.Image = ((System.Drawing.Image)(resources.GetObject("picBoxIconReg.Image")));
            this.picBoxIconReg.Location = new System.Drawing.Point(111, 31);
            this.picBoxIconReg.Name = "picBoxIconReg";
            this.picBoxIconReg.Size = new System.Drawing.Size(59, 61);
            this.picBoxIconReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxIconReg.TabIndex = 0;
            this.picBoxIconReg.TabStop = false;
            // 
            // picBoxExitReg
            // 
            this.picBoxExitReg.Image = ((System.Drawing.Image)(resources.GetObject("picBoxExitReg.Image")));
            this.picBoxExitReg.Location = new System.Drawing.Point(242, 3);
            this.picBoxExitReg.Name = "picBoxExitReg";
            this.picBoxExitReg.Size = new System.Drawing.Size(34, 30);
            this.picBoxExitReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxExitReg.TabIndex = 1;
            this.picBoxExitReg.TabStop = false;
            this.picBoxExitReg.Click += new System.EventHandler(this.picBoxExitReg_Click);
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAcc.ForeColor = System.Drawing.Color.White;
            this.btnCreateAcc.Location = new System.Drawing.Point(83, 322);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(118, 40);
            this.btnCreateAcc.TabIndex = 2;
            this.btnCreateAcc.Text = "Create Account";
            this.btnCreateAcc.UseVisualStyleBackColor = false;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // picBoxUsername
            // 
            this.picBoxUsername.Image = ((System.Drawing.Image)(resources.GetObject("picBoxUsername.Image")));
            this.picBoxUsername.Location = new System.Drawing.Point(23, 151);
            this.picBoxUsername.Name = "picBoxUsername";
            this.picBoxUsername.Size = new System.Drawing.Size(31, 23);
            this.picBoxUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxUsername.TabIndex = 3;
            this.picBoxUsername.TabStop = false;
            // 
            // picBoxPass
            // 
            this.picBoxPass.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPass.Image")));
            this.picBoxPass.Location = new System.Drawing.Point(23, 189);
            this.picBoxPass.Name = "picBoxPass";
            this.picBoxPass.Size = new System.Drawing.Size(31, 23);
            this.picBoxPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPass.TabIndex = 4;
            this.picBoxPass.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(70, 365);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(142, 15);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already have an account?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // picBoxPass2
            // 
            this.picBoxPass2.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPass2.Image")));
            this.picBoxPass2.Location = new System.Drawing.Point(23, 227);
            this.picBoxPass2.Name = "picBoxPass2";
            this.picBoxPass2.Size = new System.Drawing.Size(31, 23);
            this.picBoxPass2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPass2.TabIndex = 6;
            this.picBoxPass2.TabStop = false;
            // 
            // textBoxUserReg
            // 
            this.textBoxUserReg.BackColor = System.Drawing.Color.LightGray;
            this.textBoxUserReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserReg.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUserReg.Location = new System.Drawing.Point(60, 151);
            this.textBoxUserReg.Name = "textBoxUserReg";
            this.textBoxUserReg.Size = new System.Drawing.Size(193, 26);
            this.textBoxUserReg.TabIndex = 7;
            this.textBoxUserReg.TextChanged += new System.EventHandler(this.textBoxUserReg_TextChanged);
            // 
            // textBoxPassReg
            // 
            this.textBoxPassReg.BackColor = System.Drawing.Color.LightGray;
            this.textBoxPassReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassReg.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassReg.Location = new System.Drawing.Point(60, 190);
            this.textBoxPassReg.Name = "textBoxPassReg";
            this.textBoxPassReg.PasswordChar = '*';
            this.textBoxPassReg.Size = new System.Drawing.Size(193, 26);
            this.textBoxPassReg.TabIndex = 8;
            this.textBoxPassReg.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxPassReg2
            // 
            this.textBoxPassReg2.BackColor = System.Drawing.Color.LightGray;
            this.textBoxPassReg2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassReg2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassReg2.Location = new System.Drawing.Point(60, 227);
            this.textBoxPassReg2.Name = "textBoxPassReg2";
            this.textBoxPassReg2.PasswordChar = '*';
            this.textBoxPassReg2.PlaceholderText = "Confirm Password";
            this.textBoxPassReg2.Size = new System.Drawing.Size(193, 26);
            this.textBoxPassReg2.TabIndex = 9;
            this.textBoxPassReg2.TextChanged += new System.EventHandler(this.textBoxPassReg2_TextChanged);
            // 
            // checkBoxShowPassReg
            // 
            this.checkBoxShowPassReg.AutoSize = true;
            this.checkBoxShowPassReg.Location = new System.Drawing.Point(145, 264);
            this.checkBoxShowPassReg.Name = "checkBoxShowPassReg";
            this.checkBoxShowPassReg.Size = new System.Drawing.Size(108, 19);
            this.checkBoxShowPassReg.TabIndex = 10;
            this.checkBoxShowPassReg.Text = "Show Password";
            this.checkBoxShowPassReg.UseVisualStyleBackColor = true;
            this.checkBoxShowPassReg.CheckedChanged += new System.EventHandler(this.checkBoxShowPassReg_CheckedChanged);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegister.Location = new System.Drawing.Point(98, 107);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(83, 25);
            this.lblRegister.TabIndex = 11;
            this.lblRegister.Text = "Register";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 436);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.checkBoxShowPassReg);
            this.Controls.Add(this.textBoxPassReg2);
            this.Controls.Add(this.textBoxPassReg);
            this.Controls.Add(this.textBoxUserReg);
            this.Controls.Add(this.picBoxPass2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.picBoxPass);
            this.Controls.Add(this.picBoxUsername);
            this.Controls.Add(this.btnCreateAcc);
            this.Controls.Add(this.picBoxExitReg);
            this.Controls.Add(this.picBoxIconReg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegister";
            this.Text = "Wazzaapp";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIconReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExitReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPass2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picBoxIconReg;
        private PictureBox picBoxExitReg;
        private Button btnCreateAcc;
        private PictureBox picBoxUsername;
        private PictureBox picBoxPass;
        private LinkLabel linkLabel1;
        private PictureBox picBoxPass2;
        private TextBox textBoxUserReg;
        private TextBox textBoxPassReg;
        private TextBox textBoxPassReg2;
        private CheckBox checkBoxShowPassReg;
        private Label lblRegister;
    }
}