// See https://aka.ms/new-console-template for more information


namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 Criando Variáveis ponto flutuante");
            double salario;
            salario = 1200.70;

            Console.WriteLine(salario);

            double idade;
            idade = 15.0 / 2;
            //idade = 15 / 2 dá 7,sem a casa decimal. Para contar a casa decimal faça como acima
            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + idade);

            Console.WriteLine("A execução acabou. Tecle enter para sair...");
            Console.ReadLine();

        }
    }
}

