using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionários
{
    public class Diretor 
    {
        private int _tipo;
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }
        public double GetBonificacao() //Obter bonificação sem encapsulamento, assim são menos processos
        {
            return Salario;
        }
    }
}
