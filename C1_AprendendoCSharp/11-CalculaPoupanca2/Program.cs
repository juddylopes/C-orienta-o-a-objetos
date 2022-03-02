// See https://aka.ms/new-console-template for more information

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 11");

        double valorInvestido = 1000;

        for (int contadorMes = 1; contadorMes <= 12; contadorMes++) // expressão booleana comparação
        {
            valorInvestido *= 1.0036; // simplificando valorInvestido = valorInvestido + valorInvestido * 0.0036
            Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);
        }
        Console.ReadLine();
    }
}

