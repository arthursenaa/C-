using System;

namespace DadosDoAlunoAprovado
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[10];
            string[] sobrenome = new string[10];
            int[] nascimento = new int[10];
            float[] nota1 = new float[10];
            float[] nota2 = new float[10];

            for (int i = 0; i < nome.Length; i++)
            {
                System.Console.Write($"Nome do {i+1}° aluno: ");
                nome[i] = Console.ReadLine();
                
                System.Console.Write($"Sobrenome do {i+1}° aluno:");
                sobrenome[i] = Console.ReadLine();
                
                System.Console.Write($"Ano de nascimento do {nome[i]} {sobrenome[i]}:");
                nascimento[i] = int.Parse(Console.ReadLine());
                
                System.Console.Write("A primeira nota do aluno é:");
                nota1[i] =float.Parse(Console.ReadLine());

                System.Console.Write("A segunda nota do aluno é:");
                nota2[i] =float.Parse(Console.ReadLine());
                
                float media= ((nota1[i] + nota2[i])/2);
                int idade = 2019 - nascimento[i];

                if(media >= 50){
                    System.Console.WriteLine($"{nome[i]} {sobrenome[i]} de {idade} anos. Foi Aprovado com média {media}");
                }if(media < 50){
                    System.Console.WriteLine($"{nome[i]} {sobrenome[i]} de {idade} anos. Foi Reprovado com média {media}");
                }//Fim if
            }//Fim do for
        }
    }
}
