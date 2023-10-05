class Aula17
{
    static void Main()
    {
        // int n1, n2, n3, n4, n5;
        int[] n = new int[3]; //0-4
        //int[] num = new int[3] { 66, 77, 88 };
        //int[] num = {12,13,14,15};
        string[] veiculos = new string[3];

        //veiculos[0] = "Carro";
        //veiculos[1] = "Moto";
        //veiculos[2] = "Aviao";

        //n[0] = 11;
        //n[1] = 22;
        //n[2] = 33;
        //n[3] = 44;
        //n[4] = 55;



        Console.WriteLine("Digite o primeiro valor: ");
        n[0] = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        n[1] = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o terceiro valor: ");
        n[2] = int.Parse(Console.ReadLine());

        Console.WriteLine(n[0]);

        //Console.WriteLine(num[1]);
        //Console.WriteLine(veiculos[1]);
    }
}