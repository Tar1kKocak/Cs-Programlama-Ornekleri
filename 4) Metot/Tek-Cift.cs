using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void tekciftbulma(int sayi)
        {
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayiniz Cift");
            }
            else
            {
                Console.WriteLine("Sayiniz Tek");
            }
        }
        static void Main(string[] args)
        {
            int sayi;

            Console.WriteLine("Bir sayi giriniz");
            sayi=int.Parse(Console.ReadLine());

            tekciftbulma(sayi);

        }
    }
}
