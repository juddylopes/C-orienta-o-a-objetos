// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main(string [] args)
    {
        for (int multiplo = 0; multiplo <= 100; multiplo+=3) //multiplo++ ... multiplo +=1
        {
            Console.WriteLine(multiplo);
        }
        //outra forma de saber os múltiplos de 3
        Console.WriteLine();

        for (int numero = 0; numero <= 100; numero++)
        {
            if (numero % 3 == 0 && numero % 6 ==0) // três e seis
            {
                Console.WriteLine(numero);
            }
        }

    }
}
