// See https://aka.ms/new-console-template for more information


namespace CriandoConstrutoresEMembrosEstáticos
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente(872, 872304);

            ContaCorrente conta2 = new ContaCorrente(872, 872305);
            ContaCorrente conta3 = new ContaCorrente(872, 872306);
            Cliente cliente1 = new Cliente();
            Cliente cliente2 = new Cliente();
            Cliente cliente3 = new Cliente();

            conta1.Titular = cliente1;
            conta1.Titular.Nome = "Sara Andrade"; // pode ser também cliente1.Nome
            conta1.Titular.Cpf = "365.821.412-09"; // pode ser também: cliente1.Cpf
            cliente1.Profissao = "Artista"; //pode ser também: conta1.Titular.Profissao
            
            Console.WriteLine("Nome do Titular: " + cliente1.Nome);
            Console.WriteLine("CPF: " + cliente1.Cpf);
            Console.WriteLine("Profissão: " + conta1.Titular.Profissao);
            Console.WriteLine("Saldo da conta inicial: " + conta1.Saldo);

            conta1.Depositar(50);
            Console.WriteLine("Novo saldo após depósito do cliente 1: " + conta1.Saldo);
            conta1.Sacar(20);
            Console.WriteLine("Novo saldo após saque do cliente 1: " + conta1.Saldo);
            conta1.Transferir(100, conta2);
            Console.WriteLine("Novo saldo após transferência do cliente 1 para o cliente 2: " + conta1.Saldo);

            Console.WriteLine("Total de contas criadas hoje: " + ContaCorrente.TotalDeContasCriadas);




        }
    }
}
