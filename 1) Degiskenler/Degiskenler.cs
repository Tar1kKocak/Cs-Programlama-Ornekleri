using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    internal class Program
    {

        static void Main(string[] args)
        {
            char karakter = 'T';
            string isim = "Tarik";
            int tamsayi = 5;
            float kesirlisayi = 1.4f;
            double buyukkesirlisayi = 9.4;
            bool anahtar = true;

            Console.Write(karakter + "\n");
            Console.Write(isim + "\n");
            Console.Write(tamsayi + kesirlisayi + "\n");
            Console.Write(buyukkesirlisayi + "\n");

            Console.Write(karakter);
            Console.Write(isim);
            Console.WriteLine(tamsayi + kesirlisayi);
            Console.WriteLine(buyukkesirlisayi);

            Console.WriteLine("sayi = {0},isim = {1}", kesirlisayi, isim);

            Console.WriteLine("sayi = " + kesirlisayi + ",isim =  " + isim);



            int kesirlisayininboyut = Marshal.SizeOf(kesirlisayi);
            Console.WriteLine(kesirlisayininboyut);

        }
    }
}