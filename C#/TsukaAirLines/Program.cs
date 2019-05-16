using System;

namespace TsukaAirLines
{
    class Program
    {
        static void Main(string[] args)
        {

            bool sair = false;
            Passageiro[] passageiros = new Passageiro[2];
            int numPassageiros = 0;
            Console.WriteLine("Seja Bem-Vindo(a) à Tsuka aIRLINES");
        
            do{

                System.Console.WriteLine("Escolha uma opçâo:");
                System.Console.WriteLine("1 - Registrar Passageiro");
                System.Console.WriteLine("2 - Exibir Passageiro");
                System.Console.WriteLine("0 - Sair");

                int codigo = int.Parse(Console.ReadLine());

                switch(codigo) {
                    case 1:
                        Passageiro p = new Passageiro();
                        System.Console.WriteLine("Digite o seu nome");
                        p.setNome(Console.ReadLine());
                        
                        passageiros[numPassageiros] = p;
                        numPassageiros++;
                        System.Console.WriteLine("Cadastro concluido");
                    break;
                    case 2:
                        foreach(var passageiro in passageiros)
                        {
                            if (passageiro != null)
                            {
                                System.Console.WriteLine(passageiro.getNome());
                            }
                        }
                    break;
                }        
            } while(!sair);

        }
    }
}
