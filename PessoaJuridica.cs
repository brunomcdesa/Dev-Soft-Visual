using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    class PessoaJuridica : Cliente
    {
        private string Cnpj { get; set; }


        public PessoaJuridica(string nome, string cnpj) : base(nome) {
            this.Cnpj = cnpj;
        }
    }
}
