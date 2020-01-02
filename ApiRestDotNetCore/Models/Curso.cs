using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiRestDotNetCore.Models
{
    public class Curso
    {

        public Curso()
        {
        }

        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<PessoasCursos> PessoasCursos { get; set; }
    }
}
