using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Yazilimin Amaci:Girilen alti basamakli sayinin rakamlari toplamini bulmak.

            int sayi,yuzbin,onbin,bin,yuz,on,bir;

            Console.WriteLine("Alti basamakli bir sayi giriniz:");
            sayi = int.Parse(Console.ReadLine());

            yuzbin = sayi / 100000;
            onbin = (sayi % 100000) / 10000;
            bin = (sayi % 10000) / 1000;
            yuz = (sayi % 1000) / 100;
            on = (sayi % 100) / 10;
            bir = sayi % 10;

            Console.WriteLine("Rakamlarinin Toplami:" + (yuzbin + onbin + bin + yuz + on + bir));


        }
    }
}
