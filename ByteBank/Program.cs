﻿using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Program
    {
        static void Main( string[ ] args )
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "546.879.157-20";
            carlos.Salario = 2000;

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "454.658.148-3";
            roberta.Salario = 5000;

            gerenciador.Registrar( carlos );
            gerenciador.Registrar( roberta );

            Console.WriteLine( $"O salário do Carlos é: {carlos.Salario}" );
            Console.WriteLine( $"Bonificação do Carlos é: {carlos.GetBonificacao()}" );

            Console.WriteLine( $"O salário do Roberta é: {roberta.Salario}" );
            Console.WriteLine( $"Bonificação do Roberta é: {roberta.GetBonificacao()}" );

            Console.WriteLine( $"Total de bonificações: {gerenciador.GetTotalBonificacao()}" );
        }
    }
}
