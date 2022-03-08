using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class XMLWriter
    {
       public async Task TestWriter(int spots, float price, List<string> types, int size)
        {
            XmlWriterSettings settings = new();
            settings.Async = true;

            using (XmlWriter writer = XmlWriter.Create("books.xml", settings))
            {
                await writer.WriteStartElementAsync("Config", "SpotAmout", $"{spots}");
                await writer.WriteStartElementAsync("Config", "SpotPrice", $"{price}");
                foreach (var type in types)
                {
                    await writer.WriteStartElementAsync("Config", "type", $"{type}");
                }
                await writer.WriteStartElementAsync("Config", "SpotAmout", $"{size}");
                await writer.WriteEndElementAsync();
                await writer.FlushAsync();
            }
        }
    }
}
