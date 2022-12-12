namespace Wazzaaap.Forms
{
    partial class frmError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmError));
            this.lblAuthFailed = new System.Windows.Forms.Label();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.picBoxWarning = new System.Windows.Forms.PictureBox();
            this.lblUserPassWrong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAuthFailed
            // 
            this.lblAuthFailed.AutoSize = true;
            this.lblAuthFailed.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuthFailed.ForeColor = System.Drawing.Color.Red;
            this.lblAuthFailed.Location = new System.Drawing.Point(107, 21);
            this.lblAuthFailed.Name = "lblAuthFailed";
            this.lblAuthFailed.Size = new System.Drawing.Size(221, 30);
            this.lblAuthFailed.TabIndex = 1;
            this.lblAuthFailed.Text = "Authentication Failed !";
            // 
            // btnDismiss
            // 
            this.btnDismiss.BackColor = System.Drawing.Color.LightCoral;
            this.btnDismiss.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDismiss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDismiss.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDismiss.ForeColor = System.Drawing.Color.Black;
            this.btnDismiss.Location = new System.Drawing.Point(0, 126);
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.Size = new System.Drawing.Size(382, 51);
            this.btnDismiss.TabIndex = 2;
            this.btnDismiss.Text = "Dismiss";
            this.btnDismiss.UseVisualStyleBackColor = false;
            this.btnDismiss.Click += new System.EventHandler(this.button1_Click);
            // 
            // picBoxWarning
            // 
            this.picBoxWarning.Image = ((System.Drawing.Image)(resources.GetObject("picBoxWarning.Image")));
            this.picBoxWarning.Location = new System.Drawing.Point(41, 12);
            this.picBoxWarning.Name = "picBoxWarning";
            this.picBoxWarning.Size = new System.Drawing.Size(60, 50);
            this.picBoxWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxWarning.TabIndex = 6;
            this.picBoxWarning.TabStop = false;
            // 
            // lblUserPassWrong
            // 
            this.lblUserPassWrong.AutoSize = true;
            this.lblUserPassWrong.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserPassWrong.ForeColor = System.Drawing.Color.Red;
            this.lblUserPassWrong.Location = new System.Drawing.Point(63, 79);
            this.lblUserPassWrong.Name = "lblUserPassWrong";
            this.lblUserPassWrong.Size = new System.Drawing.Size(265, 21);
            this.lblUserPassWrong.TabIndex = 7;
            this.lblUserPassWrong.Text = "Username or password are incorrect.";
            this.lblUserPassWrong.Click += new System.EventHandler(this.lblUserPassWrong_Click);
            // 
            // frmError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(382, 177);
            this.Controls.Add(this.lblUserPassWrong);
            this.Controls.Add(this.picBoxWarning);
            this.Controls.Add(this.btnDismiss);
            this.Controls.Add(this.lblAuthFailed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmError_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblAuthFailed;
        private Button btnDismiss;
        private PictureBox picBoxWarning;
        private Label lblUserPassWrong;
    }
}