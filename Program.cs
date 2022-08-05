using System;

namespace Dev_Soft_Visual {

    class Program {

        static void Main(string[] args) {

            /* Console.WriteLine("Olá Projeto de Desenvolvimento de Software Visual!");

             double nota = 6.5;
             Console.WriteLine(nota);

             string nome = "Bruno";
             Console.WriteLine(nome + " " + nota);

             double soma = nota + 2;
             if(soma > 7) {
                 Console.WriteLine(soma);
             }
             else
             {
                 Console.WriteLine("soma menor que o esperado.");
             }

             Console.WriteLine("Digite seu nome: ");
             string nomeNovo = Console.ReadLine();
             Console.WriteLine("Digite sua idade: ");
             int idade = Console.Read();

             Console.WriteLine("O nome é: " + nomeNovo + " e tem " + idade + " anos de idade.");

             */


            // EXERCICIO 1
            /*Console.Write("Digite o primeiro valor: ");
            int num1 = int.Parse( Console.ReadLine());
             Console.Write("Digite o segundo valor: ");
             int num2 = int.Parse(Console.ReadLine());
             Console.Write("Digite o terceiro valor: ");
             int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2);
            }
            else if (num3 > num1 && num3 > num2) {
                Console.WriteLine(num3);
            }*/

            //EXERCICIO 2
            /*Console.Write("Digite o primeiro valor: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine(num1);
            }
            else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine(num2);
            }
            else if (num3 < num1 && num3 < num2)
            {
                Console.WriteLine(num3);
            }*/

            Console.Write("Digite o primeiro valor: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            int num3 = int.Parse(Console.ReadLine());

            int[] ordem = new int[3] { num1, num2, num3 };
            Array.Sort(ordem);
            Array.Reverse(ordem);
            foreach(int valor in ordem)
            {
                Console.WriteLine(valor + " ");
            }
            
            
        }
    }
}
