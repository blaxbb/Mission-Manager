using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace MissionManager
{
    public class IncomingMailArgs : EventArgs
    {
        public List<MailMessage> messages;
    }
}
