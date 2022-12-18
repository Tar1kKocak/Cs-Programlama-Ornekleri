using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Yazilimin Amaci : Denklem Cozmek.

            int a, b, c, x;

            Console.WriteLine("Denklemimiz: ax2+bx+c");
            Console.WriteLine("Girmek istediginiz a,b ve c degerlerini sirayla giriniz:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("X degerini giriniz:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Denkleminizin Sonucu:" + (a * x * x + b * x + c));

        }
    }
}
