// See https://aka.ms/new-console-template for more information


namespace _5_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente gabriela = new Cliente();
            gabriela.nome = "Gabriela";
            gabriela.cpf = "434.761.505-01";
            gabriela.profissao = "Desenvolvedora CSharp";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = gabriela;
            conta.conta = 5634059;
            conta.agencia = 563;
            conta.saldo = 500;

            conta.titular.nome = "Gabriela Costa";

            Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(gabriela.profissao);
            Console.WriteLine(conta.titular.profissao);
            Console.WriteLine(gabriela.cpf); 
            Console.WriteLine(conta.titular.cpf);
        }
    }
}
