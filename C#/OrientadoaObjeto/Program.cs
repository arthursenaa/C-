﻿using System;

namespace OrientadoaObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            System.Console.WriteLine("Digite sua senha");
            usuario.setSenha(Console.ReadLine());
            string senha = usuario.getSenha();
            System.Console.WriteLine("Sua senha è: "+ senha);


            
        }
    }
}
