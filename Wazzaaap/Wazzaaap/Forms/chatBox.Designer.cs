namespace Wazzaaap.Forms
{
    partial class chatBox
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chatBox));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlChatBottomLine = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PicBottom = new System.Windows.Forms.PictureBox();
            this.bubble1 = new Wazzaaap.Forms.bubble();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pnlChatBottomLine);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 568);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 68);
            this.panel1.TabIndex = 0;
            // 
            // pnlChatBottomLine
            // 
            this.pnlChatBottomLine.BackColor = System.Drawing.Color.White;
            this.pnlChatBottomLine.Location = new System.Drawing.Point(39, 53);
            this.pnlChatBottomLine.Name = "pnlChatBottomLine";
            this.pnlChatBottomLine.Size = new System.Drawing.Size(700, 5);
            this.pnlChatBottomLine.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.AccessibleDescription = "";
            this.richTextBox1.AccessibleName = "";
            this.richTextBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Font = new System.Drawing.Font("Dubai Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(39, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(698, 35);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Tag = "";
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            this.richTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(762, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.PicBottom);
            this.panel2.Controls.Add(this.bubble1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 568);
            this.panel2.TabIndex = 1;
            // 
            // PicBottom
            // 
            this.PicBottom.BackColor = System.Drawing.Color.Transparent;
            this.PicBottom.Location = new System.Drawing.Point(27, 118);
            this.PicBottom.Name = "PicBottom";
            this.PicBottom.Size = new System.Drawing.Size(142, 53);
            this.PicBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBottom.TabIndex = 4;
            this.PicBottom.TabStop = false;
            // 
            // bubble1
            // 
            this.bubble1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bubble1.BackColor = System.Drawing.Color.SteelBlue;
            this.bubble1.Location = new System.Drawing.Point(27, 20);
            this.bubble1.Name = "bubble1";
            this.bubble1.Size = new System.Drawing.Size(532, 82);
            this.bubble1.TabIndex = 0;
            // 
            // chatBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "chatBox";
            this.Size = new System.Drawing.Size(862, 636);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBottom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private RichTextBox richTextBox1;
        private bubble bubble1;
        private PictureBox PicBottom;
        private Panel pnlChatBottomLine;
    }
}
