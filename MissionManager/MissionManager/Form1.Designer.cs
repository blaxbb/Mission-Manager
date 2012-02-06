namespace MissionManager
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
            this.Container = new System.Windows.Forms.SplitContainer();
            this.Container2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.personellTab = new System.Windows.Forms.TabPage();
            this.mapTab = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.charCountLabel = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Container)).BeginInit();
            this.Container.Panel1.SuspendLayout();
            this.Container.Panel2.SuspendLayout();
            this.Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Container2)).BeginInit();
            this.Container2.Panel1.SuspendLayout();
            this.Container2.Panel2.SuspendLayout();
            this.Container2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(0, 0);
            this.Container.Name = "Container";
            // 
            // Container.Panel1
            // 
            this.Container.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // Container.Panel2
            // 
            this.Container.Panel2.Controls.Add(this.Container2);
            this.Container.Size = new System.Drawing.Size(759, 593);
            this.Container.SplitterDistance = 251;
            this.Container.TabIndex = 0;
            // 
            // Container2
            // 
            this.Container2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container2.Location = new System.Drawing.Point(0, 0);
            this.Container2.Name = "Container2";
            this.Container2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Container2.Panel1
            // 
            this.Container2.Panel1.Controls.Add(this.tabControl1);
            // 
            // Container2.Panel2
            // 
            this.Container2.Panel2.Controls.Add(this.sendButton);
            this.Container2.Panel2.Controls.Add(this.charCountLabel);
            this.Container2.Panel2.Controls.Add(this.comboBox1);
            this.Container2.Panel2.Controls.Add(this.messageTextBox);
            this.Container2.Size = new System.Drawing.Size(504, 593);
            this.Container2.SplitterDistance = 412;
            this.Container2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.personellTab);
            this.tabControl1.Controls.Add(this.mapTab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(504, 412);
            this.tabControl1.TabIndex = 0;
            // 
            // personellTab
            // 
            this.personellTab.Location = new System.Drawing.Point(4, 22);
            this.personellTab.Name = "personellTab";
            this.personellTab.Padding = new System.Windows.Forms.Padding(3);
            this.personellTab.Size = new System.Drawing.Size(496, 386);
            this.personellTab.TabIndex = 0;
            this.personellTab.Text = "Personnel";
            this.personellTab.UseVisualStyleBackColor = true;
            // 
            // mapTab
            // 
            this.mapTab.Location = new System.Drawing.Point(4, 22);
            this.mapTab.Name = "mapTab";
            this.mapTab.Padding = new System.Windows.Forms.Padding(3);
            this.mapTab.Size = new System.Drawing.Size(496, 386);
            this.mapTab.TabIndex = 1;
            this.mapTab.Text = "Map";
            this.mapTab.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(496, 386);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Objectives";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(251, 593);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // messageTextBox
            // 
            this.messageTextBox.AcceptsReturn = true;
            this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.messageTextBox.Location = new System.Drawing.Point(4, 4);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(266, 161);
            this.messageTextBox.TabIndex = 0;
            this.messageTextBox.TextChanged += new System.EventHandler(this.messageTextBox_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "test",
            "test2",
            "test3"});
            this.comboBox1.Location = new System.Drawing.Point(276, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Recipients";
            // 
            // charCountLabel
            // 
            this.charCountLabel.AutoSize = true;
            this.charCountLabel.Location = new System.Drawing.Point(276, 32);
            this.charCountLabel.Name = "charCountLabel";
            this.charCountLabel.Size = new System.Drawing.Size(96, 13);
            this.charCountLabel.TabIndex = 3;
            this.charCountLabel.Text = "0 / 140 Characters";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(279, 48);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(213, 117);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "Send Message";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 593);
            this.Controls.Add(this.Container);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Container.Panel1.ResumeLayout(false);
            this.Container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Container)).EndInit();
            this.Container.ResumeLayout(false);
            this.Container2.Panel1.ResumeLayout(false);
            this.Container2.Panel2.ResumeLayout(false);
            this.Container2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Container2)).EndInit();
            this.Container2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Container;
        private System.Windows.Forms.SplitContainer Container2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage personellTab;
        private System.Windows.Forms.TabPage mapTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label charCountLabel;
        private System.Windows.Forms.Button sendButton;
    }
}

