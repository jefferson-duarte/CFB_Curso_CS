using System;

class Aula14
{
    static void Main()
    {
        float n1, n2, n3, media;
        string resultado;

        Console.Write("Digite a nota 1: ");
        n1 = float.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        n2 = float.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        n3 = float.Parse(Console.ReadLine());

        media = (n1 + n2 + n3) / 3;

        if (media >= 60)
        {
            if (media >= 90)
            {
                resultado = "Aprovado com louvor";
            }
            else
            {
                resultado = "Aprovado";
            }
        } 
        else
        {
            if (media >= 40)
            {
                resultado = "Recuperação";
            }
            else
            {
                resultado = "Reprovado";
            }
        }

        Console.WriteLine($"Sua media entre {n1} + {n2} + {n3} sua média é: {media}");
        Console.WriteLine($"Seu resulado é: {resultado}");
    }
}