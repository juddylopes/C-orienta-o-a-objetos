// See https://aka.ms/new-console-template for more information


class Program
{

    static void Main(string[] args)
    {
        try
        {
            Metodo();
        }

        catch (DivideByZeroException e) 
        {
            Console.WriteLine("Não é possível divisão por 0!");
        }

        catch (Exception e) // e = palavra reservada para erro de tratamento das exceções
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(e.StackTrace);
        }
       
    }

    static void Metodo()
    {
        TestaDivisao(0);

    }

    static void TestaDivisao(int divisor)
    {
        Dividir(10, divisor);
    }

    static int Dividir(int numero, int divisor)
    {
        try
        {
            return numero / divisor;
        }
        catch (Exception)
        {
            Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
            throw;
        }
    }

}