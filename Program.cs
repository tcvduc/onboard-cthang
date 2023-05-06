using System;
using CSharpVariables;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Console.WriteLine("I'm learning C#!");
            Console.WriteLine("It is awesome!");
            Console.WriteLine(3 + 3);

            var s = new StringInCSharp();
            s.ToString();

        }
    }
}