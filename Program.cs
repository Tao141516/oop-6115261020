using System;

namespace oop_6115261020
{
    class Program
    {
        static void Main(string[] args)
        {
            Village a = new Village("a", 15000);
            Village b = new Village("b", 50000);
            Village c = new Village("c", 100000);
            Decoration Gangnam = new Decoration("Gangnam", 100000);
            Decoration Ascard = new Decoration("Ascard", 200000);
            Decoration Winterfell = new Decoration("winterfell", 1000000);
            House h2 = new House(1, 1, 100, Gangnam, a);
            Console.WriteLine(h2.ToString());
        }
    }
}
