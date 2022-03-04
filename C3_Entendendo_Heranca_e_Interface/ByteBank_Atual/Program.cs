// See https://aka.ms/new-console-template for more information
using ByteBank_Atual.Sistemas;
using ByteBank_Atual.Funcionarios;

namespace ByteBank_Atual
{
    class Program
    {
        static void Main(string[] args)
        {
            // CalcularBonificacao();
            UsarSistema();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor diretor1 = new Diretor("923.842.242-09");
            diretor1.Nome = "Roberta";
            diretor1.Senha = "123";

            sistemaInterno.Logar(diretor1, "123");
            sistemaInterno.Logar(diretor1, "324");


            GerenteDeConta gerente1 = new GerenteDeConta("249.323.423-02");
            gerente1.Nome = "Camila";
            gerente1.Senha = "254";

            sistemaInterno.Logar(gerente1, "254");
            sistemaInterno.Logar(gerente1, "324");

        }

        public static void CalcularBonificacao ()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            //Funcionario claudio = new Funcionario : não é possível mais criar um funcionario diretamente
            // por causa do abstract

            Funcionario designer1 = new Designer("867.394.212 - 09");
            designer1.Nome = "Pedro";

            Diretor diretor1 = new Diretor("923.842.242-09");
            diretor1.Nome = "Roberta";

            Auxiliar auxiliar1 = new Auxiliar("283.293.192-02");
            auxiliar1.Nome = "Igor";

            GerenteDeConta gerente1 = new GerenteDeConta("249.323.423-02");
            gerente1.Nome = "Camila";

            gerenciadorBonificacao.Registrar(designer1);
            gerenciadorBonificacao.Registrar(diretor1);
            gerenciadorBonificacao.Registrar(auxiliar1);
            gerenciadorBonificacao.Registrar(gerente1);

            Console.WriteLine("Total de bonificações do mês: " +
                gerenciadorBonificacao.GetTotalBonificacao());




        }

    }

}