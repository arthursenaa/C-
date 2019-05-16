using System;

namespace par_ou_impar
{
    class Program
    {
        static void Main(string[] args)
        {   
            

            Console.WriteLine("Você quer jogar Par ou Impar ?");
            string resposta = Console.ReadLine();
            if(resposta .ToLower().Equals("sim")){
                Console.WriteLine("Então vamos começar");
                Console.WriteLine("Você quer Par ou Impar?");
                string escolha = Console.ReadLine();

                if(escolha .ToLower().Equals("par")){
                    Console.WriteLine("Eu fico com Impar!");
                } else {
                    Console.WriteLine("Eu fico com Par");
                }

                Console.WriteLine("Escolha um número de 0 a 10");
                int n1 = int.Parse(Console.ReadLine());
                if( n1 > 10){
                    Console.WriteLine("Você não sabe brincar!!!");
                }else{
                    Random r = new Random();
                int numeroPC = r.Next(0,10);

                Console.WriteLine("Eu escolhi o número " + numeroPC);

                int soma;
                int res;
                soma = n1 + numeroPC;
                res = soma %2 ;

        

                if(res == 0){
                    Console.WriteLine("PAR Venceu!!");
                } else {
                    Console.WriteLine("IMPAR Venceu!!");
                }

                }

                
            }else if (resposta .ToLower().Equals("nao")){
                Console.WriteLine("Então ok, Até mais!");
                
            }
        }
    }
}
