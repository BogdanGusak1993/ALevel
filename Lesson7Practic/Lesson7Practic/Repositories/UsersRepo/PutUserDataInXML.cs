using Lesson7Practic.Models;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Lesson7Practic.Repositories.UsersRepo
{
    public static class PutUserDataInXML
    {
        public static void LoadDataToXml(User user)
        {
            string path = "C:\\Users\\User\\source\\repos\\Lesson7Practic\\Lesson7Practic\\Entities\\Users_Data.xml";

            XmlSerializer xml = new XmlSerializer(typeof(User));

            TextWriter writer = new StreamWriter(path);

            xml.Serialize(writer, user);

            writer.Close();
        }
    }
}
