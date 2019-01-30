using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Professor : Pessoa
    {
        public string Codigo { get; set; }
        public string Formacao { get; set; }

        public override void ApresentarSe()
        {
            Console.WriteLine($"Sou um professor e meu nome é: {Nome}");
        }
    }
}
