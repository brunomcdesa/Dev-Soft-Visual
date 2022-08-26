using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4
{
    class Diretor : Funcionario
    {
        public string senha;
        
        public Diretor(string cpf) : base(cpf) {}

        public double GetBonificacao(double lucro) {
            return (this.Salario * this.PercentBonificacao) + lucro ;
        }

       
        public new void AumentarSalario() {

            this.Salario *= 1.15;
        }
        
    }
}
