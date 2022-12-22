using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Yazilimin Amaci: Hesap Makinesi

            float sayi1, sayi2,sonuc;
            char islem;

            Console.WriteLine("1.sayiyi giriniz.");
            sayi1 = float.Parse(Console.ReadLine());

            Console.WriteLine("2.sayiyi giriniz.");
            sayi2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Islem seciniz -> +, -, /, *, %");
            islem = Convert.ToChar(Console.ReadLine());

            if (islem == '+')
            {
                sonuc = sayi1 + sayi2;

            }
            else if (islem == '-')
            {
                sonuc = sayi1 - sayi2;
            }
            else if (islem == '/')
            {
                sonuc = sayi1 / sayi2;
            }
            else if (islem == '*')
            {
                sonuc = sayi1 * sayi2;
            }
            else
            {
                sonuc = sayi1 % sayi2;
            }

            Console.WriteLine("{0} {1} {2} = {3}", sayi1, islem, sayi2, sonuc);

        }
    }
}
