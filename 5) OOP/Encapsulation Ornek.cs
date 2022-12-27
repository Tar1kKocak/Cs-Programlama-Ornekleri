using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class bankahesap
        {
            private int bakiye=2300;
            public void parayatir(int miktar)
            {
                bakiye += miktar;
            }
            public void paracek(int miktar)
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
            bankahesap b1 = new bankahesap();

            b1.parayatir(1500);
            Console.WriteLine(b1.bakiyesorgu());
            b1.paracek(750);
            Console.WriteLine(b1.bakiyesorgu());

        }
    }
}
