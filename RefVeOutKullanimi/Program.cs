using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefVeOutKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            int carpim;
            int toplam = ToplaVeCarp(5, 10, out carpim);
            Console.WriteLine("Toplam: " + toplam + " Çarpım: " + carpim);

            int bolum = 0;
            int fark = CikarVeBol(10, 5, ref bolum);
            Console.WriteLine("Fark: " + fark + " Bölüm: " + bolum);

            Console.ReadLine();
        }
        static int ToplaVeCarp(int sayi1, int sayi2, out int carpim)
        {
            carpim = sayi1 * sayi2;
            return sayi1 + sayi2;
        }
        static int CikarVeBol(int sayi1, int sayi2, ref int bolum)
        {
            bolum = sayi1 / sayi2;
            return sayi1 - sayi2;
        }   
    }
}
