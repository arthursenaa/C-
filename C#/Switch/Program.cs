using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string passeio = "montanha";

            switch(passeio) {
                case "deserto":
                    Console.WriteLine("leva uma água!");
                    break;
                case "floresta":
                    Console.WriteLine("Vai lá, Tarzan!");
                    break;
                case "montanha":
                    Console.WriteLine("Bora escalar!");
                    break;
                default:
                    Console.WriteLine("Ah, bora assistir Netflix");
                    break;     
            }

            Console.WriteLine("Acabou o programa, mizerávi!";)
        }
    }
}
