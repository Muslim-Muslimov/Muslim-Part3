

namespace Muslim_Part
{
    internal class ArrayInversion
    {
        public static void Start()
        {
            int[] chisla = { 12, 4, 3, -2, 1, 9, 0 };
            int vtoroiElement = chisla[1];
            for (int i = 0; i < chisla.Length; i++)
            {
                int chislo = vtoroiElement * chisla[i];
                Console.Write(chislo + " "); 
            }
        }

    }
}
