using System;

namespace TempAnual
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] TempMedia = new int[12];
            int maior, menor;
            maior = TempMedia[0];
            menor = TempMedia[0];

            for (int i = 0; i < TempMedia.Length; i++)
            {   
                System.Console.WriteLine($"Qual a temperatura média do mês {i}");
                TempMedia[i] = int.Parse(Console.ReadLine());

                if(TempMedia[i] > maior){
                    maior = TempMedia[i];
                }
                if(TempMedia[i] < menor){
                    menor =TempMedia[i];
                }
            }

            System.Console.WriteLine($"A maior temperatura do ano foi {maior} e a menor é {menor}");
        }
    }
}
