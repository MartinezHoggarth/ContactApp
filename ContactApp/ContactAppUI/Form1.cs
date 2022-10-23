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
    public partial class Form1 : Form
    {
        public ContactFunction contactFunction;
        public Form1()
        {
            
            contactFunction = new ContactFunction();
            Contact load = new Contact("1", "Lolka", "lolkovna", "+79539245090", "holy.turner@mail.ru");
            Contact load1 = new Contact("1", "Lolka", "lolkovna", "+79539245090", "holy.turner@mail.ru");
            Contact load2 = new Contact("1", "Lolka", "lolkovna", "+79539245090", "holy.turner@mail.ru");
            Contact load3 = new Contact("1", "Lolka", "lolkovna", "+79539245090", "holy.turner@mail.ru");
            contactFunction.сontactList.Add(load);
            contactFunction.сontactList.Add(load1);
            contactFunction.сontactList.Add(load2);
            contactFunction.сontactList.Add(load3);
            ContactManager.SaveFile(contactFunction);

            
            InitializeComponent();
        }
    }

}
