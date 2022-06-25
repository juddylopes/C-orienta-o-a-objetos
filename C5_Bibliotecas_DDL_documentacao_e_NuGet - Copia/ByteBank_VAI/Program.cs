using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank_VAI;
using Humanizer;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "pagina?moedaOriegen=real&moedaDestino=dolar";
            // um objeto da classe string é imutável, não pode ser alterado

            //string textoVazio = "";
            //Console.WriteLine(string.IsNullOrEmpty(textoVazio));
            //Console.ReadLine();

            //string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}"; // entre chaves é o quantificador; expressão regular que ressalta um padrão

            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "Meu nome é Juddy e meu número é 3425-1575";
            Match resultado = Regex.Match(textoDeTeste, padrao); // método match retorna propriedades do que foi analisado

            Console.WriteLine(resultado);
            Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao)); // retorna booleano para verificar se está dentro do que foi pedido
            Console.ReadLine();

            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valorMoedaDestino = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valorMoedaDestino);
            string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);
            Console.WriteLine(extratorDeValores.GetValor("VALOR"));


            Console.ReadLine();


            int indiceInterrogacao = url.IndexOf('?');
            Console.WriteLine(indiceInterrogacao);

            string temporaria = url + "sufixo"; // url += "sufixo"
            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);

            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));


        }

    }
}
