using System;

static public class Jogador
{
    static public int energia;
    static public bool vivo;
    static public string nome;

    static public void iniciar(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }

    static public void info()
    {
        if (vivo.Equals(true))
        {
            Console.WriteLine($"Nome do Jogador...: {nome}");
            Console.WriteLine($"Energia do Jogador: {energia}");
            Console.WriteLine($"Estado do Jogador.: Vivo\n");
        }
        else
        {
            Console.WriteLine($"Nome do Jogador...: {nome}");
            Console.WriteLine($"Energia do Jogador: {energia}");
            Console.WriteLine($"Estado do Jogador.: Morto\n");
        }
    }

}

class Inimigo
{
    static public bool alerta;
    public string nome;

    public Inimigo(string n)
    {
        alerta = false;
        nome = n;
    }

    public void info()
    {

        if (alerta.Equals(true))
        {
            Console.WriteLine($"Nome do inimigo..: {nome}");
            Console.WriteLine($"Inimigo em alerta: Sim");
            Console.WriteLine("----------------------------");
        }
        else
        {
            Console.WriteLine($"Nome do inimigo..: {nome}");
            Console.WriteLine($"Inimigo em alerta: Não");
            Console.WriteLine("----------------------------");
        }

    }
}

class Aula31
{
    static void Main()
    {
        Jogador.iniciar("Jefferson");
        Jogador.info();

        Inimigo i1 = new Inimigo("Doido");
        Inimigo i2 = new Inimigo("Maluco");
        Inimigo i3 = new Inimigo("Pirado");

        Inimigo.alerta = true;

        i1.info();
        i2.info();
        i3.info();
    }
}