// See https://aka.ms/new-console-template for more information


namespace Referencias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Segunda tentativa de fazer a porra do exercício");

            ContaCorrente contaDaCamila = new ContaCorrente();
            contaDaCamila.titular = new Cliente();

            contaDaCamila.titular.nome = "Camila Perez";
            Console.WriteLine(contaDaCamila.titular.nome);
            Console.WriteLine("FOI CARALHO PORRA AÍ MERDA ENTENDI ESSA CACETA!!!");

        }
    }
}

