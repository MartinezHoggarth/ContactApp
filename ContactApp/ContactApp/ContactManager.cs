using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ContactApp
{
    public class ContactManager
    {
        /// <summary>
        /// Функция, выполняющая функцию сериализации
        /// </summary>


        public static void SaveFile(ContactFunction data)
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
        /// <returns></returns>
        public static ContactFunction LoadFile()
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(@"C:\Users\dinam\Desktop\ContactApp.txt"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                return (ContactFunction)serializer.Deserialize<ContactFunction>(reader);
            }
        }
    }
}
