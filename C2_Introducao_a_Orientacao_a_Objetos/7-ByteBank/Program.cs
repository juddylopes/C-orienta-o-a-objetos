// See https://aka.ms/new-console-template for more information



namespace ByteBank
{
    class Program
    {
        static void Main (string [] args)
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(0, 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ParamName);
            }
            



        }

    }
}
