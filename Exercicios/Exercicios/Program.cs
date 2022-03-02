// See https://aka.ms/new-console-template for more information


	class Program
{
	static void	Main(string[] args)
    {
		Console.WriteLine("Exercício do Piettro:");
		Console.WriteLine("Números Primos de 0 a 100!");
		int i = 1;
		int j = 1;
		for (i = 1; i <= 100; i++)
		{
			int contador = 0;
			for(j = 1; j <= i; j++)
            {
				if (i % j == 0)
				{
					contador++;
				}
			}
			
			if (contador == 2)
            {
				Console.WriteLine("O número " + i + " é primo");
			}
		}
    }
}