using System;

class Aula27
{
    static void Main()
    {
        //Console.WriteLine("SOMA");
        float valores;
        valores = soma(1, 4, 5, 6);
        Console.WriteLine($"O retorno foi: {valores}");
    }

    static float soma(params float[] n)
    {
        float res = 0;

        if (n.Length < 1)
        {
            Console.WriteLine("Nao a valores para somar.");
        }else if(n.Length < 2)
        {
            Console.WriteLine($"Valores insuficientes para somar {n[0]}");
        }
        else
        {
            for(int i = 0; i < n.Length; i++)
            {
                res += n[i];
            }
        }

        return res;
    }
}