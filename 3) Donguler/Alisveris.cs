using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Yazilimin Amaci : Girilen para degerine göre alisveris yapmak.

            int cuzdan,urunkodu,adet=0;

            Console.WriteLine("Toplamda ne kadar paraniz var?");
            cuzdan = int.Parse(Console.ReadLine());

            while (cuzdan > 0)
            {
                Console.WriteLine("Ne almak istiyorsunuz? Urun kodunu giriniz.");
                Console.WriteLine("1-Ekmek (3 TL), 2-Sut (15 TL), 3-Yumurta (60 TL), 4-Cikis: ");
                urunkodu = int.Parse(Console.ReadLine());

                if (urunkodu == 4)
                {
                    break;
                }
                else if(urunkodu>0 && urunkodu < 5)
                {
                    Console.WriteLine("Adet giriniz.");
                    adet = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Hatali Kod");
                }

                switch (urunkodu)
                {
                    case 1: if (cuzdan >= adet * 3)
                        {
                            Console.WriteLine(+adet + "adet ekmek satin alindi. Kalan paraniz:" + (cuzdan - (adet * 3)));
                            cuzdan = cuzdan - (adet * 3);
                        }
                            else
                        {
                            Console.WriteLine("Bu satin alma icin yeterli paraniz yok. Kalan paraniz: " + cuzdan);
                        }
                        break;

                    case 2: if (cuzdan >= adet * 15)
                        {
                            Console.WriteLine(+adet + "adet sut satin alindi. Kalan paraniz:" + (cuzdan - (adet * 15)));
                            cuzdan = cuzdan - (adet * 15);
                        }
                        else
                        {
                            Console.WriteLine("Bu satin alma icin yeterli paraniz yok. Kalan paraniz: " + cuzdan);
                        }
                        break;
                    case 3: if (cuzdan >= adet * 60)
                        {
                            Console.WriteLine(+adet + "adet yumurta satin alindi. Kalan paraniz:" + (cuzdan - (adet * 60)));
                            cuzdan = cuzdan - (adet * 60);
                        }
                            else
                        {
                            Console.WriteLine("Bu satin alma icin yeterli paraniz yok. Kalan paraniz: " + cuzdan);
                        }
                        break;
                    default: break;
                }
            }
            Console.WriteLine("Alisverisiniz sonrasi kalan paraniz :" + cuzdan + ". Yine bekleriz:)");
        }
    }
}
