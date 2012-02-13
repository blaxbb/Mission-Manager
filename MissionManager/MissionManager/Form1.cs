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

namespace MissionManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1.Controls.Clear();
            personLayoutPanel.Controls.Clear();

            for (int i = 0; i < 20; i++)
            {
                tableLayoutPanel1.Controls.Add(new Message());
            }
            for (int i = 0; i < 20; i++)
            {
                //personLayoutPanel.Controls.Add(new Person());
            }
        }

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {
            charCountLabel.Text = messageTextBox.Text.Count() + " / 140 Characters";
        }

        #region Personnel Handling
        private void savePersonsButton_Click_1(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            Stream s = File.Open(saveFileDialog1.FileName, FileMode.OpenOrCreate);

            List<Person> persons = new List<Person>();
            foreach (Person Per in personLayoutPanel.Controls)
            {
                //Console.Out
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

    }
}
