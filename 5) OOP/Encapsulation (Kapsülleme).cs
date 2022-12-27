using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        //Kapsülleme // Bilgilerin Gizlenmesi
        class futbolcu
        {
            private int bonservisucret;
            public int getbonservisucret()
            { 
                return bonservisucret;
            }
            public void setbonserbisucret(int fiyat)
            {
                this.bonservisucret = fiyat;
            }

        }
        static void Main(string[] args)
        {
            futbolcu f1= new futbolcu();
            f1.setbonserbisucret(150000000);
             Console.WriteLine(f1.getbonservisucret());
        }
    }
}
