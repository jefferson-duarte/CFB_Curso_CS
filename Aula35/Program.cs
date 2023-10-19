using System;

class Veiculo // classe base
{
    public int rodas;
    public int velMax;
    private bool ligado;

    public Veiculo(int rodas)
    {
        this.rodas = rodas;
    }
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
        return (ligado ? "Sim" : "Não");
    }

    public int getRodas()
    {
        return rodas;
    }

    public void setRodas(int rodas)
    {
        if(rodas < 0)
        {
            this.rodas = 1;
        }
        else if(rodas > 40)
        {
            this.rodas = 40;
        }
        else
        {
            this.rodas = rodas;
        }
    }
}

class Carro : Veiculo // classe derivado
{
    public string nome;
    public string cor;

    public Carro(string nome, string cor):base(4)
    {
        ligar();
        rodas = 4;
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}

class CarroCombate : Carro
{
    public int municao;

    public CarroCombate():base("Carro de Combate", "Preto")
    {
        municao = 100;
        setRodas(20);
    }
}

class Aula34
{
    static void Main()
    {
        var c1 = new Carro("Rapido", "Vermelho");
        var cc1 = new CarroCombate();

        c1.desligar();
        cc1.setRodas(6);
        cc1.municao = 20;

        Console.WriteLine("--------------------------");
        Console.WriteLine($"Nome....: {c1.nome}");
        Console.WriteLine($"Cor.....: {c1.cor}");
        Console.WriteLine($"Vel Max.: {c1.velMax}");
        Console.WriteLine($"Rodas...: {c1.getRodas()}");
        Console.WriteLine($"Ligado..: {c1.getLigado()}");
        Console.WriteLine("--------------------------");
        
        Console.WriteLine($"Nome....: {cc1.nome}");
        Console.WriteLine($"Cor.....: {cc1.cor}");
        Console.WriteLine($"Vel Max.: {cc1.velMax}");
        Console.WriteLine($"Rodas...: {cc1.getRodas()}");
        Console.WriteLine($"Munição.: {cc1.municao}");
        Console.WriteLine($"Ligado..: {cc1.getLigado()}");
        Console.WriteLine("--------------------------");

    }
}