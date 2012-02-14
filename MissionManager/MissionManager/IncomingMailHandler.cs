using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Threading;
using OpenPop;
using System.Text.RegularExpressions;


namespace MissionManager
{
    
    public class IncomingMailHandler
    {
        public string Hostname;
        public int Port;
        public bool UseSSL;
        public string Username;
        public string Password;

        public List<MailMessage> parsedMessages = new List<MailMessage>();

        public OpenPop.Pop3.Pop3Client client = new OpenPop.Pop3.Pop3Client();

        public delegate void NewIncommingMail(object sender, IncomingMailArgs e);
        public event NewIncommingMail NewMail;
        public IncomingMailArgs args = new IncomingMailArgs();

        private System.ComponentModel.BackgroundWorker backgroundWorker;

        public IncomingMailHandler(string host, int port, bool useSSL, string username, string password)
        {
            Hostname = host;
            Port = port;
            UseSSL = useSSL;
            Username = username;
            Password = password;

            backgroundWorker = new System.ComponentModel.BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(backgroundWorker_DoWork);
            backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
        }

        public void Tick()
        {
            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync();
            }
        }

        void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            args.messages = (List<MailMessage>)e.Result;
            if (NewMail != null)
                NewMail(this, args);
        }

        void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            List<MailMessage> newMessages = new List<MailMessage>();
            while (newMessages.Count <= 0)
            {
                newMessages = CheckMail();
                Thread.Sleep(5000);
            }
            e.Result = newMessages;
        }

        public List<MailMessage> CheckMail()
        {
            if (!client.Connected)
            {
                string hostname = "pop.gmail.com";
                int port = 995;
                client.Connect(hostname, port, true);
                client.Authenticate("blaxbbugctest", "paulzombies");
            }

            int messageCount = client.GetMessageCount();
            List<MailMessage> allMessages = new List<MailMessage>(messageCount);
            for (int i = messageCount; i > 0; i--)
            {
                MailMessage msg = client.GetMessage(i).ToMailMessage();
                if(!parsedMessages.Contains(msg))
                    allMessages.Add(msg);
            }
            return allMessages;
        }

        public void SuccessfullyParsedMessage(MailMessage msg)
        {
            parsedMessages.Add(msg);
        }
    }
}
