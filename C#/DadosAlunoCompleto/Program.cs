using System;

namespace DadosAlunoCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Notas dos alunos");
            
            string[] nomes = new string[2];
            string[] sobreNomes = new string[2];
            DateTime[] datasNascimentos = new DateTime[2];
            float[] nota1 = new float[2];
            float[] nota2 = new float[2];
            float[] medias = new float[2];
            string[] situacao = new string[2];
            
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Digite o nome do {i+1}º aluno");
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Digite o sobrenome");
                sobreNomes[i] = Console.ReadLine();

                Console.WriteLine("Digite a data de Nascimento");
                datasNascimentos[i] = DateTime.Parse(Console.ReadLine());

                Console.WriteLine($"Digita a primeira nota");
                nota1[i] = float.Parse(Console.ReadLine());

                Console.WriteLine($"Digita a segunda nota");
                nota2[i] = float.Parse(Console.ReadLine());

                medias[i] = (nota1[i]+nota2[i])/2;
                
                if(medias[i]>=50){
                    situacao[i] = "Aprovado";
                }else{
                    situacao[i] = "Reprovado";
                }
            }//fim do for

            for (int i = 0; i < 2; i++)
            {
                TimeSpan tempoVivido = (DateTime.Today - datasNascimentos[i]);
                DateTime idade = new DateTime().Add(tempoVivido).AddYears(-1);


                Console.WriteLine($"O aluno {nomes[i]} {sobreNomes[i]} de {idade.Year} está com a média {medias[i]} e sua situação é {situacao[i]}");

            }
        }
    }
}
