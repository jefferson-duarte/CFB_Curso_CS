using System;

class Aula20
{
    static void Main()
    {
        int[] num = new int[10];
        int i = 0, j = 0;

        while (i < num.Length)
        {
            Console.WriteLine(num[i]);
            i++;
        }

        Console.WriteLine();

        while (j < num.Length)
        {
            Console.WriteLine($"Valor - {j}");
            j++;
        }
        Console.WriteLine("Fim do while");
    }
}