using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = {1,2,4,6,7,13,42,64,32,33,55,67,98,75,87};//<-<-- Array
            int impares = 0;

            for (int i = 0; i < numeros.Length; i++)//Todo array sabe seu tamanho (numeros.lenght)
            {
                if(numeros[i] % 2 != 0){
                    impares++;
                }
            }        
            Console.WriteLine($"Total de impares: {impares}");
        }
    }
}
