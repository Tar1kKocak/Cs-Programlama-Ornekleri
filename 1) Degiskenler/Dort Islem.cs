using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dortislem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Yazilimin Amaci : Dort Islem Yapmak.

            int sayi1, sayi2;
            Console.WriteLine("Iki adet sayi giriniz");
            sayi1 = int.Parse(Console.ReadLine());
            sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Toplam:" + (sayi1 + sayi2));
            Console.WriteLine("Cikarma:" + (sayi1 - sayi2));
            Console.WriteLine("Carpma:" + (sayi1 * sayi2));
            Console.WriteLine("Bolme:" + (sayi1 / sayi2));
            Console.WriteLine("Mod:" + (sayi1 % sayi2));
            Console.WriteLine("Kuvvet:" + (Math.sqrt(sayi1)));


        }
    }
}
