﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(String[] args)
    {
        for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
        {
            for (int contador = 0; contador <= 10; contador++)
            {
                Console.Write(multiplicador + " * " + contador + " = " + multiplicador * contador);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
