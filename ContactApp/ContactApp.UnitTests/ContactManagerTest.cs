using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using ContactApp.UnitTests;

namespace ContactApp.UnitTests
{
    internal class ContactManagerTest
    {
        /// <summary>
        /// Функция, выполняющая функцию сериализации
        /// </summary>


        public static void SaveFile(ContactFunctionTest data)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter((@"C:\Users\dinam\Desktop\ContactApp.txt")))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {

                serializer.Serialize(writer, data);
            }
        }
        /// <summary>
        /// Функция, выполняющая функцию десериализации
        /// </summary>
        /// <returns></returns>C
        public static ContactFunctionTest LoadFile()
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(@"C:\Users\dinam\Desktop\ContactApp.txt"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                return (ContactFunctionTest)serializer.Deserialize<ContactFunctionTest>(reader);
            }
        }
    }
}

