// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 12");

        double valorInvestimento = 1.000;
        double fatorRendimento = 1.0036;

        for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
        {
            for(int contadorMes = 1; contadorMes <=12; contadorMes++)
            {
                valorInvestimento *= fatorRendimento;
            }
            fatorRendimento += 0.0010;
        }
        Console.WriteLine("Ao término do investimetno, você terá R$" + valorInvestimento);

        Console.ReadLine();
    }
}
