using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ContactApp
{
    /// <summary>
    /// Класс,описывающий контакт
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Идентификатор контакта
        /// <summary>
        private static int contactId = -1;
        /// <summary>
        /// Имя
        /// <summary>
        private string firstName;
        /// <summary>
        /// Фамилия
        /// <summary>
        private string lastName;
        /// <summary>
        /// Телефон
        /// <summary>
        private string phone;
        // email
        private string email;

        public int ContactId
        {
            get
            {
                return contactId;
            }
            set
            {
                contactId++;
            }
        }
        public string FirstName
        {
            get 
            { 
                return firstName; 
            }
            set 
            {
                if (value.Length > 50 )
                {
                    throw new ArgumentException("Поле не должно быть пустым и должно быть короче 50 символов");
                }
                firstName = value;
            }
        }
        public string LastName
        {
            get 
            { 

                return lastName;
            }
            set 
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Имя должно быть короче 50 символов");
                }
                lastName = value;
            }
        }
        public string Phone
        {
            get 
            { 
                return phone; 
            }
            set
            {

                phone = value;
            }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Contact(string firstName, string lastName, string phone, string email)
        {
            this.ContactId = ContactId;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
        }
        public Contact()
        {
        }
    }
}
