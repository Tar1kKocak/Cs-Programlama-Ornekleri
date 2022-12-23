using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Yazilimin Amaci : Kullanicidan alinan  pozitif bir tam sayinin asal olup olmadigini bulmak.

            int sayi, i,sayac=0;

            Console.WriteLine("Sayi giriniz.");
            sayi = int.Parse(Console.ReadLine());

            for (i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac=1;
                    break;
                }
            }
            if (sayac == 0)
            {
                Console.WriteLine(+sayi + " Asal Sayidir.");
            }
            else if (sayac == 1)
            {
                Console.WriteLine(+sayi + " Asal Sayi Degildir.");
            }
        }
    }
}
