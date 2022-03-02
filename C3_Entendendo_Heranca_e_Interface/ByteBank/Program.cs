// See https://aka.ms/new-console-template for more information

using ByteBank.Funcionários;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(0);
            carlos.Nome = "Carlos";
            carlos.CPF = "401.299.003-21";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "458.234.324.09";
            roberta.Salario = 5000;

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome); 
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

        }
    }
}
