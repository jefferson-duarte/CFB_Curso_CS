using System;

class Aula06
{
    static void Main()
    {

        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        valorVenda = valorCompra + (valorCompra * lucro);

        Console.WriteLine("Produto......:{0,10}", produto);
        Console.WriteLine("Val.Compra...:{0,10:c}", valorCompra);
        Console.WriteLine("Lucro........:{0,10:p}", lucro);
        Console.WriteLine("Val.Venda....:{0,10:c}", valorVenda);
    }
}
