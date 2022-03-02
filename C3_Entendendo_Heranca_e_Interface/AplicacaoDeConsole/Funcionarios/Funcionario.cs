using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoDeConsole.Funcionarios
{
    public class Funcionario
    {
        public static int TotalDeFuncionarios {  get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; } //como o set ta privado não é possível
                                                // alterar a variável dentro do programa,
                                                // é necessário um construtor dentro da classe
        public double Salario { get; protected set; } // com o protect é possível alterar com os derivados da classe

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando Funcionário");
            CPF = cpf;
            Salario = salario; // a propriedade Salario é igual ao argumento salario do construtor
            TotalDeFuncionarios++;
        }

        public virtual void AumentarSalario ()
        {
            //Salario = Salario + (Salario * 0.1);
           // Salario = Salario * 1.1;
            Salario *= 1.1;
        }

        
        public virtual double GetBonificacao()  // possível mudar posteriormente na herança/ que pode ser sobrescrito
        {
            return Salario * 0.10;
        }


    }
}
