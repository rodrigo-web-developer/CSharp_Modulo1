using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main_Aula3(string[] args)
        {
            var c = new Calculadora();

            var x = c.Somar(10, 5);

            var x1 = c.Somar(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            c.Alertar(x1);

            var dif1 = c.Subtrair(10, 5);

            var dif2 = c.Subtrair(10);

            c.Alertar(x);

            var aluno = new Aluno
            {
                Nome = "Aluno 1",
                DataNascimento = new DateTime(2000, 10, 01)
            };

            int idade = aluno.Idade;

            Console.WriteLine($"O aluno {aluno.Nome} tem {aluno.Idade} anos de idade");

            Console.ReadKey();
        }
        static void Main_Aula2(string[] args)
        {
            Console.WriteLine("Hello World!");

            var stringNormal = "C:\\Users";
            var stringLiteral = @"C:\Users";
            var pasta = "Users";
            var stringInterpolate = $@"C:\{pasta}";

            Console.WriteLine($"Pasta: {stringInterpolate}");

            var numeros = new[] { 0, 2, 4, 5, 7 };

            var lista = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um numero");
                lista.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var item in lista)
            {
                Console.WriteLine($"Voce digitou {item}");
            }

            var telefone = 11999999999;

            Console.WriteLine(string.Format("O telefone e: {0:(##)#####-####}", telefone));

            Console.ReadKey();
        }
    }
}
