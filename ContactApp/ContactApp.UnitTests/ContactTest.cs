using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NUnit.Framework;
using ContactApp;

namespace ContactApp.UnitTests
{
    [TestFixture]
    public class ContactTest
    {
        
        [Test(Description = "Позитивный тест геттера Surname")]
        public void TestSurnameGet_CorrectValue()
        {
            var expected = "Смирнов";
            var contact = new Contact();
            contact.LastName = expected;
            var actual = contact.LastName;
            Assert.AreEqual(expected, actual, "Геттер Surname возвращает неправильную фамилию");
        }
        [Test(Description = "Позитивный тест геттера Surname")]
        public void TestSurnameSet_CorrectValue()
        {
            var contact = new Contact();
            contact.LastName = "Смирнов";
            var expected = contact.LastName;
            var actual = contact.LastName;
            Assert.AreEqual(expected, actual, "Геттер Surname возвращает неправильную фамилию");
        }

        [Test(Description = "Позитивный тест геттера Surname")]
        public void TestNameGet_CorrectValue()
        {
            var expected = "Смирнов";
            var contact = new Contact();
            contact.FirstName = expected;
            var actual = contact.FirstName;
            Assert.AreEqual(expected, actual, "Геттер Surname возвращает неправильную фамилию");
        }
        [Test(Description = "Позитивный тест геттера Surname")]
        public void TestNameSet_CorrectValue()
        {
            var contact = new Contact();
            contact.FirstName = "Смирнов";
            var expected = contact.FirstName;
            var actual = contact.FirstName;
            Assert.AreEqual(expected, actual, "Геттер Surname возвращает неправильную фамилию");
        }
        [Test(Description = "Позитивный тест геттера Surname")]
        public void TestPhoneGet_CorrectValue()
        {
            var expected = "Смирнов";
            var contact = new Contact();
            contact.Phone = expected;
            var actual = contact.Phone;
            Assert.AreEqual(expected, actual, "Геттер Surname возвращает неправильную фамилию");
        }
        [Test(Description = "Позитивный тест геттера Surname")]
        public void TestPhoneSet_CorrectValue()
        {
            var contact = new Contact();
            contact.Phone = "Смирнов";
            var expected = contact.Phone;
            var actual = contact.Phone;
            Assert.AreEqual(expected, actual, "Геттер Surname возвращает неправильную фамилию");
        }
        public void TestEmailGet_CorrectValue()
        {
            var expected = "Смирнов";
            var contact = new Contact();
            contact.Email = expected;
            var actual = contact.Email;
            Assert.AreEqual(expected, actual, "Геттер Surname возвращает неправильную фамилию");
        }
        [Test(Description = "Позитивный тест геттера Surname")]
        public void TestEmailSet_CorrectValue()
        {
            var contact = new Contact();
            contact.Email = "Смирнов";
            var expected = contact.Email;
            var actual = contact.Email;
            Assert.AreEqual(expected, actual, "Геттер Surname возвращает неправильную фамилию");
        }
        [Test(Description = "Присвоение неправильной фамилии больше 40 символов")]
        public void TestSurnameSet_Longer50Symbols()
        {
            var wrongSurname = "Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов";
            var contact = new Contact();
            Assert.Throws<ArgumentException>(() => { contact.LastName = wrongSurname; },"Должно возникать исключение, если фамилия длиннее 50 символов");
        }
        [Test(Description = "Присвоение неправильной фамилии больше 40 символов")]
        public void TestNameSet_Longer50Symbols()
        {
            var wrongSurname = "Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов";
            var contact = new Contact();
            Assert.Throws<ArgumentException>(() => { contact.FirstName = wrongSurname; }, "Должно возникать исключение, если фамилия длиннее 50 символов");
        }

    }
}
