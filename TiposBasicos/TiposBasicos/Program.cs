using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            sbyte sb = 100;
            float f = 1.0f;
            double d = 1.0;
            int i = 10;
            int i2 = int.MaxValue;
            long l = 1000;
            char c = 'a';
            char c1 = '\u0041';
            bool b = true;
            string s = "Pedro Henrique";
            object o1 = "Cecilia Ferreira";
            object o2 = 4.5;

            Console.WriteLine("Byte: " + sb);
            Console.WriteLine("Float: " + f);
            Console.WriteLine("Double: "+ d);
            Console.WriteLine("Int 1: " + i);
            Console.WriteLine("Int 2: " + i2);
            Console.WriteLine("Long: " + l);
            Console.WriteLine("Char: " + c);
            Console.WriteLine("Char with unicode: " + c1);
            Console.WriteLine("Bool: " + b);
            Console.WriteLine("String: " + s);  
            Console.WriteLine("Object 1: " + o1  + " Object 2: " + o2);
        }
    }
}