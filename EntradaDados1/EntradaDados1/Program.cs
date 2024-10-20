using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            //Bom dia! - Vermelho - Verde - Azul - Amarelo Laranja Cinza
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string s = Console.ReadLine();
            string[] vet = s.Split(' ');
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(s);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}