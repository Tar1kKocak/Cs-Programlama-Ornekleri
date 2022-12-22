using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Yazilimin Amaci : Kullanicidan bir yil degeri girmesini isteyen ve girilen yilin artik yil olup olmadigini kontrol eden bir program yaziniz.
            //Artik Yil : 4 ile kalansız bölünebilen yil.

            int yil;

            Console.WriteLine("Lutfen bir yil giriniz.");
            yil = int.Parse(Console.ReadLine());

            if (yil % 4 == 0)
            {
                Console.WriteLine("Girdiginiz yil Artik yildir.");
                
            }
            else
            {
                Console.WriteLine("Artik Yil Degildir.");
            }


        }
    }
}
