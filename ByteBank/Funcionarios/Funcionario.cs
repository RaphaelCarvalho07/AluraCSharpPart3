using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public String Nome;
        public String CPF;
        public Double Salario;
        
        public virtual Double GetBonificacao()
        {
        return Salario * 0.10;
        }
    }    
}
