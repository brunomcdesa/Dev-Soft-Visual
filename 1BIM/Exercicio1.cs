using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Desenvolva um projeto C# que imprima todos os múl/plos de 3 entre 1 e 100.
//Esta atvidade deve utilizar laços de repetição e operadores condicionais;
namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i++) {
                if (i % 3 == 0) {
                    Console.Write(i);
                    Console.ReadLine();
                }
            }

        }
    }
}
