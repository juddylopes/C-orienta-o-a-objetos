// See https://aka.ms/new-console-template for more information



namespace Criando_Getters_Betters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício Criando Getters e Betters");
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente1 = new Cliente();

            conta.Agencia = "809";
            cliente1.Nome = "Larissa Santos";
            conta.Titular = cliente1;
            conta.Saldo = 790;

            Console.WriteLine("O nome da cliente é: " + cliente1.Nome);
            Console.WriteLine("A agência da " + cliente1.Nome + " é " + conta.Agencia);
            Console.WriteLine("O saldo da conta da " + cliente1.Nome + " é R$" + conta.Saldo);


        }

    }
}
