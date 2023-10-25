using System;

class Base
{
    public Base()
    {
        Console.WriteLine("Construtor da Base");
    }

    virtual public void info()
    {
        Console.WriteLine("Base");
    }
}

class Derivada1 : Base
{
    public Derivada1()
    {
        Console.WriteLine("Construtor da Derivada 1");
    }

    override public void info()
    {
        Console.WriteLine("Derivada 1");
    }
}

class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor da Derivada 2");
    }

    override public void info()
    {
        Console.WriteLine("Derivada 2");
    }

}

class Aula38
{
    static void Main()
    {
        Base Ref;
        Derivada2 derivada2 = new Derivada2();
        Derivada1 derivada1 = new Derivada1();

        Ref = derivada1;
        Ref.info();
        //derivada2.info();
        //derivada1 .info();


    }

}