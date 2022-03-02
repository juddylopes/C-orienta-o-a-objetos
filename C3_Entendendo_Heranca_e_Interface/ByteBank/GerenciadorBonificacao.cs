using ByteBank.Funcionários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;


        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public void Registrar(Diretor diretor) //metódos com o mesmo nome
        {     //sobrecargas do métodos registrar: vários registrar diferentes com o mesmo nome
            _totalBonificacao += diretor.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }

    }
}
