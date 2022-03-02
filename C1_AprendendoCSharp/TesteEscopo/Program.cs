// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testando escopos");

        int idade = 20;
        int quantidadePessoas = 3;
        bool acompanhado = true;

        if (quantidadePessoas >= 2)
        {
            acompanhado = true;
        }
        else
        {
            acompanhado = false;
        }

        if (idade >= 18 || acompanhado)
        {
            Console.WriteLine("Seja bem vindo!");
        }
        else
        {
            Console.WriteLine("infelizmente, voce não pode entrar.");
        }

    }
}
