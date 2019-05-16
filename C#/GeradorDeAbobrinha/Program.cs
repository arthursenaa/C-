using System;

namespace GeradorDeAbobrinha
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Escreva Uma Palavra");

            int maxPalavrasUsuario = 5;
            int maxPalavrasFrase = 5;

            string[] palavrasUsuario = new string[5];

            for (int i = 0; maxPalavrasUsuario > 0; i++)
            {
                palavrasUsuario[i] = Console.ReadLine();
                if (--maxPalavrasUsuario != 0)
                {
                    System.Console.WriteLine("Faltam " + maxPalavrasUsuario + ". Digite mais uma!");
                } else {
                    System.Console.WriteLine("Valeu, meu bom! Agora deixa comigo!");
                }

            }//Fim do for
            string[,] matrizPalavras = 
            {
                {"chinelo", "nós", "mexe", "dentro", ""},
                {"concha", "", "sempre", "louco", "atira"},
                {"jaburu", "biridim", "pulava", "", "dinossauro"},
                {"jacaré", "tilintar", "", "jão", "Péricles"},
                {"embaixo", "gado", "eu", "", "supimpa"}
            };//Fim array

            for (int i = 0; i < matrizPalavras.GetLength(0); i++)
            {
                for (int j = 0; j < matrizPalavras.GetLength(0) ; j++)
                {
                    if ("".Equals(matrizPalavras[i,j]))
                    {
                        matrizPalavras[i,j] = palavrasUsuario[j];
                    }//Fim if

                }//Fim for               
            }//fim do for

            string frase ="";
            Random r = new Random();
            for (int i = 0; i < maxPalavrasFrase; i++)
            {
                frase += matrizPalavras[r.Next(matrizPalavras.GetLength(0))//i
                                        ,
                                        r.Next(matrizPalavras.GetLength(0))] + " ";//j
            }

            System.Console.WriteLine("Minha frase é: \n" + frase);
        }
    }
}
