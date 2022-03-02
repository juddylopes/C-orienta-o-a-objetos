// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main(string[] args)
    {
        ContaCorrente PrimeiraContaCorrente = new ContaCorrente();
        PrimeiraContaCorrente.saldo = 200;
        Console.WriteLine(PrimeiraContaCorrente.saldo);

        PrimeiraContaCorrente.saldo += 100;
        Console.WriteLine(PrimeiraContaCorrente.saldo);

        ContaCorrente SegundaContaCorrente = new ContaCorrente();
        SegundaContaCorrente.saldo = 50;

        Console.WriteLine("A primeira conta tem: R$" + PrimeiraContaCorrente.saldo);
        Console.WriteLine("A segunda conta tem: R$" + SegundaContaCorrente.saldo);
    }
}
