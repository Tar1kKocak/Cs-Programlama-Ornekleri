using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int faktoriyel(int sayi)
        {
            int sonuc = 1, i;

            for (i = 0; i < sayi; i++)
            {
                sonuc *= (i+1);
            }
            return sonuc;
        }

        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Sayi giriniz");
            sayi = int.Parse(Console.ReadLine());
            Console.WriteLine(faktoriyel(sayi));

        }
    }
}
