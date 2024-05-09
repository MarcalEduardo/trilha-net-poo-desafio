using DesafioPOO.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("SmartPhone Nokia");

        Nokia c1 = new Nokia("1", "Nokia", "122", 64);
        c1.Ligar();
        c1.InstalarAplicativo("Google Maps");

        Console.WriteLine("\n");


         Console.WriteLine("SmartPhone Iphone");

        Iphone c2 = new Iphone("2", "Iphone", "222", 128);
        c2.Ligar();
        c2.InstalarAplicativo("Instagram");

       
    }
    
}