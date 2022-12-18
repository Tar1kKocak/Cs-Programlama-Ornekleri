using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karedik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Yazilimin Amaci : Kare ve Dikdortgenin alan ve cevre hesabını yapmak.

            int kareuzunluk, dikdortuzun, dikdortkisa;

            Console.WriteLine("Karenizin bir kenar uzunlugunu giriniz.");
            kareuzunluk = int.Parse(Console.ReadLine());
            Console.WriteLine("Dikdortgeninizin uzun kenarini ve kisa kenarini sirasiyla giriniz.");
            dikdortuzun=int.Parse(Console.ReadLine());
            dikdortkisa = int.Parse(Console.ReadLine());


            Console.WriteLine("Karenizin Cevresi:" + (kareuzunluk * 4));
            Console.WriteLine("Karenin Alani:" + (kareuzunluk * kareuzunluk));
            Console.WriteLine("Dikdortgenin Cevresi:" + (2 * dikdortkisa + 2 * dikdortuzun));
            Console.WriteLine("Dıkdortgenin Alani:" + (dikdortuzun * dikdortkisa));
        }
    }
}
