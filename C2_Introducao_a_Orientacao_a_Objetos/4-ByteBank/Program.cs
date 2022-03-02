// See https://aka.ms/new-console-template for more information



class Program
{
    static void Main(string [] args)
    {
        ContaCorrente   contaDoBruno = new ContaCorrente();
        contaDoBruno.titular = "Bruno";


        Console.WriteLine(contaDoBruno.saldo);
        bool resultadoSaque = contaDoBruno.Sacar(50); 
        // sacar é uma função e 50 é o seu argumento
        Console.WriteLine(contaDoBruno.saldo);
        Console.WriteLine(resultadoSaque);
        contaDoBruno.Depositar(500);
        Console.WriteLine(contaDoBruno.saldo);

        ContaCorrente contaDaGabriela = new ContaCorrente();
        contaDaGabriela.titular = "Gabriela";

        Console.WriteLine("Saldo conta do Bruno: R$" + contaDoBruno.saldo);
        Console.WriteLine("Saldo conta da Gabriela: R$" + contaDaGabriela.saldo);

        bool resultadoTransferencia = contaDoBruno.Transferir(100,contaDaGabriela);

        Console.WriteLine("Saldo conta do Bruno: R$" + contaDoBruno.saldo);
        Console.WriteLine("Saldo conta da Gabriela: R$" + contaDaGabriela.saldo);

        Console.WriteLine(resultadoTransferencia);

        contaDaGabriela.Transferir(200,contaDoBruno);
        Console.WriteLine("Saldo conta do Bruno: R$" + contaDoBruno.saldo);
        Console.WriteLine("Saldo conta da Gabriela: R$" + contaDaGabriela.saldo);

    }

}
