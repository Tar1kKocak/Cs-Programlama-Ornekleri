using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Yazilimin Amaci : Kullaniciden isim,yas ve boyunu alıp ekrana bastirma.

            int yas, boy;
            string isim;

            Console.Write("Isminizi giriniz:");
            isim = Console.ReadLine();

            Console.Write("Yasinizi giriniz:");
            yas = int.Parse(Console.ReadLine());

            Console.Write("Boyunuzu giriniz:");
            boy = int.Parse(Console.ReadLine());

            Console.WriteLine("Isim:" + isim);
            Console.WriteLine("Yas:" + yas);
            Console.WriteLine("Boy:" + boy);

        }
    }
}
