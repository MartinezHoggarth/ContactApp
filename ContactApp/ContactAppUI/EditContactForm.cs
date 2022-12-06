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
    public partial class EditContactForm : Form
    {
        public bool marker;
        public EditContactForm()
        {
            InitializeComponent();
            this.Size = new Size(290, 200);
            this.Text = "Edit contact";
            this.MaximumSize = new Size(290, 200);
            this.MinimumSize = new Size(290, 200);
        }

        private void EditContactForm_Load(object sender, EventArgs e)
        {
            
        }
        public Contact EditContact(Contact contact)
        {
            Contact editedContact = new Contact();
            nameBox.Text = contact.FirstName;
            surnameBox.Text = contact.LastName;
            phoneBox.Text = contact.Phone;
            emailBox.Text =  contact.Email;
            editedContact.FirstName = nameBox.Text;
            editedContact.LastName = surnameBox.Text;
            editedContact.Phone = phoneBox.Text;
            editedContact.Email = emailBox.Text;
            if (this.marker == true)
            {
                return editedContact;
            }
            else
            {
                return null;
            }
        }

        private void editCancel_Click(object sender, EventArgs e)
        {

            this.marker = false;
            this.Close();
        }

        private void editOk_Click(object sender, EventArgs e)
        {
            
            this.marker = true;
            this.Close();
        }
    }
}
