using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Atual.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Construtor de Diretor");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }


    }
}
