// See https://aka.ms/new-console-template for more information


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
