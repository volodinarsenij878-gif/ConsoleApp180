using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program31
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Первый символ: ");
            string s1 = Console.ReadLine();
            Console.Write("Второй символ: ");
            string s2 = Console.ReadLine();

            if (s1.Length != 1 || s2.Length != 1)
            {
                Console.WriteLine("Введите ровно по одному символу.");
                return;
            }

            char c1 = s1[0];
            char c2 = s2[0];

            Console.WriteLine(c1 == c2 ? "Совпадают" : "Не совпадают");
        }
    }
}