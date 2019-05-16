using System;

namespace Ex_12 {
    class Program {
        static void Main (string[] args) {
            int mulheres = 0;
            int homens = 0;
            
            int pesom = 0; //peso feminino
            int pesoh = 0; // peso masculino
            
            int idadeh = 0; //idade masculina
            int idadem = 0; //idade feminina
            for (int i = 0; i < 3; i++) {
                Console.WriteLine("");
                Console.WriteLine ("Você é homem ou mulher");
                string sexo = Console.ReadLine ();

                if (sexo.ToLower ().Equals ("mulher")) {
                    mulheres++;

                    Console.WriteLine ("Digite a sua idade");
                    int idadm = int.Parse (Console.ReadLine ());
                    idadem = idadm + idadem;
                    
                    Console.WriteLine("Qual o seu peso?");
                    int pesm = int.Parse(Console.ReadLine());
                    pesom = pesom + pesm;
                    
                } if(sexo.ToLower().Equals("homem")) {
                    Console.WriteLine ("Digite a sua idade");
                    int idadh = int.Parse (Console.ReadLine ());
                    idadeh = idadeh + idadeh;
                    
                    homens++;

                    Console.WriteLine("Qual o seu peso?");
                    int pesh = int.Parse(Console.ReadLine());
                    pesoh = pesoh + pesh;
                }
                //Console.WriteLine(pesom/3);
            }
                Console.WriteLine("Existem {0} mulheres e {0} homens. A média de peso das mulheres é de {0}Kg enquanto a média de peso dos homens é de {0}Kg .A  média das idades dos homens é {0} e das mulheres é {0}", mulheres , homens, pesom/mulheres, pesoh/homens, idadeh/homens ,idadem/mulheres);
            
        }
    }
}