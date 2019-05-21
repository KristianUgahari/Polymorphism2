using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace LatihanPolymorphism
{
    class ConvertToXml : IConvertObject
    {
        public void Convert(Mahasiswa mhs)
        {
            using (StringWriter writer = new StringWriter())
            {
                //konversi objek mahasiswa ke XML
                XmlSerializer serializer = new XmlSerializer(typeof(Mahasiswa));
                serializer.Serialize(writer, mhs);

                string xml = writer.ToString();

                Console.WriteLine("Hasil konversi ke XML:\n");
                Console.WriteLine(xml);
            }
        }
    }
}
