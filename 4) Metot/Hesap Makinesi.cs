using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void toplama(int sayi1, int sayi2)
        {
            Console.WriteLine("Toplam Sonucu :"+(sayi1 + sayi2));
        }
        static void cikarma(int sayi1, int sayi2)
        {
            Console.WriteLine("Toplam Sonucu :"+(sayi1 - sayi2));
        }
        static void carpma(int sayi1, int sayi2)
        {
            Console.WriteLine("Carpma Sonucu :"+(sayi1 * sayi2));
        }
        static void bolme(int sayi1, int sayi2)
        {
            Console.WriteLine("Bolme Islemınden Bolum:"+(sayi1 / sayi2));
            
            Console.WriteLine("Bolme Isleminden Kalan :"+(sayi1 % sayi2));
        }

        static void Main(string[] args)
        {
            int islemno, sayi1, sayi2;
        a:
            Console.WriteLine("Islem numaranizi belirtiniz.\n");
            Console.WriteLine("1-Toplama\n2-Cikarma\n3-Carpma\n4-Bolme\n");
            islemno=int.Parse(Console.ReadLine());

            if (islemno == 1)
            {
                Console.WriteLine("Lutfen sirasiyla iki adet sayi giriniz.\n");
                sayi1= int.Parse(Console.ReadLine());
                sayi2= int.Parse(Console.ReadLine());
                toplama(sayi1, sayi2);
            }
            else if (islemno == 2)
            {
                Console.WriteLine("Lutfen once buyuk sayi olmak uzere sirasiyla iki adet sayi giriniz.");
                sayi1 = int.Parse(Console.ReadLine());
                sayi2 = int.Parse(Console.ReadLine());
                cikarma(sayi1, sayi2);

            }
            else if (islemno == 3)
            {
                Console.WriteLine("Lutfen sirasiyla iki adet sayi giriniz.\n");
                sayi1 = int.Parse(Console.ReadLine());
                sayi2 = int.Parse(Console.ReadLine());
                carpma(sayi1, sayi2);

            }
            else if (islemno == 4)
            {
                Console.WriteLine("Lutfen once boluneni sonra boleni giriniz ve bolumunu soyleyelim.\n");
                sayi1 = int.Parse(Console.ReadLine());
                sayi2 = int.Parse(Console.ReadLine());
                bolme(sayi1, sayi2);


            }
            else
            {
                Console.WriteLine("Gecerli bir sayi girmediniz.");
                goto a;

            }
        }
    }
}
