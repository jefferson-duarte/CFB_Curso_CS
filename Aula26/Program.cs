using System;

class Aula26
{
    static void Main()
    {
        float numDividir, numDivisor, resultDivisao, restoDivisao;

        Console.WriteLine("Divisao");

        Console.Write("Digite o numero que quer dividir: ");
        numDividir = float.Parse(Console.ReadLine());
        Console.Write("Digite por quanto quer dividir: ");
        numDivisor = float.Parse(Console.ReadLine());

        resultDivisao = divide(numDividir, numDivisor, out restoDivisao);
        Console.WriteLine($"A divisao entre {numDividir} e {numDivisor} = {resultDivisao}");
        Console.WriteLine($"O resto da divisao e {restoDivisao}");
    }

    static float divide(float dividendo, float divisor, out float resto)
    {
        float quociente;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        return quociente;
    }
}