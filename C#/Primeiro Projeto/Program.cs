using System;

namespace Primeiro_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string sobrenome;
            string nomeCompleto;

            Console.WriteLine("Digite seu nome:");//Exibe na Tela
            nome = Console.ReadLine();//Efetua a leitura e armazena o que for digitado
            Console.WriteLine("Digite seu sobrenome");
            sobrenome = Console.ReadLine();

            nomeCompleto = nome+" "+sobrenome;
            
            Console.WriteLine("Bem vindo "+nome+" "+sobrenome);       
        }
    }
}
