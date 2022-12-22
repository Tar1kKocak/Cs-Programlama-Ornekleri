using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace sc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Yazilimin Amaci : Meslek-Maas Sorgulama.

            int mesleksecenek;

            Console.WriteLine("Maasini ogrenmek istediginiz meslegi seciniz");
         a:
            Console.WriteLine("1-)Ogretmen\n2-)Mimar\n3-)Yazilimci\n4-)Asci\n5-)Garson");
            mesleksecenek = int.Parse(Console.ReadLine());

            switch (mesleksecenek) {

                case 1 :Console.WriteLine("Ortalama ucret : 13500-17000");break;
                case 2 :Console.WriteLine("Ortalama ucret : 8000-25000");break;
                case 3 :Console.WriteLine("Ortalama ucret : 12500-40000");break;
                case 4 :Console.WriteLine("Ortalam ucret : 20000-30000");break;
                case 5 :Console.WriteLine("Ortalama ucret : 5500-9000");break;
                default :Console.WriteLine("Lutfen gecerli bir rakam giriniz.");
                    goto a;

            }
        }
    }
}
