using System;
using System.Globalization;

namespace exercício_01_soma_de_inteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            string color = "\u001B[";


            /*           ***** EXERCÍCIO 01 *****
            * Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            * mensagem explicativa
            */
            System.Console.WriteLine();
            System.Console.WriteLine(color+"36"+"m"+"**** EXERCÍCIO 01 ****"+color+"m");
            System.Console.WriteLine("Ler dois valore inteiros e somar");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;

            System.Console.WriteLine($"SOMA = {soma}");

            /*           ***** EXERCÍCIO 02 *****
            * Faça um programa para ler o valor do raio de um círculo, 
            e depois mostrar o valor da área deste círculo com quatro
            * casas decimais.
            */
            System.Console.WriteLine();
            System.Console.WriteLine(color+"35"+"m"+"**** EXERCÍCIO 02 ****"+color+"m");
            System.Console.WriteLine("Cucilar a área de um círculo");
            double r, a, pi = 3.14159;

            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            a = pi * r * r;

            System.Console.WriteLine("A = "+a.ToString("F4", CultureInfo.InvariantCulture));


            /*           ***** EXERCÍCIO 03 *****
            * Fazer um programa para ler quatro valores inteiros
            * A, B, C e D. A seguir, calcule e mostre a diferença do produto
            * de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
            */
            System.Console.WriteLine();
            System.Console.WriteLine(color+"34"+"m"+"**** EXERCÍCIO 03 ****"+color+"m");
            System.Console.WriteLine("Caucular a diferença entre ab e cd");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int diferenca = ((A * B) - (C * D));

            System.Console.WriteLine($"DIFERENCA = {diferenca}");

            /*           ***** EXERCÍCIO 04 *****
            * Fazer um programa que leia o número de um funcionário, 
            * seu número de horas trabalhadas, o valor que recebe por
            * hora e calcula o salário desse funcionário. A seguir, 
            * mostre o número e o salário do funcionário, com duas casas decimais.
            */
            System.Console.WriteLine();
            System.Console.WriteLine(color+"33"+"m"+"**** EXERCÍCIO 04 ****"+color+"m");
            System.Console.WriteLine("Caucular o salário");
            int numero = int.Parse(Console.ReadLine());
            int numeroHoras = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = numeroHoras * valorHora;

            System.Console.WriteLine($"NUMBER = {numero}");
            System.Console.WriteLine("SALARY = U$ "+salario.ToString("F2", CultureInfo.InvariantCulture));


            /*           ***** EXERCÍCIO 05 *****
            * Fazer um programa para ler o código de uma peça 1, o número 
            * de peças 1, o valor unitário de cada peça 1, o
            * código de uma peça 2, o número de peças 2 e o
            * valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
            */
            System.Console.WriteLine();
            System.Console.WriteLine(color+"32"+"m"+"**** EXERCÍCIO 04 ****"+color+"m");
            System.Console.WriteLine("Caucular valor de peças");

            string[] peca1 = Console.ReadLine().Split(' ');
            int codPc1 = int.Parse(peca1[0]);
            int quantPc1 = int.Parse(peca1[1]);
            double valPc1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);
            double valorTotalPc1 = valPc1 * quantPc1;

            string[] peca2 = Console.ReadLine().Split(' ');
            int codPc2 = int.Parse(peca2[0]);
            int quantPc2 = int.Parse(peca2[1]);
            double valPc2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);
            double valorTotalPc2 = valPc2 * quantPc2;

            double valorTotalPagar = valorTotalPc1 + valorTotalPc2;

            System.Console.WriteLine("VALOR A PAGAR: R$ "+valorTotalPagar.ToString("F2", CultureInfo.InvariantCulture));


            /*           ***** EXERCÍCIO 06 *****
            *Fazer um programa que leia três valores com ponto flutuante de 
            * dupla precisão: A, B e C. Em seguida, calcule emostre:
            * a) a área do triângulo retângulo que tem A por base e C por altura.
            * b) a área do círculo de raio C. (pi = 3.14159)
            * c) a área do trapézio que tem A e B por bases e C por altura.
            * d) a área do quadrado que tem lado B.
            * e) a área do retângulo que tem lados A e B.
            */
            System.Console.WriteLine();
            System.Console.WriteLine(color+"31"+"m"+"**** EXERCÍCIO 04 ****"+color+"m");
            System.Console.WriteLine("Cauculos matemáticos");

            double va, vb, vc, triangulo, circulo, trapezio, quadrado, retangulo, PI = 3.14159;
            

            string[] vet = Console.ReadLine().Split(' ');
            va = double.Parse(vet[0], CultureInfo.InvariantCulture);
            vb = double.Parse(vet[1], CultureInfo.InvariantCulture);
            vc = double.Parse(vet[2], CultureInfo.InvariantCulture);

            triangulo = va * vc / 2.0;
            circulo = PI * vc * vc;
            trapezio = (va + vb) / 2.0 * vc;
            quadrado = vb * vb;
            retangulo = va * vb;

            System.Console.WriteLine("TRIANGULO: "+triangulo.ToString("F3", CultureInfo.InvariantCulture));
            System.Console.WriteLine("CIRCULO: "+circulo.ToString("F3", CultureInfo.InvariantCulture));
            System.Console.WriteLine("TRAPEZIO: "+trapezio.ToString("F3", CultureInfo.InvariantCulture));
            System.Console.WriteLine("QUANDRADO: "+quadrado.ToString("F3", CultureInfo.InvariantCulture));
            System.Console.WriteLine("RETANGULO: "+retangulo.ToString("F3", CultureInfo.InvariantCulture));



        }
    }
}
