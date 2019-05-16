using System;

namespace SegundoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Nota do primeiro bimestre
            float n1 = 5;
            //Nota do segudo bimestre
            float n2 = 7;
            //Nota do terceiro bimestre
            float n3 = 6;
            
            float resutadoSoma = n1 + n2 + n3;

            float resultadoDivisao = resultadoSoma / 3;

            Console.WriteLine(resultadoDivisao);
        }
    }
}
