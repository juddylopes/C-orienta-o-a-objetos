// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 8 - Condicionais 2");

        int idadeJoao = 16;
        //int quantidadePessoas = 2;
        //bool acompanhado = quantidadePessoas >= 2; // expressão boleana
        bool acompanhado = false;

        if (idadeJoao >= 18 || acompanhado == true) // herança do C++: ou ||; e &&; == comparação
        {
            Console.WriteLine("Pode entrar.");
        }
        else
        {
            Console.WriteLine("Não pode entrar");
        }
        Console.ReadLine();
    }
}
