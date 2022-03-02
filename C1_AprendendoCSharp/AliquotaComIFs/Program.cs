// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3300.0;

        //De 1900.0 até 2800.0, o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142;
       // De 2800.01 até 3751.0, o IR é de 15 % e pode deduzir R$ 350;
       //De 3751.01 até 4664.00, o IR é de 22.5 % e pode deduzir R$ 636.

        if (salario >= 1900 && salario <=2800)
        {
            Console.WriteLine("Sua alíquota é de 7.5%");
            Console.WriteLine("Você pode deduzir na declaração o valor de R$ 142.");
        }
        else
        {
            if (salario > 2800 && salario <= 3751)
            {
                Console.WriteLine("Sua alíquota é de 15%");
                Console.WriteLine("Você pode deduzir na declação o valor de R$ 350.");
            }
            else
            {
                if (salario > 3751 && salario <= 4664)
                {
                    Console.WriteLine("Sua alíquota é de 22.5%");
                    Console.WriteLine("Você pode deduzir na declaração o valor de R$ 636.");
                }
            }
        }
    }
}
