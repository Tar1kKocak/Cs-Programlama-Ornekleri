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
            //Yazilimin Amaci: Girilen sayının Tek mi Çift mi olduğunu söyleyen program.
            int sayi;

            Console.WriteLine("Lutfen bir tam sayi giriniz.");
            sayi = int.Parse(Console.ReadLine());

            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayiniz cift");
            }
            else
            {
                Console.WriteLine("Sayiniz tek");
            }



        }
    }
}
