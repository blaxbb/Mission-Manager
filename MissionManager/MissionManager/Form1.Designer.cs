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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Container = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Container2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.personellTab = new System.Windows.Forms.TabPage();
            this.personnelToolStrip = new System.Windows.Forms.ToolStrip();
            this.personLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mapTab = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sendButton = new System.Windows.Forms.Button();
            this.charCountLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.newPersonButton = new System.Windows.Forms.ToolStripButton();
            this.openPersonsButton = new System.Windows.Forms.ToolStripButton();
            this.savePersonsButton = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Container)).BeginInit();
            this.Container.Panel1.SuspendLayout();
            this.Container.Panel2.SuspendLayout();
            this.Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Container2)).BeginInit();
            this.Container2.Panel1.SuspendLayout();
            this.Container2.Panel2.SuspendLayout();
            this.Container2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.personellTab.SuspendLayout();
            this.personnelToolStrip.SuspendLayout();
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
            this.personellTab.Controls.Add(this.personnelToolStrip);
            this.personellTab.Controls.Add(this.personLayoutPanel);
            this.personellTab.Location = new System.Drawing.Point(4, 22);
            this.personellTab.Name = "personellTab";
            this.personellTab.Padding = new System.Windows.Forms.Padding(3);
            this.personellTab.Size = new System.Drawing.Size(496, 386);
            this.personellTab.TabIndex = 0;
            this.personellTab.Text = "Personnel";
            this.personellTab.UseVisualStyleBackColor = true;
            // 
            // personnelToolStrip
            // 
            this.personnelToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPersonButton,
            this.openPersonsButton,
            this.savePersonsButton});
            this.personnelToolStrip.Location = new System.Drawing.Point(3, 3);
            this.personnelToolStrip.Name = "personnelToolStrip";
            this.personnelToolStrip.Size = new System.Drawing.Size(490, 25);
            this.personnelToolStrip.TabIndex = 0;
            this.personnelToolStrip.Text = "toolStrip1";
            // 
            // personLayoutPanel
            // 
            this.personLayoutPanel.AutoScroll = true;
            this.personLayoutPanel.ColumnCount = 1;
            this.personLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.personLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.personLayoutPanel.Location = new System.Drawing.Point(3, 31);
            this.personLayoutPanel.Name = "personLayoutPanel";
            this.personLayoutPanel.RowCount = 1;
            this.personLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.personLayoutPanel.Size = new System.Drawing.Size(490, 352);
            this.personLayoutPanel.TabIndex = 0;
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
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(279, 48);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(213, 117);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "Send Message";
            this.sendButton.UseVisualStyleBackColor = true;
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
            // newPersonButton
            // 
            this.newPersonButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newPersonButton.Image = ((System.Drawing.Image)(resources.GetObject("newPersonButton.Image")));
            this.newPersonButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newPersonButton.Name = "newPersonButton";
            this.newPersonButton.Size = new System.Drawing.Size(23, 22);
            this.newPersonButton.Text = "&New";
            this.newPersonButton.Click += new System.EventHandler(this.newPersonButton_Click);
            // 
            // openPersonsButton
            // 
            this.openPersonsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openPersonsButton.Image = ((System.Drawing.Image)(resources.GetObject("openPersonsButton.Image")));
            this.openPersonsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openPersonsButton.Name = "openPersonsButton";
            this.openPersonsButton.Size = new System.Drawing.Size(23, 22);
            this.openPersonsButton.Text = "&Open";
            this.openPersonsButton.Click += new System.EventHandler(this.openPersonsButton_Click);
            // 
            // savePersonsButton
            // 
            this.savePersonsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.savePersonsButton.Image = ((System.Drawing.Image)(resources.GetObject("savePersonsButton.Image")));
            this.savePersonsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.savePersonsButton.Name = "savePersonsButton";
            this.savePersonsButton.Size = new System.Drawing.Size(23, 22);
            this.savePersonsButton.Text = "&Save";
            this.savePersonsButton.Click += new System.EventHandler(this.savePersonsButton_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.personellTab.ResumeLayout(false);
            this.personellTab.PerformLayout();
            this.personnelToolStrip.ResumeLayout(false);
            this.personnelToolStrip.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel personLayoutPanel;
        private System.Windows.Forms.ToolStrip personnelToolStrip;
        private System.Windows.Forms.ToolStripButton newPersonButton;
        private System.Windows.Forms.ToolStripButton openPersonsButton;
        private System.Windows.Forms.ToolStripButton savePersonsButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

