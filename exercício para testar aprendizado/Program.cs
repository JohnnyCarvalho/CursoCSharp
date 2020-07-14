/*
Fazer um programa que interaja com o usuário e faça pequenos caucuos
*/

using System;

namespace exercício_para_testar_aprendizado
{
    class Program
    {
        static void Main(string[] args)
        {
            String color = "\u001B["; // funçãp que permite trocar cor no console

            System.Console.WriteLine();
            System.Console.WriteLine(color+"36"+"m"+"*** BEM VINDO AO PROGRAMA ***"+color+"m");
            System.Console.Write("Quantas pessoas deseja cadastrar? ");
            int contador = int.Parse(Console.ReadLine());
            for (int i = 0; i < contador; i++){
                System.Console.WriteLine(color+"32"+"m"+$"*** DIGITE OS DADOS DO {i+1}º CLIENTE ***"+color+"m");

                System.Console.Write("Nome: ");
                string nome = Console.ReadLine();

                System.Console.Write("Data de nascimento separado por barras '/': ");
                String[] vet = Console.ReadLine().Split('/');
                int dia = int.Parse(vet[0]);
                int mes = int.Parse(vet[1]);
                int ano = int.Parse(vet[2]);
                int idade = 2020 - ano;
                System.Console.WriteLine($"Você tem {idade:F2} anos de idade");

                System.Console.Write("Estado civil: ");
                string estadoCivil = Console.ReadLine();

                System.Console.Write("Tem filhos? ");
                string perguntaFilhos = Console.ReadLine();
                if (perguntaFilhos == "sim"){
                    System.Console.Write("Quantos filhos você tem? ");
                    int quantFilhos = int.Parse(Console.ReadLine());
                    for(int f = 0; f < quantFilhos; f++){
                    System.Console.Write($"Digite a idade do {f+1}º filho: ");
                    int idadeFilhos = int.Parse(Console.ReadLine());
                    
                    }
                    float limite = quantFilhos * 100.0f;
                    System.Console.WriteLine("*** SEU LIMITE É DE "+color+"32"+"m"+"R$ "+limite.ToString("F2")+color+"m"+" reais.");
                    
                }
                else if(perguntaFilhos == "nao"){
                    System.Console.Write("Ok, vamos prosseguir ...");
                    
                }
            }
        }
    }
}
