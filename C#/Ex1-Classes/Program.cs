﻿using System;

namespace Ex1_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo - Sportore Bank");

            ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = "Cesar";
            conta1.agencia = 132;
            conta1.numeroConta = 999;
            conta1.Depositar(10000);

            ContaCorrente conta2 = new ContaCorrente();
            conta2.titular = "Tsukamoto";
            conta2.agencia = 132;
            conta2.numeroConta = 1;
            conta2.Depositar(5000);

            System.Console.WriteLine($"----Primeira Conta----");
            System.Console.WriteLine($"Titular: {conta1.titular}");
            System.Console.WriteLine($"Agência: {conta1.agencia}");
            System.Console.WriteLine($"Número da conta: {conta1.numeroConta}");
            System.Console.WriteLine($"Saldo: R${conta1.ExibirSaldo()}");
            System.Console.WriteLine("----------------------");

            System.Console.WriteLine($"----Segunda Conta----");
            System.Console.WriteLine($"Titular: {conta2.titular}");
            System.Console.WriteLine($"Agência: {conta2.agencia}");
            System.Console.WriteLine($"Número da conta: {conta2.numeroConta}");
            System.Console.WriteLine($"Saldo: R${conta2.ExibirSaldo()}");
            System.Console.WriteLine("----------------------");

            //System.Console.Write("Quanto Você quer sacar:");
            //conta1.Sacar(double.Parse(Console.ReadLine()));
            //bool valorRetornado = conta1.Sacar(3500);
            //if(valorRetornado){
            //    System.Console.WriteLine("Parabèns você conseguiu!!!");
            //}else{
            //    System.Console.WriteLine("Você nâo tem dinheiro na conta");
            //}

            //System.Console.WriteLine($"Saldo depois do saque: {conta1.ExibirSaldo()}");
        
            conta2.Transferir(100, conta1);

            System.Console.WriteLine($"Saldo conta 1 R${conta1.ExibirSaldo()}");
            System.Console.WriteLine($"Saldo conta 2 R${conta2.ExibirSaldo()}");
        }
    }
}
