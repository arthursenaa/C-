using System;

namespace Array_2
{
    class Program
    {
        static void Main(string[] args)
        {   
            int[] numeroCasas = new int[5];
            for (int i = 0; i < numeroCasas.Length; i++)
            {
                numeroCasas[i] = int.Parse(Console.ReadLine());                
            }

            foreach (int numeroCasa in numeroCasas)
            {
                Console.Write($"{numeroCasa},");
            }

        }
    }
}
