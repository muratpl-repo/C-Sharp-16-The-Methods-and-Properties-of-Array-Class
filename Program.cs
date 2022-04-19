using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57DersDizilerinBaziOzelikleriVeMetotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 2, 3, 10};
            int[,,,,,] sayilar2 = new int[2, 2, 2, 3, 4, 5];
            Console.WriteLine(sayilar.Length); //Dizinin eleman sayisi
            Console.WriteLine(sayilar2.Rank); //Dizinin kac boyutlu oldugunu soyler
            Console.WriteLine(sayilar.Max()); //Dizideki en buyuk elemani verir
            Console.WriteLine(sayilar.Min()); //Dizideki en kucuk elemani verir
            Console.WriteLine(sayilar.Sum()); //Dizideki elemanlarin toplamini verir
        }
    }
}
