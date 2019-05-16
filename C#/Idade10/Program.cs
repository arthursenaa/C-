using System;

namespace Idade10 {
    class Program {
        static void Main (string[] args) {
            int maiores = 0;
            for (int i = 0; i < 10; i++) {
                Console.WriteLine ("Digite a sua idade");
                int idade = int.Parse (Console.ReadLine ());
                if (idade >= 18) {
                    maiores++;
                }
            }
            Console.WriteLine (maiores);
        }
    }
}