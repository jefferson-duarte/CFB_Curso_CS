using System;

class Veiculo // classe base
{
    public int rodas;
    public int velMax;
    private bool ligado;

    public void ligar()
    {
        ligado = true;
    }

    public void desligar()
    {
        ligado = false;
    }

    public string getLigado()
    {
        if (ligado)
        {
            return "Sim";
        }
        else
        {
            return "Não";
        }
    }
}

class Carro : Veiculo // classe derivado
{
    public string nome;
    public string cor;

    public Carro(string nome, string cor)
    {
        ligar();
        rodas = 4;
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}

class Aula34
{
    static void Main()
    {
        var c1 = new Carro("Rapido", "Vermelho");

        Console.WriteLine($"Nome....: {c1.nome}");
        Console.WriteLine($"Cor.....: {c1.cor}");
        Console.WriteLine($"Vel Max.: {c1.velMax}");
        Console.WriteLine($"Rodas...: {c1.rodas}");
        Console.WriteLine($"Ligado..: {c1.getLigado()}");


    }
}