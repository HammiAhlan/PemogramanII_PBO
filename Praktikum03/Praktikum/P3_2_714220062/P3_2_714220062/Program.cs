using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714220062
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("MASUKKAN BUDAK AYAM\n------------------------------");
            Console.Write("\nMasukan Imputan BUDAK Ayam: ");

            int ayam = Convert.ToInt32(Console.ReadLine());
            if (ayam >= 1 && ayam <= 10)
            {
                for (int i = ayam; i >= 1; i--)
                {
                    Console.WriteLine($"Anak ayam turunlah {i}, mati satu tinggallah {i - 1}");
                }
                Console.WriteLine("Mati satu tinggallah i");
            }
            else
            {
                Console.WriteLine("Nilai tidak boleh dibawah 1 atau diatas 10");
            }
        }
    }
}
