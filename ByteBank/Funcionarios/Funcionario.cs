using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public String Nome;
        public String CPF { get; private set; }
        public Double Salario { get; protected set; }

        public Funcionario( double salario, string cpf )
        {
            TotalDeFuncionarios++;
            CPF = cpf;
            Salario = salario;
            Console.WriteLine( "Construtor de FUNCIONARIO" );
        }

        public abstract Double GetBonificacao();


        public abstract void AumentarSalario();
            }
}
