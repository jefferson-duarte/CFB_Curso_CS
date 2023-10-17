using System;
using System.Runtime.Intrinsics;

class Aula24
{
    static void Main()
    {
        //cfb();
        Console.Write("Digite o primeiro valor: ");
        int valor1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o seugundo valor: ");
        int valor2 = int.Parse(Console.ReadLine());
        Console.Write("Digite o terceiro valor: ");
        int valor3 = int.Parse(Console.ReadLine());

        soma(valor1, valor2, valor3);
        Console.WriteLine("-----------------------");

        Console.WriteLine("Media Notas");
        Console.Write("Nota 1: ");
        float nota1 = float.Parse(Console.ReadLine());
        Console.Write("Nota 2: ");
        float nota2 = float.Parse(Console.ReadLine());
        Console.Write("Nota 3: ");
        float nota3 = float.Parse(Console.ReadLine());

        float media = mediaNota(nota1, nota2, nota3);
        Console.WriteLine($"A media entre {nota1}, {nota2} e {nota3} = {media}");

    }

    static void cfb()
    {
        Console.WriteLine("Curso CFB");
    }

    static void soma(int n1, int n2, int n3)
    {
        int soma = n1 + n2 + n3;
        Console.WriteLine($"A soma entre {n1}, {n2} e {n3} = {soma}");
    }

    static float mediaNota(float n1, float n2, float n3)
    {
        float media = (n1 + n2 + n3) / 3;
        return media;
    }
}