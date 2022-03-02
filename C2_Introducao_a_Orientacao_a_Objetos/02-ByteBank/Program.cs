// See https://aka.ms/new-console-template for more information


namespace _2_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(); // referência à objeto criado: Novo Item > Arquivo de Código C#
            conta.titular = "Gabriela";
            conta.saldo = 200; //o que se mantem é o valor que você atribui por último e não o valor padrão

            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.agencia);
            Console.WriteLine(conta.saldo);
        }
    }
}
