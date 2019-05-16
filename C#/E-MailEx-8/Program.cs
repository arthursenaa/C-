using System;

namespace E_MailEx_8
{
    class Program
    {
        static void Main(string[] args)
        {

            bool emailInvalido = true;
            do{
                Console.WriteLine("Ensira seu E-Mail");
                string email = Console.ReadLine();

                if(email.Contains("@") && email.Contains(".")){
                    emailInvalido = false;
                    Console.WriteLine("E-Mail Válido");
                }else{
                    Console.WriteLine("Dígite um e-mail válido");
                }
            
                
            }while(emailInvalido);
        }
    }
}
