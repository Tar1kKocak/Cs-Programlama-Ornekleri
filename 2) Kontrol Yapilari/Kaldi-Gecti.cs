using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaldi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Yazilimin Amaci: Vize ve final notlarına göre öğrencinin geçme durumunu hesaplayan program

            float vizenot,finalnot,toplamnot;

            Console.WriteLine("Lutfen notunuzu giriniz.");
            vizenot = float.Parse(Console.ReadLine());

            Console.WriteLine("Lutfen final notunuzu giriniz.");
            finalnot = float.Parse(Console.ReadLine());

            toplamnot = (vizenot + finalnot) / 2;

            if (toplamnot >= 50)
            {
                Console.WriteLine("Tebrikler bu dersten gectiniz.");
                Console.WriteLine("Notunuz:" + toplamnot);
            }
            else
            {
                Console.WriteLine("Bu dersten gecemediniz.");
                Console.WriteLine("Notunuz:" + toplamnot);

            }
        }
    }
}
