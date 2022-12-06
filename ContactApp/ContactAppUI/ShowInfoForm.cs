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
    public partial class ShowInfoForm : Form
    {
        public ShowInfoForm()
        {
            InitializeComponent();
            this.Text = "Show Info";
            this.Size = new Size(290, 200);
            
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            
        }
        public void ShowInfo(Contact contactFromMasterForm)
        {
            this.nameDynamicLabel.Text = contactFromMasterForm.FirstName;
            this.surnameDynamicLabel.Text = contactFromMasterForm.LastName;
            this.phoneDynamicLabel.Text = contactFromMasterForm.Phone;
            this.emailDynamicLabel.Text = contactFromMasterForm.Email;
            this.contactidDynamicLabel.Text = contactFromMasterForm.ContactId.ToString();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
