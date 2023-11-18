namespace Muslim_Part
{
    internal class Program
    {
        static void Main(string[] args)
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