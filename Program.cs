using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine(); //evaluate too a string switch (subject)

            switch (subject.ToLower())
            {
                case "Math":
                    Console.WriteLine("Math is a tough subject!");
                    break;
                case "science":
                    Console.WriteLine("Science is a tough subject!");
                    break;
                case "english":
                    Console.WriteLine("English is an intresting subject!");
                    break;
                default:
                    Console.WriteLine($"oh wow! i havent taken that subject before. {subject} sounds fun !");
                    break;
            }
        }
    }
}
