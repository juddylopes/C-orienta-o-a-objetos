// See https://aka.ms/new-console-template for more information


class Program
{

    static void Main(string[] args)
    {
        try
        {
            Metodo();
        }
        catch (DivideByZeroException excecao)
        {
            Console.WriteLine("Exceção tratada.");
            Console.WriteLine(excecao.Message);
            Console.WriteLine(excecao.StackTrace);
        }
        catch (NullReferenceException excecao)
        {
            Console.WriteLine("Exceção tratada.");
            Console.WriteLine(excecao.Message);
            Console.WriteLine(excecao.StackTrace);
        }
    static void Metodo()
    {
        try
        {
            TestaDivisao(0);
        }
        catch (NullReferenceException excecao)
        {
            Console.WriteLine(excecao.Message);
            Console.WriteLine(excecao.StackTrace);
        }
        
    }

    static void TestaDivisao(int divisor)
    {
        Dividir(10, divisor);
    }
    public static int Dividir(int numero, int divisor)
    {
        ContaCorrente conta = null;
        Console.WriteLine(conta.Saldo);
        return numero / divisor;
    }




}