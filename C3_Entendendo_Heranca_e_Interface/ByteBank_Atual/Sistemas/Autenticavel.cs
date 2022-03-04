using ByteBank_Atual.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Atual.Sistemas
{
    public abstract class Autenticavel : Funcionario 
    {
        public string Senha { get; set; }

        public Autenticavel(double salario, string cpf) : base (salario, cpf)
        {

        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

    }
}
