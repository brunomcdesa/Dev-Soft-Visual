using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Calculando o Fatorial
//Lembrando que: O fatorialde 0 é 1; O fatorial de um número n é n*n-1*n-2... até n = 1. Ou seja:
//O fatorial de 4! = 1 x 2 x 3 x 4 = 24
//O fatorial de 6! = 1 x 2 x 3 x 4 x 5 x 6 = 720
//Desenvolva uma aplicação em C# que: ao receber um valor do usuário calcule seu fatorial (utilizar laço de repetição é obrigatório);
namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Digite o numero a ser fatorado: ");
            int numFatorado = int.Parse(Console.ReadLine());
           
            Console.ReadLine();
            int numAtual = 1;
            for (int i = numFatorado; i >= 1; i--)
            {
                
                Console.WriteLine("O indicie atual é: " + i);
                numAtual = numAtual * i;
             
            }
               Console.WriteLine("\nO fatorial de " + numFatorado + " é: " + numAtual);
            Console.ReadLine();
            

        }
    }
}
