using System;

class Aula23
{
    static void Main()
    {
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2, 5] { { 11, 22, 00, 44, 55 }, { 66, 77, 88, 99, 00 } };

        Random rnd = new Random();
        for(int i=0; i < vetor1.Length; i++)
        {
            vetor1[i] = rnd.Next(50);
        }

        Console.WriteLine("Elementos do vetor1");
        foreach(int n in vetor1 )
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("-----------------------------------------");

        //public static int BinarySearch(array, valor);
        Console.WriteLine("BinarySearch");
        int procurado = 33;
        int pos = Array.BinarySearch(vetor1 , procurado);
        Console.WriteLine($"Valor {procurado} esta na posicao {pos}");
        Console.WriteLine("-----------------------------------------");

        //public static void Copy(Ar_origem, Ar_destino, qtd_elementos);
        Console.WriteLine("Copy");
        Array.Copy(vetor1, vetor2, vetor1.Length);
        foreach(int n in vetor2 )
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("-----------------------------------------");

        //public void CopyTo(Ar_destino, a_partir_desta_pos);
        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3, 0);
        foreach(int n in vetor3)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("-----------------------------------------");

        //public lon GetLongLength(dimensao);
        Console.WriteLine("GetLongLength");
        long qtdElementosVetor = vetor1.GetLongLength(0);
        Console.WriteLine($"Quantidade de elementos {qtdElementosVetor}");
        Console.WriteLine("-----------------------------------------");

        //public int GetLowerBound(dimensao);
        Console.WriteLine("GetLowerBound");
        int menorIndiceVetor = vetor1.GetLowerBound(0);
        int menorIndeceMatriz_D1 = matriz.GetLowerBound(1);
        Console.WriteLine($"Menor indice do vetor1: {menorIndiceVetor}");
        Console.WriteLine($"Menor indice da matriz: {menorIndeceMatriz_D1}");
        Console.WriteLine("-----------------------------------------");

        //public int GetUpperBound(dimensao);
        Console.WriteLine("GetUpperBound");
        int maiorIndeceVetor = vetor1.GetUpperBound(0);
        int maiorIndeceMatriz_D1 = matriz.GetUpperBound(1);
        Console.WriteLine($"Maior indice do vetor1: {maiorIndeceVetor}");
        Console.WriteLine($"Maior indice da matriz: {maiorIndeceMatriz_D1}");
        Console.WriteLine("-----------------------------------------");

        //public object GetValue(long indice);
        Console.WriteLine("GetValue");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int valor1 = Convert.ToInt32(matriz.GetValue(1, 3));
        Console.WriteLine($"Valor da posicao 3 do vetor1: {valor0}");
        Console.WriteLine($"Valor da posicao [1, 3] da matriz: {valor1}");
        Console.WriteLine("-----------------------------------------");

        //public static int IndexOf(array, valor);
        Console.WriteLine("IndexOf");
        int indice1 = Array.IndexOf(vetor1, 3);
        Console.WriteLine($"Indice do primeiro valor 3: {indice1}");
        Console.WriteLine("-----------------------------------------");

        //public static void Reverse(array);
        Console.WriteLine("Reverse");
        Array.Reverse(vetor1);
        foreach(int n in vetor1)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("-----------------------------------------");

        //public void SetValue(object valor, long pos);
        Console.WriteLine("SetValue");
        vetor2.SetValue(99, 0);
        for (int i = 0; i < vetor2.Length; i++)
        {
            vetor2.SetValue(0, i);
        }
        Console.WriteLine("Vetor 2");
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);        
        }
        Console.WriteLine("-----------------------------------------");

        //public static void Sort(array);
        Console.WriteLine("Sort");
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Console.WriteLine("Vetor1");
        foreach(int n in vetor1)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor2");
        foreach( int n in vetor2) 
        { 
            Console.WriteLine(n); 
        }
        Console.WriteLine("\nVetor3");
        foreach(int n in vetor3)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("-----------------------------------------");
    }
}