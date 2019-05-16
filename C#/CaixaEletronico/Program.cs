using System;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            int[] nota = {100 ,50 ,20 ,10 ,5 ,2 ,1};
            //int dinheiro = nota[];
            Console.WriteLine("Quanto você quer sacar?");
            int saque = int.Parse(Console.ReadLine());

            int quantidade = 0; 
            int quantidade1 = 1;
            int quantidade2 = 1;

            int saque1 = saque -(saque/nota[0]);
            int saque2 = (saque - saque1) -(saque/nota[1]);
            for(int i = 0; i<=10;i++){
                
                if (saque > 100)
                {   
                    quantidade = saque/nota[0];
                
                }if( saque1 > 50 && saque1 <100){
                    quantidade1 = saque/nota[1];
                
                }if( saque2 > 20 && saque2 < 50){
                    quantidade2 = saque1/nota[2];
                    quantidade2++;
                }
                
                
                //int resultado = saque/quantidade;
                //saque = saque - (resultado*quantidade);
            }
            Console.Write($"Você recebera {quantidade} notas de R$ 100 , {quantidade1} de notas de R$50 , {quantidade2} de notas de R$20");
            
        }
    }
}
