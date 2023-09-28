using System;

class Aula13
{
    static void Main()
    {
        int n1, n2, n3, res = 0;
        string resultado;

        Console.Write("Digite a nota 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        n2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        n3 = int.Parse(Console.ReadLine());

        res = (n1 + n2 + n3) / 3;

        if (res < 40){
            resultado = "Reprovado!!!";
        }else if (res < 60){
            resultado = "Recuperação!!!";
        }else{
            resultado = "Aprovado!!!";
        }
        
        Console.WriteLine($"Sua média é: {res}");
        Console.WriteLine($"Resultado: {resultado}");
    }
}