using System;

class Aula19
{
    static void Main()
    {
        int[] num = new int[10];

        for(int i=0; i<num.Length; i++)
        {
            num[i] = 0;
            Console.WriteLine($"Valor de num na pos {i}: {num[i]}");
        }

        Console.WriteLine();

        for(int i=1; i <= num.Length; i++)
        {
            Console.WriteLine($"{i} - Lista.");
        }
    }
}