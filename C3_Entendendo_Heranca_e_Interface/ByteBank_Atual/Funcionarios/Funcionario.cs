using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Atual.Funcionarios
{
    public abstract class Funcionario // essa classe é uma abstração, não deve ser diretamente instanciada
                                      //é necessário mais informações concretas
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }


        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Construtor de Funcionário:");
            Salario = salario;
            CPF = cpf;
            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();

    }
}
