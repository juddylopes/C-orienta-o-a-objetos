using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionários
{
    public class Funcionario
    {
        // 0 = funcionario
        // 1 = diretor
        // 2 = designer

        private int _tipo;
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public Funcionario(int tipo)
        {
            _tipo = tipo;
        }

        public double GetBonificacao() //Obter bonificação sem encapsulamento, assim são menos processos
        {
            if (_tipo == 1)
            {
                return Salario;
            }
            return Salario * 0.10;
        }
    }
}
