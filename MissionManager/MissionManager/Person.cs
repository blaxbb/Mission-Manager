using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MissionManager
{
    [Serializable()]
    public partial class Person : UserControl, ISerializable
    {
        public string FullName, Number;
        public bool RecieveMessages;
        private bool Editing = true;

        public Person()
        {
            InitializeComponent();
        }

        public Person(SerializationInfo info, StreamingContext ctxt)
        {
            InitializeComponent();
            nameTextBox.Text = FullName = (string)info.GetValue("name", typeof(string));
            numberTextBox.Text = Number = (string)info.GetValue("number", typeof(string));
            messageCheckBox.Checked = RecieveMessages = (bool)info.GetValue("recieve", typeof(bool));
            setReadOnly();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("name", FullName);
            info.AddValue("number", Number);
            info.AddValue("recieve", RecieveMessages);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Editing)
            {
                FullName = nameTextBox.Text;
                Number = numberTextBox.Text;
                RecieveMessages = messageCheckBox.Checked;
            }

            toggleEditMode();
        }

        public override string ToString()
        {
            return FullName + ", " + Number + ", " + RecieveMessages.ToString();
        }


        #region Editable Toggles

        private void toggleEditMode()
        {
            if (Editing)
            {
                setReadOnly();
            }
            else
            {
                setEditable();
            }
        }

        private void setEditable()
        {
            setAllControls(true);
            Editing = true;
        }

        private void setReadOnly()
        {
            setAllControls(false);
            Editing = false;
        }

        private void setAllControls(bool state)
        {
            nameTextBox.Enabled = state;
            numberTextBox.Enabled = state;
            messageCheckBox.Enabled = state;

            if (state)
            {
                saveButton.Text = "Save";
            }
            else
            {
                saveButton.Text = "Edit";
            }
        }

        private void numberTextBox_Leave(object sender, EventArgs e)
        {
            setReadOnly();
        }

        #endregion
    }
}
