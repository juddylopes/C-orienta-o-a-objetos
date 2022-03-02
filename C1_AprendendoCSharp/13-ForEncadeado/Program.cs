// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13");

        // *
        // **
        // ***
        // ****
        // *****
        // ******
        // *******
        // ********
        // *********
        // **********

        for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
        {
            for (int contadorColuna = 0; contadorColuna <10; contadorColuna++)
            {
                Console.Write("*");
                if (contadorColuna >= contadorLinha)
                {
                    break; // só se comunica com o for logo acima dele 
                }
            }
            Console.WriteLine(); //o writeline desse jeito pula linha
        }

        Console.WriteLine();
        //como ter o mesmo resultado com um código diferente

        for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
        {
            for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); //o writeline desse jeito pula linha
        }


        Console.ReadLine();
    }
}
