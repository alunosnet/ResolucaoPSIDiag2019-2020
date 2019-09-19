using System;

namespace ResolucaoPSIDiag2019_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Ligeiro fiesta = new Ligeiro(DateTime.Now,
                "11-22-33","Ford", "Fiesta");

            Console.WriteLine(fiesta.ToString());
        }
    }
}
