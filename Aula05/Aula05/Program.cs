using System;

class Aula05
{
    static void Main()
    {
        bool res = 10 > 5;
        bool res1 = 10 < 5;

        bool res2 = (10 < 5) & (5 < 10); // & AND
        bool res3 = (10<5) | (5 < 10);   // | OR

        Console.WriteLine(res3);
        //Console.WriteLine(res2);
        //Console.WriteLine(res1);
        //Console.WriteLine(res);
        Console.ReadLine();
    }
}