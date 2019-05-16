using System;

namespace PassagemAerea {
    class Program {
        static void Main (string[] args) {
            string[] nome = new string[5];
            string[] numero = new string[5];
            //string[] data = new string[5];
            DateTime[] datas = new DateTime[5];
            int contador = 0 ;

            for (int i = 0; i < 5; i++) {
                Console.WriteLine ("----- Digite o número de uma opção -----");
                Console.WriteLine ("1 - Registrar Passagem");
                Console.WriteLine ("2 - Visualizar Passagens");
                Console.WriteLine ("0 - Sair");
                string opçao = Console.ReadLine ();
                switch (opçao) {
                    case "1":
                        Console.WriteLine ("Qual o seu nome?");
                        nome[i] = Console.ReadLine ();
                        System.Console.WriteLine ("Qual o número da passagem?");
                        numero[i] = Console.ReadLine ();
                        System.Console.WriteLine ("Qual o dia dd/mm/aaaa?");
                        datas[i] = DateTime.Parse(Console.ReadLine ());
                        contador++;
                        break;

                    case "2":
                        for (int x = 1; x <= contador; x++){

                            System.Console.WriteLine ($"--- Passageiro {x} ---");
                            System.Console.WriteLine ($"nome do passageiro : {nome [x]}");
                            System.Console.WriteLine ($"Numero da passagem :{numero[x]}");
                            System.Console.WriteLine ($"Data :{datas[x]:dd/MM/yyyy}");
                            System.Console.WriteLine("");
                        }
                        break;

                    case "0":
                        System.Console.WriteLine ("--- Fim ---");
                        break;
                    
                    default :
                        System.Console.WriteLine("--- Valor Inválido ---");
                        break;

                }
            }
        }
    }
}