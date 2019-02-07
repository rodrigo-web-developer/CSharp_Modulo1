using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp
{
    public class Professor : Pessoa
    {
        [Required]
        [StringLength(6, MinimumLength = 6)]
        public string Codigo { get; set; }
        [Required]
        public string Formacao { get; set; }

        public override void ApresentarSe()
        {
            Console.WriteLine($"Sou um professor e meu nome é: {Nome}");
        }
    }
}
