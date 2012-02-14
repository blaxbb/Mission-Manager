namespace MissionManager
{
    partial class Message
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.replyButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.senderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(4, 4);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(66, 13);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "No message";
            // 
            // replyButton
            // 
            this.replyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.replyButton.Location = new System.Drawing.Point(313, 3);
            this.replyButton.Name = "replyButton";
            this.replyButton.Size = new System.Drawing.Size(75, 23);
            this.replyButton.TabIndex = 1;
            this.replyButton.Text = "Reply";
            this.replyButton.UseVisualStyleBackColor = true;
            // 
            // forwardButton
            // 
            this.forwardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.forwardButton.Location = new System.Drawing.Point(232, 3);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(75, 23);
            this.forwardButton.TabIndex = 2;
            this.forwardButton.Text = "Forward";
            this.forwardButton.UseVisualStyleBackColor = true;
            // 
            // senderLabel
            // 
            this.senderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.senderLabel.Location = new System.Drawing.Point(232, 38);
            this.senderLabel.Name = "senderLabel";
            this.senderLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.senderLabel.Size = new System.Drawing.Size(161, 23);
            this.senderLabel.TabIndex = 3;
            this.senderLabel.Text = "sender";
            this.senderLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.senderLabel);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.replyButton);
            this.Controls.Add(this.messageLabel);
            this.Name = "Message";
            this.Size = new System.Drawing.Size(391, 61);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button replyButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Label senderLabel;
    }
}
