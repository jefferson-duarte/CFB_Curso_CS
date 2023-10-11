using System;

class Aula21
{
    static void Main()
    {

        string senha = "123";
        string senhaUser;
        int tentativas = 0;

        do
        {
            Console.Clear();
            Console.Write("Digite sua senha: ");
            senhaUser = Console.ReadLine();
            tentativas++;

        } while (senha != senhaUser);

        Console.WriteLine($"Senha correta, tentativas: {tentativas}");
    }
}