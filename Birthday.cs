using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muslim_Part
{
    internal class Birthday
    {
        public static void Start ()
        {
            Console.WriteLine("Год рождения?: ");
            int Год = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Месяц?: ");
            int Месяц = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("День?: ");
            int День = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Поздравляем вам {DateTime.Now.Year - Год} года, {DateTime.Now.Month - Месяц} месяцев, {DateTime.Now.Day - День} дней!");
        }



    }
}
