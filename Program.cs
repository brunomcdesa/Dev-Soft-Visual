using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario("09974096901");
            f1.Nome = "Bruno";
            f1.PercentBonificacao = 0.10;
            f1.Salario = 1500.50;
            Console.WriteLine($"\nFuncionario 1: {f1.ToString()}\n" +
                $"Bonificacao: {f1.GetBonificacao()}\n");
            

            Funcionario f2 = new Funcionario("09914785824");
            f2.Nome = "Livia";
            f2.Salario = 2250.30;
            f2.PercentBonificacao = 0.15;
            Console.WriteLine($"\nFuncionario 1: {f2.ToString()}\n" +
                $"Bonificacao: {f2.GetBonificacao()}\n");

            Diretor d1 = new Diretor("85896320200");
            d1.Nome = "Julia";
            d1.Salario = 3000.0;
            d1.PercentBonificacao = 0.20;
            Console.WriteLine($"\nDiretor 1: {d1.ToString()}\n" +
                $"Bonificacao: {d1.GetBonificacao(200.0)}\n");

            Diretor d2 = new Diretor("85896320244");
            d2.Nome = "Joao";
            d2.Salario = 3500.0;
            d2.PercentBonificacao = 0.20;
            Console.WriteLine($"\nDiretor 1: {d2.ToString()}\n" +
                $"Bonificacao: {d2.GetBonificacao(200.0)}");
            Console.ReadLine();

        }
    }
}
