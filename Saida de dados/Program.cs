using System;
using System.Globalization;

namespace Saida_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F'; // sempre quando for um caractere usar aspas simples
            int idade = 32;
            double saldo = 10.35468;
            string nome = "Johnny"; // sempre quando for palavra usar aspas duplas

            System.Console.WriteLine("Bom dia "+nome);
            System.Console.WriteLine(genero);
            System.Console.WriteLine(idade);
            System.Console.WriteLine(saldo.ToString("F1")); // nesse casio manipula quantas casas decimais virão depois da vírgula
            System.Console.WriteLine(saldo.ToString("F2"));
            System.Console.WriteLine(saldo.ToString("F3"));
            System.Console.WriteLine(saldo.ToString("F4"));
            System.Console.WriteLine("Abaixo impressão trocando a , pelo .");
            System.Console.WriteLine(saldo.ToString("F1", CultureInfo.InvariantCulture));
            System.Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine(saldo.ToString("F3", CultureInfo.InvariantCulture));
            System.Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            System.Console.WriteLine();
            // exemplo de concatenação, placeholders e interpolação
            System.Console.WriteLine("*** PLACEHOLDERS ***");
            System.Console.WriteLine("{0} tem {1} anos de idade e tem R$ {2:F2} reais na sua conta", nome, idade, saldo);
            System.Console.WriteLine();
            System.Console.WriteLine("*** INTERPOLAÃO ***");
            System.Console.WriteLine($"{nome} tem {idade} anos de idade e tem R$ {saldo:F2} reais na sua conta");
            System.Console.WriteLine();
            System.Console.WriteLine("*** CONCATENAÇÃO ***");
            System.Console.WriteLine(nome+" tem "+idade+" anos de idade, e tem R$ "+saldo.ToString("F2")+" reais na sua conta");
            System.Console.WriteLine();

            // *** EXERCICIO ***
            System.Console.WriteLine("**** EXERCÍCIO ****");
            System.Console.WriteLine();
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idadeNova = 30;
            int codigo = 5290;
            char generoNovo = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            // SAÍDA DE DADOS //
            System.Console.WriteLine("** PRODUTOS **");
            System.Console.WriteLine($"{produto1} cujo preço é $ {preco1:F2}");
            System.Console.WriteLine($"{produto2}, cujo preço é $ {preco2}");
            System.Console.WriteLine();
            System.Console.WriteLine($"Registro: {idadeNova} anos de idade, código {codigo} e gênero: {generoNovo}");
            System.Console.WriteLine();
            System.Console.WriteLine($"Medida com oito casas decimais: {medida}");
            System.Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            System.Console.WriteLine("Separador de decimal invariant culture: "+medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
