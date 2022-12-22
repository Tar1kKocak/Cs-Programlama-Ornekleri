using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Yazilimin amaci :  Adet sayisina gore fiyat degisikligi gosteren toptan satis uygulamasi.

            /* 0-100 adet = a.fiyatý = 3 tl
		    100-200 adet = a.fiyatý = 2.5 tl
		    200-300 adet = a.fiyatý = 2 tl
		    300-400 adet = a.fiyatý = 1.5 tl
		    400+ adet = a.fiyatý = 0.75 tl  */

            int adet;
            double adetucreti=0,toplam;
            

            Console.WriteLine("Kac adet alacaksiniz?");
            adet=int.Parse(Console.ReadLine());
            
            if(adet<100 && adet>0)
            {
                adetucreti = 3;
            }
            else if (adet>=100 && adet < 200)
            {
                adetucreti = 2.5;
            }
            else if(adet>=200 && adet < 300)
            {
                adetucreti = 2;
            }
            else if(adet>=300 && adet < 400)
            {
                adetucreti = 1.5;
            }
            else if(adet>=400 )
            {
                adetucreti = 0.75;

            }
            

            toplam = adet * adetucreti;

            Console.WriteLine("Toplam odemeniz gereken ucret:"+toplam);

        }

    }
}
