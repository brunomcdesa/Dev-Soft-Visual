using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }
        public static int TotalFuncionarios { get; private set; }
        public double PercentBonificacao { get; set; }


        public Funcionario(string cpf) {
            this.Cpf = cpf;
            TotalFuncionarios++;
        }

        public double GetBonificacao() {
            
            return this.Salario * this.PercentBonificacao;
        }

        public void AumentarSalario() {
            this.Salario = (this.Salario * 0.1) + this.Salario;
            // this.Salario = this.Salario * 1.1;
            //this.Salario *= 0.1;
        }

        override
        public string ToString()
        {
            return $"Nome: {this.Nome}\n" +
                $"Cpf: {this.Cpf}\n" +
                $"Salario: {this.Salario}\n" +
                $"Qnt Funcionarios {TotalFuncionarios}\n";
        }
    }
}
