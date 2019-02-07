using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*try
            {
                List<int> lista = null;
                List<int> lista2 = new List<int>();

                var a = lista.First();
                var a2 = lista2.First();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("A lista não pode ser null");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("A lista não pode ser vazia");
            }*/

            var aluno = new Aluno() { Nome = "a" };

            var contexto = new ValidationContext(aluno);
            var erros = new List<ValidationResult>();
            Validator.TryValidateObject(aluno, contexto, erros, true);

            if (erros.Any())
            {
                Console.WriteLine("Inválido!");
            }

            foreach (var erro in erros)
            {
                Console.WriteLine(erro.ErrorMessage);
            }


            Console.ReadKey();
        }

        static void Main_aula5(string[] args)
        {
            var a = new Aluno
            {
                Nome = "",
                Graduacao = TipoGraduacao.Bacharelado
            };

            var dinamico = new { Nome = "", Idade = 18 };

            var nome = dinamico.Nome;

            var x = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var pares = x.Where(i => i % 2 == 0).Select(i => i * 3);

            var soma = x.Sum(i => i);

            var paresSintaxe = from i in x
                               where i % 2 == 0
                               select i;


            var alunos = new List<Aluno>
            {
                new Aluno { DataNascimento = new DateTime(1990,1,1), Nome = "ABC", Graduacao = TipoGraduacao.Bacharelado},
                new Aluno { DataNascimento = new DateTime(1995,1,1), Nome = "ADE", Graduacao = TipoGraduacao.Licenciatura},
                new Aluno { DataNascimento = new DateTime(2000,1,1), Nome = "BDE", Graduacao = TipoGraduacao.Tecnologo},
            };

            var alunosMaisDeVinte = alunos.Where(aluno => aluno.Idade > 20).ToList();

            var alunosSintaxe = from aluno in alunos
                                where aluno.Graduacao == TipoGraduacao.Bacharelado
                                select aluno.Nome;

            Console.ReadKey();
        }
        public static void Main_Aula4(string[] args)
        {
            Pessoa p;

            p = new Pessoa();
            Pessoa professor = new Professor();
            Pessoa professor2 = new Professor();

            p.Nome = "Pessoa";
            professor.Nome = "Professor";
            professor2.Nome = "Professor 2";

            p.ApresentarSe();
            professor.ApresentarSe();
            Pessoa.Estatico = "teste";

            Console.ReadKey();
        }

        static void Main_Aula3(string[] args)
        {
            var x = Calculadora.Somar(10, 5);

            var x1 = Calculadora.Somar(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            Calculadora.Alertar(x1);

            var dif1 = Calculadora.Subtrair(10, 5);

            var dif2 = Calculadora.Subtrair(10);

            Calculadora.Alertar(x);

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
