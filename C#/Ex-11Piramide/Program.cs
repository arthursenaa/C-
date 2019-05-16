using System;

namespace Ex_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de andares da piramide");
            int andares = int.Parse(Console.ReadLine());
            
            for( int num = 0; num <= andares; num++ ){
                for(int i = 0; i<=num; i++){
                    Console.Write("*");
                }
                Console.WriteLine("");
                
            }//FIM FOR
            
        }
    }
}
