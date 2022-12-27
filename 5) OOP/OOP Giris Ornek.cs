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
            public void selamver()
            {
                Console.WriteLine("Merhaba");
            }
            public void bilgisor()
            {
                Console.WriteLine("Adın ne ve yasin kac");
            }
            
            public void cevapver()
            {
                Console.WriteLine("Benim Adim " + isim + " ve yasim " + yas);
            }
            public void isimyasduzenle(string isim,int yas)
            {
                this.isim = isim;
                this.yas = yas;
            }
        }
        static void Main(string[] args)
        {
            insan i1= new insan();
            insan i2= new insan();

            i1.isimyasduzenle("Tarik", 19);
            i2.isimyasduzenle("Efsa", 17);

            i1.selamver();
            i2.selamver();
            i1.bilgisor();
            i2.cevapver();
            i2.bilgisor();
            i1.cevapver();
        }
    }
}
