using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Yazilimin Amaci: Üssü kuvvetini bulmak.

            int dogru = 0, yanlis = 0, sayi, i=1;

            while (i < 6)
            {
                Console.WriteLine(+i + "sayisinin karesini giriniz.");
                sayi=int.Parse(Console.ReadLine());

                if (i * i == sayi)
                {
                    dogru++;
                }
                else if(i * i != sayi)
                {
                    yanlis++;
                }

                i++;
            }
            Console.WriteLine(+dogru + "dogru" + yanlis + "yanlis");

        }
    }
}
