using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp
{
    public class Pessoa
    {
        protected int idade;

        public static string Estatico { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }
        public int Idade
        { // propriedade com apenas get
            get
            {
                idade = DateTime.Today.Year - DataNascimento.Year;
                var x = DataNascimento.AddYears(idade);
                if (DateTime.Today < x)
                    idade--;
                return idade;
            }
        }

        public virtual void ApresentarSe()
        {
            Console.WriteLine($"Sou uma pessoa e meu nome é: {Nome}");
        }
    }
}
