namespace Client01
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnFacebook = new System.Windows.Forms.Button();
            this.btnGooglePlus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtbDisplay.Location = new System.Drawing.Point(2, 1);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(635, 353);
            this.rtbDisplay.TabIndex = 0;
            this.rtbDisplay.Text = "";
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(4, 365);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(500, 59);
            this.rtbMessage.TabIndex = 1;
            this.rtbMessage.Text = "";
            this.rtbMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RtbClientKeyDown);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(510, 363);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(101, 60);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnFacebook
            // 
            this.btnFacebook.Image = ((System.Drawing.Image)(resources.GetObject("btnFacebook.Image")));
            this.btnFacebook.Location = new System.Drawing.Point(615, 369);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Size = new System.Drawing.Size(22, 24);
            this.btnFacebook.TabIndex = 3;
            this.btnFacebook.UseVisualStyleBackColor = true;
            this.btnFacebook.Click += new System.EventHandler(this.btnFacebook_Click);
            // 
            // btnGooglePlus
            // 
            this.btnGooglePlus.Image = ((System.Drawing.Image)(resources.GetObject("btnGooglePlus.Image")));
            this.btnGooglePlus.Location = new System.Drawing.Point(615, 399);
            this.btnGooglePlus.Name = "btnGooglePlus";
            this.btnGooglePlus.Size = new System.Drawing.Size(21, 23);
            this.btnGooglePlus.TabIndex = 4;
            this.btnGooglePlus.UseVisualStyleBackColor = true;
            this.btnGooglePlus.Click += new System.EventHandler(this.btnGooglePlus_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 430);
            this.Controls.Add(this.btnGooglePlus);
            this.Controls.Add(this.btnFacebook);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.rtbDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Khung Chat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnFacebook;
        private System.Windows.Forms.Button btnGooglePlus;
    }
}

