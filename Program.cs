using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====== ORIENTACAO A OBJETOS ======= \n");
            ContaCorrente conta1 = new ContaCorrente();
            conta1.nomeTitular = "Bruno";
            conta1.numAgencia = 27;
            conta1.numConta = 64564;
            conta1.saldo = 1552.30;
            conta1.limite = 2000;

            //        Console.WriteLine("Nome do tirular: " + conta1.nomeTitular + "\n" +
            //            "Numero da agencia: " + conta1.numAgencia + "\n" +
            //            "Numero da conta: " + conta1.numConta + "\n" +
            //            "Saldo disponivel: " + conta1.saldo + "\n" +
            //            "Limite disponivel: " + conta1.limite + "\n");
            Console.WriteLine(conta1.ToString());
            Console.ReadLine();
        }
    }
}
