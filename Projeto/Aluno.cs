using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp
{
    public class Aluno : Pessoa
    {
        [Required]
        public string Ra { get; set; } // propriedade
        public TipoGraduacao Graduacao { get; set; }

    }

    public enum TipoGraduacao
    {
        Bacharelado,
        Licenciatura,
        Tecnologo
    }
}
