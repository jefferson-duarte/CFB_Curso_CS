using System;

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador()
    {
        energia = 100;
        vivo = true;
        nome = "Jogador";
    }
    public Jogador(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }

    public Jogador(string n, int e)
    {
        energia = e;
        vivo = true;
        nome = n;
    }

    public Jogador(string n, int e, bool v)
    {
        energia = e;
        vivo = v;
        nome = n;
    }

    public void info()
    {
        if (vivo.Equals(true)){
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

class Aula28
{
    static void Main()
    {

        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador("Bruno");
        Jogador j3 = new Jogador("Jefferson", 100);
        Jogador j4 = new Jogador("Maria",0, false);

        j1.info();
        j2.info();
        j3.info();
        j4.info();
    }
}