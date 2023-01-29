namespace Wazzaaap.Forms
{
    partial class bubble
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblNomeSender = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(3, 19);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(522, 32);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Click += new System.EventHandler(this.label1_Click);
            this.lblMessage.Resize += new System.EventHandler(this.lblMessage_Resize);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Dubai Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(3, 60);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 21);
            this.lblTime.TabIndex = 1;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblNomeSender
            // 
            this.lblNomeSender.AutoSize = true;
            this.lblNomeSender.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeSender.ForeColor = System.Drawing.Color.White;
            this.lblNomeSender.Location = new System.Drawing.Point(0, 0);
            this.lblNomeSender.Name = "lblNomeSender";
            this.lblNomeSender.Size = new System.Drawing.Size(0, 21);
            this.lblNomeSender.TabIndex = 2;
            this.lblNomeSender.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // bubble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.lblNomeSender);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblMessage);
            this.Name = "bubble";
            this.Size = new System.Drawing.Size(552, 85);
            this.Load += new System.EventHandler(this.bubble_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMessage;
        private Label lblTime;
        private Label lblNomeSender;
    }
}
