using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Yazilimin Amaci: Kullanicidan alinan baslangic ve bitis degerleri arasındaki sayılardan 2 ile tam bölünenlerin yanına "a",3 ile tam bölünenlerin yanına "b"
      hem 2 hem de 3'e bölünenlerin sonuna "ab" yazdırınız ve sayı 5'e bölünüyorsa hiçbir şey yazmadan döngüde sonraki değerlere bakmaya devam eden
      program. */

            int baslangic, bitis,sayi;

            Console.WriteLine("Baslangic degeri giriniz.");
            baslangic=int.Parse(Console.ReadLine());
            Console.WriteLine("Bitis degeri giriniz.");
            bitis=int.Parse(Console.ReadLine());
            sayi = baslangic;

            while (sayi < bitis)
            {
                if(sayi%5== 0)
                {
                    sayi++;
                    continue;
                }
                else if(sayi%2== 0 && sayi%3==0) {

                    Console.WriteLine(+sayi + ":ab");
                }
                else if (sayi % 2 == 0)
                {
                    Console.WriteLine(+sayi + ":a");
                }
                else if(sayi%3 == 0)
                {
                    Console.WriteLine(+sayi + ":b");
                }
                sayi++;
            }
        }
    }
}
