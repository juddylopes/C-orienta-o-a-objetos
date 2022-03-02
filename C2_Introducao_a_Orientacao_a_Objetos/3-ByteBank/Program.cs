// See https://aka.ms/new-console-template for more information


namespace _3_ByteBank
{
    class Program
    {
        static void Main(string [] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.conta = 863452;

            ContaCorrente contaDaGabrielaCosta= new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.conta = 863452;
            //expressão booleana = comparação 
            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta); // valores iguais + endereços/referência diferentes na memória
            int idade = 27;
            int idadeClaudio = 27;
            Console.WriteLine(idade == idadeClaudio);   // valores iguais + endereços iguais na memória

            contaDaGabriela = contaDaGabrielaCosta; // atribuindo o valor assim faz ter a mesma referência
            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);

            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela);
            Console.WriteLine(contaDaGabrielaCosta);

            if (contaDaGabriela.saldo >= 100)
            {
                contaDaGabriela.saldo -= 100;
            }
        }
    }
}
