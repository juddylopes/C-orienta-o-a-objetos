using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(837, 93203);
            Console.WriteLine(conta.Numero);
            Funcionario funcionario1 = null;

            DateTime dataFimPagamento = new DateTime(2022, 8, 17);
            DateTime dataCorrente = DateTime.Now;
            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtension.Humanize(diferenca);

            Console.WriteLine(mensagem); 


        }

        //static string GetIntervalorDeTempoLegivel (TimeSpan timeSpan)
        //{
         //   if (timeSpan.Days > 30)
         //   {
          //      int quantidadeMeses = timeSpan.Days / 30;
          //      if (quantidadeMeses == 1)
           //     {
           //         return " 1 mês ";
           //     }
           //     return quantidadeMeses + " meses";
           // }
//
          //  return timeSpan.Days + " dias";
       // }
    }
}
