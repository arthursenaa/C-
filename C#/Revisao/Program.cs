using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUal tabuada você deseja saber?");
            int tabuada = int.Parse(Console.ReadLine());
            
                Console.WriteLine("A tabuada do {0} é: ",tabuada);
            int contador = 0;
            while(contador <=10 ){

                Console.WriteLine(tabuada*contador);

                contador = contador +1;
            }//fim while
        }
    }
}
