using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    class Cliente
    {
        private string Nome { get; set; }
        private string Email { get; set; }
        private string Telefone { get; set; }



        public Cliente(string nome) {
            this.Nome = nome;
                   
        }


        // GET --- SET
        //    uma maneira de fazer

   //     public string Nome {
   //         get {
   //             return this.nome;
   //         }
   //         set {
   //             this.nome = value;
   //         }
   //     }



        override
            public string ToString()
        {
            return $"Nome: {this.Nome}\n" +
                $"Email: {this.Email}\n" +
                $"Telefone: {this.Telefone}";
        }
    }
}
