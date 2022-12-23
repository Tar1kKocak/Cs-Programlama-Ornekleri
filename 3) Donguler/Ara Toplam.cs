using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Yazilimin amaci : Girilen iki sayi arasindaki sayilarin toplamini bulmak.

            int baslangic, bitis, sayi,toplam=0;

            Console.WriteLine("Baslangic sayisini giriniz.");
            baslangic=int.Parse(Console.ReadLine());
            Console.WriteLine("Bitis sayisini giriniz.");
            bitis=int.Parse(Console.ReadLine());

            sayi = baslangic;

            while (sayi <= bitis)
            {
                toplam += sayi;


                sayi++;
            }
            Console.WriteLine("Toplam:" + toplam);
        }
    }
}
