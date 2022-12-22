using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Yazilimin Amaci : Hesap Makinesi 

            char formul;
            float sayi1, sayi2;

            Console.WriteLine("Lütfen yapmak istediginiz islemin sembolunu seciniz.\n");
            Console.WriteLine("1-Toplama (+)\n2-Çikarma(-)\n3-Carpma(*)\n4-Bolme(/)\n");
            formul=Console.ReadKey().KeyChar;
            Console.WriteLine("\n");
            Console.WriteLine("Lutfen iki adet sayi giriniz");
            sayi1 = int.Parse(Console.ReadLine());
            sayi2 = int.Parse(Console.ReadLine());

           switch(formul)
            {
                case '+':Console.WriteLine("Toplam:"+(sayi1 + sayi2)); break;
                case '-':Console.WriteLine("Cikartma:"+(sayi1- sayi2)); break;
                case '*':Console.WriteLine("Carpma:"+(sayi1 * sayi2)); break;
                case '/':Console.WriteLine("Bolme:"+(sayi1/ sayi2)); break;
            }
        }
    }
}
