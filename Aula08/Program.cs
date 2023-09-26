using System;

class Aula08
{
    static void Main()
    {
        int v1, v2, soma;
        string nome;

        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Nome digitado: {0}", nome);

        Console.Write("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        v2 = int.Parse(Console.ReadLine());
        soma = v1 + v2;

        Console.WriteLine("A soma entre {0} e {1} e igual a {2}", v1, v2, soma);
    }
}