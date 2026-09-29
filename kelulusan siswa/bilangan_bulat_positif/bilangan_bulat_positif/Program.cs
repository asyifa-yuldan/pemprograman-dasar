using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilangan_bulat_positif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // praktik 1
            // menentukan bilangan positif, negatif, atau nol
            // menggunakan if-else if-else dan operator perbandingan

            Console.Write("Masukkan bilangan: ");
            int angka = Convert.ToInt32(Console.ReadLine());

            if (angka > 0)
            {
                Console.WriteLine("Bilangan positif");
            } 
            else if (angka < 0)
            {
                Console.WriteLine("Bilangan negatif");
            } 
            else
            {
                Console.WriteLine("Bilangan nol");
            }
        }
    }
}
