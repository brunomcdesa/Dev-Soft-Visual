using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("====== ORIENTACAO A OBJETOS ======= \n");
            //   ContaCorrente conta1 = new ContaCorrente();
            //  conta1.nomeTitular = "Bruno";
            //   conta1.numAgencia = 27;
            //   conta1.numConta = 64564;
            //   conta1.saldo = 1552.30;
            //   conta1.limite = 2000;

            //        Console.WriteLine("Nome do tirular: " + conta1.nomeTitular + "\n" +
            //            "Numero da agencia: " + conta1.numAgencia + "\n" +
            //            "Numero da conta: " + conta1.numConta + "\n" +
            //            "Saldo disponivel: " + conta1.saldo + "\n" +
            //            "Limite disponivel: " + conta1.limite + "\n");
            //  Console.WriteLine(conta1.ToString());
            //  Console.ReadLine();

            Cliente c1 = new Cliente("Bruno");
            c1.Email = "bruno@hotmail.com";
            c1.Telefone = "43997848484";

            Cliente c2 = new Cliente("Livia");
            c2.Email = "livia@hotmail.com";
            c2.Telefone = "43897848484";

            ContaCorrente conta1 = new ContaCorrente(c1);
            conta1.saldo = 1500.0;


            ContaCorrente conta2 = new ContaCorrente(c2);
            conta2.saldo = 0.10;


            Console.WriteLine("Antes da transf.: " + conta2.ToString());
            if (conta1.Transferencia(conta2, 100.0))
            {

                Console.WriteLine("Transferido com sucesso!\n");
                Console.WriteLine("Pos transf.: " + conta1.ToString());
                Console.WriteLine("Pos transf (conta2): " + conta2.ToString());
                Console.ReadLine();
            }
            else
            {

                Console.WriteLine("ERRO NA TREANSFERENCIA");
            }

        }
    }
}
