using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MissionManager
{
    public partial class Message : UserControl
    {
        public string Msg;
        public Person Sender;

        public Message()
        {
            InitializeComponent();
        }

        public void UpdateControls(String message, Person sender)
        {
            Console.Write("UPDATING" + message + sender.ToString());
            Msg = message;
            Sender = sender;
            messageLabel.Text = Msg;
            senderLabel.Text = Sender.FullName;
        }
    }
}
