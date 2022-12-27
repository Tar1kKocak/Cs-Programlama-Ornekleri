using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class bankakonusma
        {
            public void selamla1()
            {
                Console.WriteLine("Bankamiza Hosgeldiniz");
            }
            public void selamla2()
            {
                Console.ReadLine();
            }
            public void seceneksor1()
            {
                Console.WriteLine("Yapmak istediginiz islemi seciniz.");
                Console.WriteLine("1-Para Yatirma\n2-Para Cekme\n3-Bakiye Sorgulama\n4-Islem Sonlandirma");
            }
           
           public void miktarsor()
            {
                Console.WriteLine("Ne kadar yatirmak istiyorsunuz?");
            }
            public void miktarsor2()
            {
                Console.WriteLine("Ne kadar cekmek istiyorsunuz?");
            }
        }
        class bankaislem
        {

            private int bakiye = 24000;

            public void  parayatir(int miktar)
            {
                bakiye += miktar;
            }
            public void paracekme(int miktar)
            {
                bakiye -= miktar;
            }
            public int bakiyesorgu()
            {
                return bakiye;
            }



        }
        static void Main(string[] args)
        {
            int secenek,miktar;

            bankakonusma calisan = new bankakonusma();
            bankakonusma musteri = new bankakonusma();
            bankaislem islemler = new bankaislem();

            calisan.selamla1();
            musteri.selamla2();
         
                baslangic:
                calisan.seceneksor1();
                secenek = int.Parse(Console.ReadLine());

                if (secenek == 1)
                {
                    calisan.miktarsor();
                    miktar = int.Parse(Console.ReadLine());
                    islemler.parayatir(miktar);
                    goto baslangic;
                                        
                }
                if (secenek == 2)
                {
                    calisan.miktarsor2();
                    miktar = int.Parse(Console.ReadLine());
                    islemler.paracekme(miktar);
                    goto baslangic;
                }
                if (secenek == 3)
                {
                    Console.WriteLine(islemler.bakiyesorgu());
                    goto baslangic;
                }

                if (secenek == 4)
                {
                Console.WriteLine("Bizi tercih ettiginiz icin tesekkur ederiz. Iyi gunler dileriz.");
                }
                else
                {
                Console.WriteLine("Gecersiz rakam girdiniz.");
                goto baslangic;
                }
        }
    }
}
