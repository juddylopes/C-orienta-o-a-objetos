
namespace ByteBank
{
    class Program
    {
        static void Main (string [] args)
        {
            CarregarContas ();

        }
        public static void CarregarContas()
        {
           // using (LeitorDeArquivo leitor2 = new LeitorDeArquivo ("teste.txt"))
            //{                                     // método para substituir os itens abaixo
            //    leitor2.LerProximaLinha();
            //}

            LeitorDeArquivo leitor1 = null;

            try
            {
            leitor1 = new LeitorDeArquivo("contas.txt");
            leitor1.LerProximaLinha();
            leitor1.LerProximaLinha();
            leitor1.LerProximaLinha();
            }

            finally
            {
                if(leitor1 != null)
                {
                    leitor1.Fechar();
                }
                
            }
        }


        private static void TestaInnerException ()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(456, 2554);
                ContaCorrente conta2 = new ContaCorrente(457, 3253);

                conta1.Transferir(10000, conta2);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Informações da INNER EXCEPTION (exeção interna) : ");
                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);

            }

        }


    }
}
