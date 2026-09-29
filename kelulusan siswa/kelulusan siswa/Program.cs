using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kelulusan_siswa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // praktik 2
            // program kelulusan siswa

            Console.Write("Nama Siswa: ");
            string nama = Console.ReadLine();
            Console.Write("Nilai: ");
            int nilai = Convert.ToInt32(Console.ReadLine());

            if (nilai < 0 || nilai > 100)
            {
                Console.WriteLine("Nilai tidak valid");
            } 
            else if (nilai >= 75)
            {
                Console.WriteLine(nama + "Dinyatakan tuntas.");
            } 
            else
            {
                Console.WriteLine(nama + "dinyatakan belum tuntas.");
            }
        }
    }
}
