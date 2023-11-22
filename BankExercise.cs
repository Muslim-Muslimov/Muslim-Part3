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
            double summaVklada = Convert.ToDouble(Console.ReadLine());
            double num1 = (summaVklada * 0.05) + summaVklada;
            double num2 = (summaVklada * 0.07) + summaVklada;
            double num3 = (summaVklada * 0.1) + summaVklada;

            if (summaVklada < 100)
                Console.WriteLine($"{num1}");
            else if (100 < summaVklada & summaVklada < 200)
                Console.WriteLine($"{num2}");
            else if (summaVklada > 200)
                Console.WriteLine($"{num3}");
        }
    }
}
