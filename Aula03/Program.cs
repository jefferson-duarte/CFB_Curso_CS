using System;

class Aula03
{
    static void Main()
    {
        int num1, num2, num3, res;
        num1 = 10;
        num2 = 20;
        num3 = 30;
        res = (num1 + num2 + num3) / 3;

        int num = 10;
        char letra = 'A';
        float valor = 5.2f;
        string nome = "Jefferson";

        var aux = nome;

        //Console.Write(aux+"\n");
        //Console.WriteLine("Para");
        // Console.ReadLine();

        Console.WriteLine($"Valor da variavel: {aux}\n");
        Console.WriteLine($"A media entre {num1}, {num2} e {num3} e igual a {res}");
        Console.ReadLine();
    }
}