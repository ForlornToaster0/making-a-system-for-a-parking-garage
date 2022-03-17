using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace DataAccess
{
    public class XmlManager
    {
        public static void XmlDataWriter(object obj, string filename)
        {
            XmlSerializer sr = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(filename);
            sr.Serialize(writer, obj);
            writer.Close();
        }

        //Userdata xml reader
        public static XML XmlDataReader(string filename)
        {
            XML obj = new XML();
            XmlSerializer xs = new XmlSerializer(typeof(XML));
            FileStream reader = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
            obj = (XML)xs.Deserialize(reader);
            reader.Close();
            return obj;
        }
    }
}
