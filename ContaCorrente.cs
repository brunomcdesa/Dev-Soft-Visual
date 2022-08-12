using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2._1
{
    class ContaCorrente
    {
        //Atributos
        public string nomeTitular;
        public int numAgencia;
        public int numConta;
        public double saldo;
        public double limite;

        //Construtores
        public ContaCorrente() {}
       
  

    public string ToString() {
        return "Nome do titular: " +  this.nomeTitular + "\n" +
                    "Numero da agencia: " + this.numAgencia + "\n" +
                    "Numero da conta: " + this.numConta + "\n" +
                    "Saldo disponivel: " + this.saldo + "\n" +
                    "Limite disponivel: " + this.limite + "\n";

            /*
             $"Nome do titular: {this.nomeTitular}\n" +
            $"Numero da agencia: {this.numAgencia}\n "
             
             
             */
    }
  }
}
