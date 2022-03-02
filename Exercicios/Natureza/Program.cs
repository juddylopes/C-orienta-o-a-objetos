// See https://aka.ms/new-console-template for more information

using Animais_Natureza;

namespace Animais_Natureza
{
    class Program
    {
        static void Main (string [] args)
        {
            Console.WriteLine("Exercícios do Piettro. Animais: ");


            Animais animal1 = new Animais();

            animal1.Nome = "esponja";
            animal1.Especie = "marinho";
            animal1.Habitat = "aquático";
            animal1.SubReino = "parazoa";

            Animais animal2 = new Animais();
            animal2.Nome = "raposa";

            Console.WriteLine("Total de Animais analisados até o momento: " + Animais.TotalDeAnimaisAnalisados);

        }
    }
}
