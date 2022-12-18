using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girdi_Alma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string isim;
            char karakter;
          
            Console.WriteLine("Isminiz nedir?");
            isim =Console.ReadLine();
            Console.WriteLine(isim);

            Console.WriteLine("Karakter giriniz");
            karakter = Console.ReadKey().KeyChar;
            Console.WriteLine(karakter);    


            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayi2 = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Karesi : " + (sayi*sayi));
            Console.WriteLine("Karesi : " + (sayi2 * sayi2));

            double sayi3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Karesi : " + (sayi3 * sayi3));

            float sayi4 = float.Parse(Console.ReadLine());
            Console.WriteLine("Karesi : " + (sayi4 * sayi4));




        }
    }
}
