using System;

class Aula10
{
    enum DiasSemana { Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado };
    static void Main()
    {
        // usando casting mostra o indice da variavel
        int ds2 = (int)DiasSemana.Quinta;

        DiasSemana ds = DiasSemana.Domingo;

        // usando casting e pegando o valor pelo indice 3
        DiasSemana ds1 = (DiasSemana)3;
        
        Console.WriteLine(ds);
        Console.WriteLine(ds1);
        Console.WriteLine(ds2);
    }
}