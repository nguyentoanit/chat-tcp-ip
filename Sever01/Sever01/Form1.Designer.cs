namespace ServerApp
{
    partial class btnOpen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnOpen));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNumberOfConnections = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtbServer = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFacebook = new System.Windows.Forms.Button();
            this.btnGooglePlus = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblNumberOfConnections});
            this.statusStrip1.Location = new System.Drawing.Point(0, 259);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(621, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(123, 17);
            this.toolStripStatusLabel1.Text = "Số người đang kết nối";
            // 
            // lblNumberOfConnections
            // 
            this.lblNumberOfConnections.Name = "lblNumberOfConnections";
            this.lblNumberOfConnections.Size = new System.Drawing.Size(13, 17);
            this.lblNumberOfConnections.Text = "0";
            // 
            // rtbServer
            // 
            this.rtbServer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rtbServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbServer.Location = new System.Drawing.Point(0, 0);
            this.rtbServer.Name = "rtbServer";
            this.rtbServer.Size = new System.Drawing.Size(621, 259);
            this.rtbServer.TabIndex = 1;
            this.rtbServer.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Support";
            // 
            // btnFacebook
            // 
            this.btnFacebook.Image = ((System.Drawing.Image)(resources.GetObject("btnFacebook.Image")));
            this.btnFacebook.Location = new System.Drawing.Point(544, 259);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Size = new System.Drawing.Size(22, 21);
            this.btnFacebook.TabIndex = 3;
            this.btnFacebook.UseVisualStyleBackColor = true;
            this.btnFacebook.Click += new System.EventHandler(this.btnFacebook_Click);
            // 
            // btnGooglePlus
            // 
            this.btnGooglePlus.Image = ((System.Drawing.Image)(resources.GetObject("btnGooglePlus.Image")));
            this.btnGooglePlus.Location = new System.Drawing.Point(569, 259);
            this.btnGooglePlus.Name = "btnGooglePlus";
            this.btnGooglePlus.Size = new System.Drawing.Size(24, 20);
            this.btnGooglePlus.TabIndex = 4;
            this.btnGooglePlus.UseVisualStyleBackColor = true;
            this.btnGooglePlus.Click += new System.EventHandler(this.btnGooglePlus_Click);
            // 
            // btnOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 281);
            this.Controls.Add(this.btnGooglePlus);
            this.Controls.Add(this.btnFacebook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbServer);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "btnOpen";
            this.Text = "Server";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblNumberOfConnections;
        private System.Windows.Forms.RichTextBox rtbServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFacebook;
        private System.Windows.Forms.Button btnGooglePlus;
    }
}