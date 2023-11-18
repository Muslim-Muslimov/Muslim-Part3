using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muslim_Part
{
    internal class Cakes
    {
        public static void Start()
        {
            string name1 = "Тортик";
            string name2 = "Тортище";
            string name3 = "Торт95";
            int n1 = 1507;
            int n2 = 3000;
            int n3 = 200;
            Console.WriteLine("Ху еза хьуна, Дауд?: ");
            string? name = Console.ReadLine();
            if (name == name1)
                Console.WriteLine("Дауд, тортик стоит 1507 рублей, для тебя со скидкой 1505 рублей.");
            else if (name == name2)
                Console.WriteLine("Дауд, тортище мощная вещь. Он стоит 3000 рублей.");
            else if (name == name3)
                Console.WriteLine("Дауд, торт95 стоит 200 баксов.");
            else
                Console.WriteLine("Нетю");

         }

    }
}
