﻿// See https://aka.ms/new-console-template for more information


namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;
            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036; // 0.36% = 0.0036
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$ " + valorInvestido);
                //equivalente abaixo: contadorMes = contadorMes + 1;
                //contadorMes += 1; 
                contadorMes++;
            }




            Console.ReadLine();
        }
    }
}
