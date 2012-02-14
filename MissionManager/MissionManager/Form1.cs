using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using OpenPop.Pop3;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net.Mail;

namespace MissionManager
{
    public partial class Form1 : Form
    {
        Pop3Client incommingClient = new Pop3Client();
        IncomingMailHandler incMailHandler = new IncomingMailHandler("pop.google.com", 995, true, "blaxbbUGCTest", "paulzombies");

        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1.Controls.Clear();
            personLayoutPanel.Controls.Clear();

            incMailHandler.NewMail += new IncomingMailHandler.NewIncommingMail(incMailHandler_NewMail);

            for (int i = 0; i < 2; i++)
            {
                //string message = "MSG " + i;
                //Person sender = new Person();
                //sender.FullName = "NAME";
                //newMessage(message, sender);
            }
            for (int i = 0; i < 20; i++)
            {
                //personLayoutPanel.Controls.Add(new Person());
            }
        }

        void incMailHandler_NewMail(object sender, IncomingMailArgs e)
        {
            Console.WriteLine("CHECKMAIL");
            List<MailMessage> allMessages = e.messages;
            if (allMessages == null)
                return;
            foreach (MailMessage msg in allMessages)
            {
                string number = Regex.Replace(msg.Subject, "[^0-9]", "");

                Person from = getPersonFromNumber(number);
                if (from != null)
                {
                    newMessage(msg.Body, from);
                    incMailHandler.SuccessfullyParsedMessage(msg);
                    Console.Write(msg.Body);
                }
                else
                {
                    Console.WriteLine("NO SENDER");
                }
            }
        }



        #region Message Handling
        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {
            charCountLabel.Text = messageTextBox.Text.Count() + " / 140 Characters";
        }

        private Message newMessage(string message, Person sender)
        {
            Message msg = new Message();
            msg.UpdateControls(message, sender);
            return newMessage(msg);
        }
        private Message newMessage(Message message)
        {
            tableLayoutPanel1.Controls.Add(message, 0, 0);

            return message;
        }

        private void getMessagesButton_Click(object sender, EventArgs e)
        {
            CheckForMessages();
        }

        private void CheckForMessages()
        {
            
            
        }
        #endregion

        #region Personnel Handling

        private Person getPersonFromNumber(string Number)
        {
            foreach (Person p in personLayoutPanel.Controls)
            {
                if (p.Number == Number)
                    return p;
            }
            return null;
        }

        private void savePersonsButton_Click_1(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            Stream s = File.Open(saveFileDialog1.FileName, FileMode.OpenOrCreate);

            List<Person> persons = new List<Person>();
            foreach (Person Per in personLayoutPanel.Controls)
            {
                persons.Add(Per);
                
            }
            formatter.Serialize(s, persons);
            s.Close();
        }

        private void newPersonButton_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            personLayoutPanel.Controls.Add(p);
            personLayoutPanel.ScrollControlIntoView(p);
            p.FullName = "TEST";
        }

        private Person addPerson(Person p = null)
        {
            if (p == null)
                p = new Person();
            else
                Console.WriteLine("adding" + p.ToString());

            personLayoutPanel.Controls.Add(p);
            personLayoutPanel.ScrollControlIntoView(p);

            return p;
        }

        private void openPersonsButton_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            Stream s = File.Open(openFileDialog1.FileName, FileMode.Open);

            Console.WriteLine("READING");

            List<Person> persons = (List<Person>)formatter.Deserialize(s);
            s.Close();

            bool replace = MessageBox.Show("Remove Old Items", "Replace?", MessageBoxButtons.YesNo) == DialogResult.Yes;

            if (replace)
                personLayoutPanel.Controls.Clear();

            foreach (Person p in persons)
            {
                Console.WriteLine(p.ToString());
                addPerson(p);
            }

        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(personLayoutPanel.Controls.Count >0)
                incMailHandler.Tick();
        }
    }
}
