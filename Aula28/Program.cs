using System;

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador(string n) {
        energia = 100;
        vivo = true;
        nome = n;
    }
}

class Aula28
{
    static void Main()
    {
        string nome1, nome2 = "";
        Console.Write("Nome jogador 1: ");
        nome1 = Console.ReadLine();
        Console.Write("Nome jogador 2: ");
        nome2 = Console.ReadLine();
        Console.WriteLine("----------------------");

        Jogador j1 = new Jogador(nome1);
        Jogador j2 = new Jogador(nome2);

        j1.energia = 50;

        Console.WriteLine($"Nome: {j1.nome} - Energia: {j1.energia}");
        Console.WriteLine($"Nome: {j2.nome} - Energia: {j2.energia}");
    }
}