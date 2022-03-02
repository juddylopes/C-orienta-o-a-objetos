// See https://aka.ms/new-console-template for more information


using AplicacaoDeConsole.Funcionarios;

namespace AplicacaoDeConsole
{
    class Program
    {
        static void Main(string [] args)
        {
           
           // Funcionario pedro = new Diretor("392.683.132-0"); // funcionario tipo diretor: código válido

            Funcionario carlos = new Funcionario(2000, "546.879.157-20");
            carlos.Nome = "Carlos";

            Diretor roberta = new Diretor("454.658.148-3");
            roberta.Nome = "Roberta";
            carlos.AumentarSalario();
            Console.WriteLine("Novo salário do carlos: " + carlos.Salario);  

            Funcionario robertaTeste = roberta;
            robertaTeste.AumentarSalario();
            Console.WriteLine("Novo salário de roberta: " + robertaTeste.Salario);

            Console.WriteLine("Bonificação de referência do diretor: " + roberta.GetBonificacao()); 
            Console.WriteLine("Bonificação de referência do diretor: " + robertaTeste.GetBonificacao());

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            gerenciador.Registrar(roberta); 
            gerenciador.Registrar(carlos);

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(Funcionario.TotalDeFuncionarios);
          
            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());







        }
    }
}
