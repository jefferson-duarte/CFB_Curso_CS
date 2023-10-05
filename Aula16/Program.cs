using System;

class Aula15
{
    static void Main()
    {
        int tempo;
        char escolha;
        string tipoTransporte = " ";

        inicio:

        Console.Clear();

        Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
        Console.WriteLine("Escolha o transporte:");
        Console.WriteLine("[A] Avião");
        Console.WriteLine("[C] Carro");
        Console.WriteLine("[O] Ônibus");


        escolha = char.Parse(Console.ReadLine().ToUpper());

        switch (escolha)
        {
            case 'A':
                tempo = 50;
                tipoTransporte = "Avião";
                break;
            case 'C':
                tempo = 480;
                tipoTransporte = "Carro";
                break;
            case 'O':
                tempo = 660;
                tipoTransporte = "Ônibus";
                break;
            default:
                tempo = -1;
                break;

        }

        if (tempo < 0)
        {
            Console.WriteLine("Transporte Indisponível");
        }
        else
        {
            Console.WriteLine($"O transporte escolhido foi {tipoTransporte} e o tempo é de {tempo} minutos.");
        }

        Console.Write("Deseja calcular outro transporte?[S/N]: ");
        escolha = char.Parse(Console.ReadLine().ToUpper());

        if (escolha == 'S')
        {
            goto inicio;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Fim do Programa");
        }
    }
}