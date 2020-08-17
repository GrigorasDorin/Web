using System;

namespace Web
{
    class Program
    {
        static void Main(string[] args)
        {
            // Save("Hello, World!");
            // Save(null);

            // TuplePatternMatching("show");
            // TuplePatternMatching("encrypt", "text.txt");

            PositionalPatternMatching();
            // PropertyPatternMatching();
        }

        static void PropertyPatternMatching()
        {
            var p = new Person();

            if (p is { Last: string firstName, Last: string lastName })
            {
                System.Console.WriteLine($"{firstName}, {lastName}");

            }
        }

        static void PositionalPatternMatching()
        {
            var p = ("asdas", "343243");

            if (p is (string first, string last))
            {
                System.Console.WriteLine($"{first}, {last}");
            }
        }

        static void TuplePatternMatching(params string[] args)
        {
            if ((args.Length, args[0]) is (1, "show"))
            {
                System.Console.WriteLine("Show: Grigoras Dorin");
            }
            else if ((args.Length, args[0], args[1]) is (2, "encrypt", string fileName))
            {
                System.Console.WriteLine("Encrypt: Grigoras Dorin");
            }
        }

        static void Save(object data)
        {
            if (data is string text)
            {
                //var text = (string)data;
                System.Console.WriteLine("Data is available...");
                System.Console.WriteLine(text);
            }
            else if (data is null)
            {
                System.Console.WriteLine("No data passed...");
            }
        }
    }
}
