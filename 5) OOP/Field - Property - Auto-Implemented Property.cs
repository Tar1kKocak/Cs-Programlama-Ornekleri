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
            string isim; //field - alan
            int yas;

            //private string cinsiyet;    Auto sayesinde bu otomatik oluşmuş oluyor.
            public string Isim  //property - mülk
            {
                get { return isim;} //almak
                set { isim = value;} //kurmak
            }
            public int Yas  //property - mülk
            {
                get { return yas;}
                set {if(value>=0) yas = value;}
            }
            
            //Auto-implemented property

            public string Cinsiyet { get; set; }

            public string Random { get; private set; } //read-only
            public string Hesap {private get; set;} //write-only


        }
        static void Main(string[] args)
        {
            insan i1 = new insan();
            i1.Isim = "Tarik Kocak";
            i1.Yas = 19;
            i1.Cinsiyet = "Erkek";
            Console.WriteLine(i1.Isim);
            Console.WriteLine(i1.Yas);
            Console.WriteLine(i1.Cinsiyet);


        }
    }
}
