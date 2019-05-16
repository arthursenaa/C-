using System;

namespace forEx_9
{
    class Program
    {
        static void Main(string[] args)
        {   
            for(int num = 0; num <= 100; num++){
                Console.WriteLine(num);
                
                if( num % 4 == 3){
                    Console.ForegroundColor = ConsoleColor.Blue; //mudar cor
                    //Console.WriteLine(num++);
                } else {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            }
        }
    }
}
