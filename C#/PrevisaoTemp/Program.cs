using System;

namespace PrevisaoTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a Previsão: Frio , Calor ou Chuva ???");
            string previsao = Console.ReadLine();
            
            if(previsao .Equals("Frio")){
                Console.WriteLine("Vamos à montanha");
            }
            else if(previsao .Equals("Calor")){
                Console.WriteLine("Vamos à praia");
            }
            else if(previsao .Equals("Chuva")){
                
                Console.WriteLine("Vamos para a steam? Sim ou Não");
                string resposta = Console.ReadLine();
                    if(resposta .Equals("Não")){
                        Console.WriteLine("Vamos para a Netflix");
                    }
            }
        }
    }
}
