using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LatihanPolymorphism
{
    public class ConvertToJson : IConvertObject
    {
        public void Convert(Mahasiswa mhs)
        {
            //konversi objek mahasiswa ke json
            string json = JsonConvert.SerializeObject(mhs);

            Console.WriteLine("Hasil Konversi ke json:\n");
            Console.WriteLine(json);
        }
    }
}
