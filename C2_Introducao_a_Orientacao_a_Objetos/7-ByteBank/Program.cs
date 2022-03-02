// See https://aka.ms/new-console-template for more information



namespace _7_ByteBank
{
    class Program
    {
        static void Main (string [] args)
        {
            ContaCorrente conta1 = new ContaCorrente(873, 8732034);
            Cliente cliente1 = new Cliente();
            cliente1.Nome = "Hozorio Menezes";
            conta1.Titular = cliente1;
            Console.WriteLine (conta1.Titular.Nome);
            Console.WriteLine (conta1.Agencia);
            Console.WriteLine (conta1.Numero);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta2 = new ContaCorrente(874, 8740212);
            Cliente cliente2 = new Cliente();
            cliente2.Nome = "Gabriela Assis";
            conta2.Titular = cliente2;
            Console.WriteLine (conta2.Titular.Nome);
            Console.WriteLine(conta2.Agencia);
            Console.WriteLine(conta2.Numero);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


        }

    }
}
