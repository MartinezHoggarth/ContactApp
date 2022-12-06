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
    public partial class AddContactForm : Form
    {
        public bool flag = false;
        public AddContactForm()
        {
            InitializeComponent();
            this.Text = "Add contact";
            this.Size = new Size(290, 200);

        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            
        }

        private void addCancel_Click(object sender, EventArgs e)
        {
            this.flag = false; 
            this.Close();
        }

        public Contact addOk_Function()
        {
            Contact contact = new Contact(nameBox.Text, surnameBox.Text, phoneBox.Text, emailBox.Text);
            return contact;
        }
        private void addOk_Click(object sender, EventArgs e)
        {
            this.flag = true;
            
            this.Close();
        }
    }
}
