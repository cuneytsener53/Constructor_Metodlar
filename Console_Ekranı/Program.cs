using Console_Ekranı;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kimlik kml = new Kimlik();
            kml.AD = "Cüneyt";
            kml.SOYAD = "Şener";
            kml.MEMLEKET = "Rize";
            kml.CİNSİYET = 'E';
            kml.YAS = 28;
            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.MEMLEKET);
            Console.WriteLine(kml.CİNSİYET);
            Console.WriteLine(kml.YAS);
            Console.Read();
        }
    }
}