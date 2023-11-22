using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muslim_Part
{
    internal class SravnenieDbuhChisel
    {
        public static void Start()
        {
            Console.WriteLine("Введите числа для сравнения: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 < n2)
                Console.WriteLine($"{n1} меньше {n2}");
            else if (n1 > n2)
                Console.WriteLine($"{n1} больше {n2}");
            else
                Console.WriteLine($"{n1} равно {n2}");
        }
    }
}
