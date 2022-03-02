// See https://aka.ms/new-console-template for more information

using _6_ByteBank;

class Program
{
    static void Main(string[] args)
    {
        ContaCorrente conta = new ContaCorrente();
        Cliente cliente = new Cliente();

        cliente.Nome = "Guilherme";
        cliente.Cpf = "231.903.129-09";
        cliente.Profissao = "Coveiro";

        conta.Titular = cliente;
        Console.WriteLine(conta.Titular.Nome);


        conta.Saldo = -10;

        Console.WriteLine(conta.Saldo);



    }
}
