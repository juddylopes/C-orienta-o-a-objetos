

namespace Animais_Natureza
{
    public class Animais
    {
        public string Nome { get; set; }
        public string Especie { get; set; } // atributos
        public string SubReino { get; set; }
        public string Habitat { get; set; }

        public static int TotalDeAnimaisAnalisados;
        public Animais ()
        {
            TotalDeAnimaisAnalisados++;
        }



    }
}