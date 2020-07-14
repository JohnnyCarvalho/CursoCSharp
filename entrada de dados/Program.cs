using System;
using System.Globalization;

namespace entrada_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            O comando para ler os dados inseridos pela entrada padrão
            é Console.readLine();
            */
            System.Console.WriteLine();
            System.Console.Write("Digite um nome: ");
            string nome = Console.ReadLine();
            System.Console.WriteLine($"Você digitou: {nome}");
            System.Console.WriteLine();

            System.Console.Write("Digite um número inteiro: ");
            string number = Console.ReadLine();
            System.Console.WriteLine($"Você digitou: {number}");
            System.Console.WriteLine();

            System.Console.Write("Digite uma cor: ");
            string cor = Console.ReadLine();
            System.Console.WriteLine($"Você digitou: {cor}");
            System.Console.WriteLine();

            /*
            Agora vamos usar o comando Split para imprimir as palavras na mesma linha
            */
            System.Console.Write("Digite os itens a serem incluídos na compra: ");
            // string itens =  Console.ReadLine(); // posso fazer assim e depois na linha debaixo colocar o comendo string[] vet = itens.Split(' ');
            string[] vet = Console.ReadLine().Split(' '); // ou posso fazer assim também
            string item1 = vet[0];
            string item2 = vet[1];
            string item3 = vet[2];
            
            System.Console.WriteLine($"O item 1 é: {item1}");
            System.Console.WriteLine($"O item 2 é: {item2}");
            System.Console.WriteLine($"O item 3 é: {item3}");

            /*
            agora vmos fazer alguns exemplos para entrada de números
            */
            System.Console.Write("Digite um valor inteiro para n1: ");
            int n1 = int.Parse(Console.ReadLine());

            System.Console.Write("Digite um caractere: ");
            char ch = char.Parse(Console.ReadLine());

            System.Console.Write("Digite um valor real para o n2: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine($"O valor de n1 é: {n1}");
            System.Console.WriteLine($"O caractere é: {ch}");
            System.Console.WriteLine("O valor de n2 é: "+n2.ToString("F2", CultureInfo.InvariantCulture));

            /*
            agora vamos ver um exemplos que caucula a idade de um usuário
            */
            System.Console.Write("Digite a sua data de nascimento separando por espaços: ");
            string[] vetor = Console.ReadLine().Split(' ');
            int dia = int.Parse(vetor[0]);
            int mes = int.Parse(vetor[1]);
            int ano = int.Parse(vetor[2]);
            int idade = 2020 - ano;
            
            System.Console.WriteLine($"A sua idade é {idade} anos.");
        }
    }
}
