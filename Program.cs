using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //contoh data mahasiswa
            Mahasiswa mhs = new Mahasiswa();
            mhs.npm = "18.11.2296";
            mhs.nama = "Kristian Ugahari Dwipa";
            mhs.email = "kristian.dwipa@students.amikom.ac.id";

            Console.WriteLine("Pilih Format Konversi Data : ");
            Console.WriteLine("1. Json");
            Console.WriteLine("2. XML");
            Console.WriteLine("3. Csv\n");

            Console.Write("Nomor Format Data[1...3] : ");
            int nomorFormatData = Convert.ToInt32(Console.ReadLine());

            IConvertObject convert; //deklarasi objek konversi

            if (nomorFormatData == 1)
                convert = new ConvertToJson();
            else if (nomorFormatData == 2)
                convert = new ConvertToXml();
            else
                convert = new ConvertToCsv();

            //konversi objek mhs berdasarkan format yang dipilih
            convert.Convert(mhs);

            Console.ReadKey();
        }
    }
}
