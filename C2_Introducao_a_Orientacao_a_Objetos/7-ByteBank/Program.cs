
namespace ByteBank
{
    class Program
    {
        static void Main (string [] args)
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(456, 2554);
                ContaCorrente conta2 = new ContaCorrente(457, 3253);

                conta2.Transferir(-10, conta1);
                conta1.Depositar(50);
                Console.WriteLine(conta1.Saldo);
                conta1.Sacar(500);
            }
            catch (ArgumentException ex)
            {
                if (ex.ParamName == "numero")
                {

                }
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ParamName);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException.");
            }



        }

    }
}
