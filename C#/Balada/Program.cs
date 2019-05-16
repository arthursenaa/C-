using System;

namespace Balada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você tem mais de 18 anos?");
            string idade = Console.ReadLine();

            Console.WriteLine("Você tem disponibilidade no sabado?");
            string dia = Console.ReadLine();

            if(dia.ToLower().Equals("sim") && idade .ToLower().Equals("sim")){    /*ToLower para deixar a variavel minuscula --- && para e (and) --- .Equals para igualdade */
                Console.WriteLine("Você tem pulseira vip ou ingresso ?");
                string entrada = Console.ReadLine();

                if(entrada .ToLower().Equals("sim")){/*if = se */
                    Console.WriteLine("SEXTOOOOU!");
                }

                else {
                    Console.WriteLine("Você nâo pode ir");
                }
            }
            else {
                    Console.WriteLine("Você nâo pode ir");
                }

        }
    }
}
