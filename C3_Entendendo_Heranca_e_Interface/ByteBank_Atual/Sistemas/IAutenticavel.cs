using ByteBank_Atual.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Atual.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
