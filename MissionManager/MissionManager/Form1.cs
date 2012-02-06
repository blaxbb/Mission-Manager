using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MissionManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1.Controls.Clear();
            for (int i = 0; i < 20; i++)
            {
                tableLayoutPanel1.Controls.Add(new Message());
            }
        }

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {
            charCountLabel.Text = messageTextBox.Text.Count() + " / 140 Characters";
        }
    }
}
