using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class insan
        {
            public string isim;
            public int yas;
            public void yurume()
            {
                Console.WriteLine("Yuruyor");
            }
           
        }
        static void Main(string[] args)
        {
            insan i1= new insan();

            i1.isim = "Tarik";
            i1.yas = 19;
            Console.WriteLine(i1.isim+" "+i1.yas);
            i1.yurume();

        }
    }
}
