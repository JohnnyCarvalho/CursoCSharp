using System;

namespace conversão_implicita_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // exemplo de converssão implicita de casting
            float a = 4.5f; // 4 bytes
            double b = a; // 8 bytes
            System.Console.WriteLine($"O valor de b implicito é: {b}");
            // No exemplo acima vemos que da certo, pois tendo em vista que um float é menor do que um double

            /*
            Agora vamos ver um exemplo inverso, vamos ver um exemplo 
            tentando colocar um double dentro de um float
            */
            // double x = 4.5f; // 4 bytes
            // float y = x; // 8 bytes
            // System.Console.WriteLine($"O valor de b implicito é: {b}");
            // Nesse caso vai dar erro, pois um double não cabe dentro de um float

            /*
            Para rodarmos o programa acima temos que fazer um castig, que nada mais é do que
            dizer para o compilador que vc não se importa se vai perder precisão no código
            oque importa é rodar o código, vejamos o exemplo abaixo
            */
            double c = 4.5f; // 4 bytes
            float d = (float)c; // 8 bytes
            System.Console.WriteLine($"O valor de d casting é: {d}");

            // outros exemplos
            double f = 4.5f; // 4 bytes
            int g = (int)f; // 8 bytes
            System.Console.WriteLine($"O valor de g casting com inteiro é: {g}");

            int h = 5;
            int i = 2;

            double resultado = (double) h/i;
            System.Console.WriteLine($"O resultado da divisão de h por i é: {resultado}");

        }
    }
}
