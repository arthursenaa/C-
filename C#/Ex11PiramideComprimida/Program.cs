using System;

namespace Ex11PiramideComprimida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de andares da piramide");
            int andares = int.Parse(Console.ReadLine());
            string estrela = "";

            for( int num = 0; num <= andares; num++ ){
                estrela += "*";
                Console.WriteLine(estrela);    
            }
        }
    }
}

