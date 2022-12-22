using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buyuk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Yazilimin Amaci: 4 tane sayıdan en büyük olanı bulan program.

            int buyuk1, buyuk2, buyuk3, sayi1, sayi2, sayi3, sayi4;

            Console.WriteLine("Dort adet sayi giriniz");
            sayi1 = int.Parse(Console.ReadLine());
            sayi2 = int.Parse(Console.ReadLine());
            sayi3 = int.Parse(Console.ReadLine());
            sayi4 = int.Parse(Console.ReadLine());

            buyuk1 = Math.Max(sayi1, sayi2);
            buyuk2 = Math.Max(sayi3, sayi4);

            if (buyuk1 > buyuk2)
            {
                buyuk3 = buyuk1;
            }
            else
            {
                buyuk3 = buyuk2;
            }
            Console.WriteLine("En buyuk sayi:" + buyuk3);
        }
    }
}
