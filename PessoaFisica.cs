using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4
{
    // Dois pontos (:) nesse momento é o mesmo que "extends" de JAVA
    class PessoaFisica : Cliente
    {

        private string Cpf { get; set; }
        private DateTime Nascimento { get; set; }


        // Dois pontos e base (: base() ) no construtor seria o mesmo que escrever "super" no contrutor de JAVA                
        public PessoaFisica(String nome, string cpf) : base(nome)
        {
            this.Cpf = cpf;
            this.Nascimento = new DateTime();

        }
    }
}
