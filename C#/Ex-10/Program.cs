using System;

namespace Ex_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número");
            int numero = int.Parse(Console.ReadLine());
            int QuantidadeDePares = 0;
            for(int i = 0; i<= numero ;i++){
                if (i % 2 == 0){
                    Console.WriteLine(i);
                    QuantidadeDePares++;
                }
            }//FIM FOR
            Console.WriteLine("A quantidade de Pares é: {0}",QuantidadeDePares);
        }   
    }
}
