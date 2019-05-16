using System;

namespace Ex6Menu {
    class Program {
        static void Main (string[] args) {

            Console.WriteLine ("Aplicação - Criando Menus");
            bool repetir = true;
            while (repetir) {

                Console.WriteLine ("Selecione uma opção desejada");

                Console.WriteLine (" 1 - Efetuar Login ");
                Console.WriteLine (" 2 - Listar Contatos ");
                Console.WriteLine (" 3 - Listar Comentarios");
                Console.WriteLine (" 9 - Sair ");

                int opcao = int.Parse (Console.ReadLine ());

                switch (opcao) {
                    case 1:
                        Console.WriteLine ("Qual o seu login");
                        string usuario = Console.ReadLine ();

                        Console.WriteLine("Bem vindo {0}",usuario);
                        Console.WriteLine("Aperte enter para voltar pro inicio");
                        Console.ReadLine();

                        break;
                    case 2:
                        Console.WriteLine ("Sua Lista de Contatos é:");
                        Console.WriteLine ("9 1111-1111");
                        break;
                    case 3:
                        Console.WriteLine ("Lista de comentários");
                        Console.WriteLine ("Lorem ipsum dolor sit amet, consectetur adipiscing elit");
                        break;
                    default:
                        Console.WriteLine ("Fim");
                        repetir = false;
                        break;
                }
            } //fim while
        }
    }
}