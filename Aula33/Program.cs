using System;

class Jogador
{
    private string nome;
    private int energia;

    public Jogador(string nome)
    {
        this.nome = nome;
        energia = 100;
    }

    public int getEnergia() { 
        return energia;
    }

    public string getNome()
    {
        return nome;
    }

    public void setEnergia(int e)
    {
        if(e < 0) // remove energia
        {
            if(energia + e < 0)
            {
                energia = 0;
            }
            else
            {
                energia += e;
            }
        }
        else if(e > 0) // adicionando energia
        {
            if(energia + e > 100)
            {
                energia = 100;
            }
            else
            {
                energia += e;
            }
        }
    }

}

class Aula33
{
    static void Main()
    {
        var j1 = new Jogador("Jefferson");
        j1.setEnergia(-30);     

        Console.WriteLine($"Nome jogador...: {j1.getNome()}");
        Console.WriteLine($"Energia jogador: {j1.getEnergia()}");

        
    }
}