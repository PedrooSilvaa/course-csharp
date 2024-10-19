using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            char genero = 'M';
            int idade = 20;
            double saldo = 10.35784;
            string nome = "Pedro";

            Console.WriteLine("Bom dia!");
            Console.WriteLine("Boa tarde");

            Console.Write("Bom dia!");
            Console.Write("Bom tarde!");
            Console.WriteLine("-------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            //Definindo casas decimais
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            //Definindo que casas decimais sajm dividas por pontos
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("-------------------------");
            //Placeholder
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais", nome, idade, saldo);
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            //Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            //Concatenação de string
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo + " reais");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
    }
}