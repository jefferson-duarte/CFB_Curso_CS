using System;

class Veiculo
{
    public int velAtual;
    private int velMax;
    protected bool ligado;

    public Veiculo(int velMax) 
    {
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }

    public string getLigado() 
    {
        return (ligado?"Sim":"Não");
    }

    public int getVelMax() 
    { 
        return velMax;
    }

}

class Carro : Veiculo
{
    public string nome;

    public Carro(string nome, int vm):base(vm) //vm = velocidade maxima
    {
        this.nome = nome;
        ligado = false;
    }
}

class Aula36
{    
    static void Main()
    {
        var c1 = new Carro("Golf", 120);       

        Console.WriteLine("----------------------");
        Console.WriteLine($"Nome............: {c1.nome}");
        Console.WriteLine($"Velocidade Atual: {c1.velAtual}");
        Console.WriteLine($"Velocidade Max..: {c1.getVelMax()}");
        Console.WriteLine($"Ligado..........: {c1.getLigado()}");
        Console.WriteLine("----------------------");
    }
}