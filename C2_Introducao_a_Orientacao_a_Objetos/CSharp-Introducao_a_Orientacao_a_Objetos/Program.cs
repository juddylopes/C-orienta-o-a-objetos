// See https://aka.ms/new-console-template for more information


namespace _1_ByteBank
{
    class Program
    {
        static void Main(string [] arg)
        {
            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.conta = 863452;
            contaGabriela.saldo = 100; 
            Console.WriteLine(contaGabriela.titular);
            Console.WriteLine("Agência: " + contaGabriela.agencia);
            Console.WriteLine("Número da conta: " + contaGabriela.conta);
            Console.WriteLine("Saldo disponível: R$" + contaGabriela.saldo);

            contaGabriela.saldo += 200;
            Console.WriteLine("Saldo disponível: R$" + contaGabriela.saldo);

        }
    }
}
