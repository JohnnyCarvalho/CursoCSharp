using System;

namespace operadores_aritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Teste n = new Teste();

            n.setIdade(25);
            n.imprime();
        
            /*
            Vamos ver alguns exemplos usando matodos aritméticos
             para fazer alguns cauculos
            */
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;

            /*
            No exemplo abaixo temos que usar o casting, pois o compilador entende que querendo dividir
             dois números inteiros você qur um resultado inteiro
            */
            double n4 = (double) 10 / 8;

            /*
            Ou também podemos colocar o número a ser dividido em 
            formato de double como no exemplo abaixo, dessa forma não precisamos usar o casting
            */
            double n5 = 10.0 / 8;

            System.Console.WriteLine($"O resultado de n1 é: {n1}");
            System.Console.WriteLine($"O resultado de n2 é: {n2}");
            System.Console.WriteLine($"O resultado de n3 é: {n3}");
            System.Console.WriteLine($"O resultado de n4 é: {n4}");
            System.Console.WriteLine($"O resultado de n5 é: {n5}");

            /*
            VAMOS VER UM EXEMPLO  USANDO A FÓRMULA DE BASKARA PARA CAUCULAR OS VALORES DE A, B, C
            */
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c; // Nesse caso a bibliotéca Math.pow eleva o b² usando o metodo b, 2.0

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); // nesse caso temos que usar os parenteses por causa das ordens de precedência
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a); // nesse caso temos que usar os parenteses por causa das ordens de precedência

            System.Console.WriteLine($"O valor de delta é: {delta}");
            System.Console.WriteLine($"O valor de X1 é: {x1}");
            System.Console.WriteLine($"O valor de X2 é: {x2}");
        }
    }
}
