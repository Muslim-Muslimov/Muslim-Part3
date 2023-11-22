using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muslim_Part
{
    internal class MagicNumbers
    {
        /*Нужно создать программу для нахождения магических чисел в массиве. 
         * Магическим числом называется число, которое:
         *  1. Чётное.
         *  2. Если его умножить на 2, результат также есть в массиве.
         *   
         *   Задание:
         *  Создайте одномерный массив из 20 элементов, заполненный случайными
         *  числами в диапазоне от 1 до 100.
         *  
  Найдите и выведите все магические числа из этого массива. 
        Если магическое число найдено, не проверяйте следующие условия для текущего числа 
        (используйте continue). Если магическое число не найдено во всем массиве, 
        выведите сообщение об этом. */
        public static void Start()
        {
            Random randomizer = new Random();

            // создаем массив из 20 элементов
            int[] massivSluchChisel = new int[20];

            // заполняем случайными числами
            for (int i = 0; i < massivSluchChisel.Length; i++)
            {
                massivSluchChisel[i] = randomizer.Next(1, 101);
            }

            // отоброжаем все элементы массива как строку разделенную через запятую
            Console.WriteLine(string.Join(",", massivSluchChisel));
            bool found = false;
            
                                    // поиск магических чисел
            foreach (int chislo in massivSluchChisel)
            {
                // проверка на четность
                bool isEven = (chislo % 2) == 0;
                if (!isEven)
                {
                    continue;
                }
                int chisloX2 = chislo * 2;

                // проверяем содержит ли массив текущее число умноженное на 2
                bool containsChisloX2 = massivSluchChisel.Contains(chisloX2);
                if (!containsChisloX2)
                {
                    continue;
                }
                found = true;

                Console.WriteLine($"Magic Number = : {chislo} ");


            }
            // выдает нету если не находит маг число
            if (found == false)
            {
                Console.WriteLine("nety");
            }




        }
    }
}
