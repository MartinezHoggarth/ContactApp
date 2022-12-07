using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactApp;


namespace ContactAppUI
{
    public partial class MasterForm : Form
    {
        public List<Contact> contacts = new List<Contact>();
        public Contact contactForInfo = new Contact();

        public MasterForm()
        {
            InitializeComponent();
            this.Text = "ContactsApp";
            this.Size = new Size(400, 600);
            this.MaximumSize = new Size(400, 600);
            this.MinimumSize = new Size(400, 600);
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AddButton_Click(object sender, EventArgs e)
        {
           AddContactForm addContactForm = new AddContactForm();
            addContactForm.ShowDialog();
           if (addContactForm.flag == true)
           {

                Contact contact = addContactForm.addOk_Function();
                this.contacts.Add(contact);
                string temp = "[" + contact.ContactId + "]:" + " Name: " + contact.FirstName + " Phone: " + contact.Phone;
                contactList.Items.Add(temp);
           }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (contacts.Count == 0 || contactList.SelectedIndex == -1)
            {
                MessageBox.Show("Contact list empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int n = contactList.SelectedIndex;
                contactList.Items.RemoveAt(n);
                contacts.RemoveAt(n);
            }
        }

        private void showInfoButton_Click(object sender, EventArgs e)
        {
            if(contacts.Count == 0 || contactList.SelectedIndex == -1)
            {
                MessageBox.Show("Contact list empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int n = contactList.SelectedIndex;
                ShowInfoForm showInfoForm = new ShowInfoForm();
                showInfoForm.ShowInfo(contacts[n]);
                showInfoForm.ShowDialog();
            }
            
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (contacts.Count == 0 || contactList.SelectedIndex == -1)
            {
                MessageBox.Show("Contact list empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                EditContactForm editContactForm = new EditContactForm();
                Contact contact = new Contact();
                int n = contactList.SelectedIndex;
                contact = editContactForm.EditContact(contacts[n]);
                editContactForm.ShowDialog();
                if (editContactForm.marker == true)
                {
                    contact = editContactForm.EditContact(contacts[n]);
                    string temp = "[" + contact.ContactId + "]:" + " Name: " + contact.FirstName + " Phone: " + contact.Phone;
                    contactList.Items[n] = temp;
                    contacts[n] = contact;
                }
            }
        }

        private void exitALTF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new AddContactForm();
            addContactForm.ShowDialog();
            if (addContactForm.flag == true)
            {

                Contact contact = addContactForm.addOk_Function();
                this.contacts.Add(contact);
                string temp = "[" + contact.ContactId + "]:" + " Name: " + contact.FirstName + " Phone: " + contact.Phone;
                contactList.Items.Add(temp);
            }
        }

        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contacts.Count == 0 || contactList.SelectedIndex == -1)
            {
                MessageBox.Show("Contact list empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                EditContactForm editContactForm = new EditContactForm();
                Contact contact = new Contact();
                int n = contactList.SelectedIndex;
                contact = editContactForm.EditContact(contacts[n]);
                editContactForm.ShowDialog();
                if (editContactForm.marker == true)
                {
                    contact = editContactForm.EditContact(contacts[n]);
                    string temp = "[" + contact.ContactId + "]:" + " Name: " + contact.FirstName + " Phone: " + contact.Phone;
                    contactList.Items[n] = temp;
                    contacts[n] = contact;
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}
