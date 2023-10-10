class Aula18
{
    static void Main()
    {
        int[,] n = new int[3, 5];
        int[,] num = new int[2, 2] { { 10, 20 }, { 30, 40 } };

        n[0, 0] = 10;
        n[0, 1] = 20;
        n[0, 2] = 30;
        n[0, 3] = 40;
        n[0, 4] = 50;
        n[1, 0] = 60;
        n[1, 1] = 70;
        n[1, 2] = 80;
        n[1, 3] = 90;
        n[1, 4] = 100;
        n[2, 0] = 110;
        n[2, 1] = 120;
        n[2, 2] = 130;
        n[2, 3] = 140;
        n[2, 4] = 150;

        Console.WriteLine($"Exemplo matrix 1: {n[2, 1]}");
        Console.WriteLine($"Exemplo matrix 2: {num[1,0]}");


    }
}