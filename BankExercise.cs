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

            if (summaVklada < 100)
                summaVklada = (summaVklada * 0.05) + summaVklada;

            else if (100 < summaVklada && summaVklada < 200)
                summaVklada = (summaVklada * 0.07) + summaVklada;

            else if (summaVklada > 200)
                summaVklada = (summaVklada * 0.10) + summaVklada;

            Console.WriteLine(summaVklada);


        }
    }
}
