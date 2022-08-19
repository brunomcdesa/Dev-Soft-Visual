using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{

        class ContaCorrente
        {
            //Atributos
            public Cliente cliente;
            public int numAgencia;
            public int numConta;
            public double saldo;
            public double limite;

            //Construtores
            public ContaCorrente(Cliente cliente) {
            this.cliente = cliente;        
             }

        //Transferencia
        // virtual => quem extende da conta pode sobreescrever o metodo 
        public virtual bool Transferencia(ContaCorrente contaDestino, double valor) {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.saldo += valor;
                return true;

            }
        }


        override
        public string ToString()
        {
            return $"Cliente:\n" +
                $"{this.cliente.ToString()} \n" +
                       $"Numero da agencia: {this.numAgencia}\n" +
                        $"Numero da conta:  {this.numConta}\n" +
                        $"Saldo disponivel: {this.saldo}\n" +
                         $"Limite disponivel: {this.limite}\n";

                /*
                 $"Nome do titular: {this.nomeTitular}\n" +
                $"Numero da agencia: {this.numAgencia}\n "


                 */
            }
        }
    }

