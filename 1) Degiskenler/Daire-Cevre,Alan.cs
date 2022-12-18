using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Yazilimin Amaci : Yaricapi girilen dairenin alanini ve cevresini bulmak.

            const double PI = Math.PI;
            int yaricap;

            Console.WriteLine("Dairenizin yaricapini giriniz:");
            yaricap = int.Parse(Console.ReadLine());
            Console.WriteLine("Dairenin Cevresi:" + (2 * PI * yaricap));
            Console.WriteLine("Dairenin Alani:" + (PI * yaricap * yaricap));


        }
    }
}
