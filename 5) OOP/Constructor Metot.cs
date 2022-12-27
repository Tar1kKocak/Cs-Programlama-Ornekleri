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
            string isim;
            int yas;

            public insan()
            {
                Console.WriteLine("Yeni bir obje yaratildi");
            }
            public insan(string isim) 
            { 
                this.isim = isim;
            }
            public void bilgigoster()
            {
                Console.WriteLine("Adım {0} yasim {1}", isim, yas);
            }
            public insan(string isim, int yas) 
            {
                this.yas = yas;
                this.isim = isim;
            }
        }
        static void Main(string[] args)
        {
            insan i1= new insan();
            insan i2= new insan("Tarik Kocak");
            i2.bilgigoster();
            insan i3 = new insan("Efsa", 17);
            i3.bilgigoster();

        }
    }
}
