using System;

public class Teste{

    private int idade;
    private double salario;

    public int getIdade(){
        return idade;
    }
    public void setIdade(int idade){
        this.idade = idade;
    }

    public void imprime(){
        System.Console.WriteLine(this.getIdade());

    }
}