using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muslim_Part
{
    internal class BankExercise
    {
        public static void Start()
        {
            Console.WriteLine("Введите сумму вклада: ");
            double num = Convert.ToDouble(Console.ReadLine());
            double num1 = (num * 0.05) + num;
            double num2 = (num * 0.07) + num;
            double num3 = (num * 0.10) + num;

            if (num < 100)
                Console.WriteLine($"{num1}");
            else if (100 < num | num < 200)
                Console.WriteLine($"{num2}");
            else if (num > 200)
                Console.WriteLine($"{num3}");
        }
    }
}
