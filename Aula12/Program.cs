using System;

class Aula12
{
    static void Main()
    {
        int n1, n2, n3, res = 0;
        string resultado = "Reprovado";

        Console.Write("Digite a nota 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        n2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        n3 = int.Parse(Console.ReadLine());

        res = (n1 + n2 + n3) / 3;

        if (res >= 40)
        {
            resultado = "Aprovado";
        }

        Console.WriteLine($"Sua média é: {res}");
        Console.WriteLine($"Resultado: {resultado}!!!");
    }
}