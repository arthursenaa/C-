using System;

namespace Ex3Media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a Primeira Nota:");
            float nota1 = float.Parse(Console.ReadLine());
        
            Console.WriteLine("Digite a Seguda Nota:");
            float nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Terceira Nota:");
            float nota3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de faltas:")
            int faltas = int.Parse(Console.ReadLine());

            float M = (nota1 + nota2 + nota3);

            float media = M/3;

            Console.WriteLine("Sua média é "+media);

            if (media < 5 || faltas > 25){
                Console.WriteLine("Reprovado");
            }else if (media < 9){
                Console.WriteLine("Aprovado");
            }else{
                Console.WriteLine("Isso aí, jovem! "); 
            }
        }
    }
}
