using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muslim_Part
{
    internal class WeatherInformation
    {
        public static void Start()
        {
            // создаем массивы
            int[] temperatures = new int[30];
            int[] precipitation = new int[30];
            // заполняем массивы рандомом
            Random number = new Random();
            for (int i = 0; i < temperatures.Length; i++)
            {
                temperatures[i] = number.Next(-60, 60);

            }
            for (int i = 0; i < precipitation.Length; i++)
            {
                precipitation[i] = number.Next(0, 100);
            }
            // создаем общую температуру за все дни, для дальнейшего деления
            int totalTemperature = 0;

            for (int i = 0; i < temperatures.Length; i++)
            {
                totalTemperature = totalTemperature + temperatures[i];
            }
            // находим средную температуру
            int averageTemperature = totalTemperature / temperatures.Length;
            Console.WriteLine($"Средняя месячная температура: {averageTemperature}");
            // создаем переменные минимальной и максимальной температуры
            int minTemperature = temperatures[0];
            int maxTemperature = temperatures[0];

            for (int i = 0; i < temperatures.Length; i++)
            {
                if (minTemperature < temperatures[i])
                {
                    minTemperature = temperatures[i];
                }
                if (maxTemperature > temperatures[i])
                {
                    maxTemperature = temperatures[i];
                }

            }
            // находим индекс дня минимальной температуры
            int minIndex = temperatures.ToList().IndexOf(minTemperature);
            Console.WriteLine($"Индекс дня минимальной температуры: {minIndex}");
            // находим индекс дня максимальной температуры
            int maxIndex = temperatures.ToList().IndexOf(maxTemperature);
            Console.WriteLine($"Идекс дня максимальной температуры: {maxIndex}");

            // считаем общее количество осадков за месяц

            int totalPrecipitation = 0;
            for (int i = 0; i < precipitation.Length; i++)
            {
                totalPrecipitation += precipitation[i];
            }
            Console.WriteLine($"Общее количество осадков за месяц: {totalPrecipitation}");

            // Находим среднее количество осадков
            int averagePrecipitation = totalPrecipitation / precipitation.Length;
            // создаем новый массив (Мовсар, объясни этот момент поподробнее)
            int[] dniVyshesrednevo = { };
            int x = 0;
            foreach (int precipitations in precipitation)
            {
                if (precipitations > averagePrecipitation)
                {
                    Array.Resize(ref dniVyshesrednevo, dniVyshesrednevo.Length + 1);
                    dniVyshesrednevo[x] = precipitations;
                    x++;
                }
            }
            Console.WriteLine($"Количество дней с осадками выше среднего: {dniVyshesrednevo.Length}");
            // выводим индексы дней с заморозками и увеличением осадков по сравнению с пред днем

            Console.Write("Индексы дней с заморозками и увеличением осадков по сравнению с предыдущим днем; ");
            for (int i = 1; i < precipitation.Length; i++)
            {
                if (temperatures[i] < 0 && precipitation[i] > precipitation[i - 1])
                {
                    int badDays = i;
                    Console.Write($"{badDays}, "); // Для запятых

                } 
            }


        }


    }
}
