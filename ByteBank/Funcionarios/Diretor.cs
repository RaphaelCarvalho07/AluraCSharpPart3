using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor
    {
        public string Nome;
        public string CPF;
        public Double Salario;

        public Double GetBonificacao()
        {
            return Salario;
        }
    }
}
