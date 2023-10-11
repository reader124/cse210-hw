using System;

class Program
{
    static void Main(string[] args)
    {
        srFraction f1 = new srFraction();
        Console.WriteLine(f1.srGetFractionAsString());
        Console.WriteLine(f1.srGetFractionAsDecimal());

        srFraction f2 = new srFraction(5);
        Console.WriteLine(f2.srGetFractionAsString());
        Console.WriteLine(f2.srGetFractionAsDecimal());

        srFraction f3 = new srFraction(3, 4);
        Console.WriteLine(f3.srGetFractionAsString());
        Console.WriteLine(f3.srGetFractionAsDecimal());

        srFraction f4 = new srFraction(1, 3);
        Console.WriteLine(f4.srGetFractionAsString());
        Console.WriteLine(f4.srGetFractionAsDecimal());
    }
}