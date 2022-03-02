using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoDeConsole.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base (5000, cpf) // igual ao construtor da classe base
        {
            Console.WriteLine("Criando diretor");
        }
        
        public override double GetBonificacao()  // sobrepos a Getbonificacao da base 
        {
                return Salario + base.GetBonificacao(); // base: chamar métodos declarados na classe base
        }

        public override void AumentarSalario()
        {
            //Salario = Salario + (Salario * 0.1);
            // Salario = Salario * 1.1;
            Salario *= 1.15;
        }

    }
}
