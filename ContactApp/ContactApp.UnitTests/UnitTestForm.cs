using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NUnit.Framework;
using ContactApp;


namespace ContactApp.UnitTests
{
    public partial class UnitTestForm : Form
    {
        public UnitTestForm()
        {
            InitializeComponent();
            ContactTest contactTest = new ContactTest();
            contactTest.TestSurnameGet_CorrectValue();
        }
        

    }


}

