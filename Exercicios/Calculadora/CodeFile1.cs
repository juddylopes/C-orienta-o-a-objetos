

public class Calculadora
{
    public int soma(int a, int b)
    {
        return a + b;
    }
    public int subtracao(int a, int b)
    {
        return a - b;
    }
    public int multiplicacao(int a, int b)
    {
        return a * b;
    }
    public int divisao(int a, int b)
    {
        return a / b;
    }
    public int raiz( int a, int b)
    {
        return 
    }
    public int potencia (int a, int b) // a: base // b: expoente
    {
        return  a * (b)  
    }



}

class Program
{
    static void Main(string[] args)
    {
        int fat = 1;
        for (int i = 1; i < 11; i++)
        {
            fat *= i;
            Console.WriteLine("Fatorial de " + i + " = " + fat);
        }
    }
}