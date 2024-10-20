using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            //Implicita 
            float x = 4.5f;
            double y = x;
            Console.WriteLine(y);

            //Casting
            double a;
            float b;
            int c;

            a = 5.1;
            b = (float)a;
            c = (int)a;
            Console.WriteLine(b);
            Console.WriteLine(c);

            int n1 = 5;
            int n2 = 2;
            double resultado = n1 / n2;
            Console.WriteLine(resultado);
            resultado = (double)n1 / n2;
            Console.WriteLine(resultado);

        }
    }
}