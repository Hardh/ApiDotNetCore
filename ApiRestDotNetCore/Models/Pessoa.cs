﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiRestDotNetCore.Models
{
    public class Pessoa
    {

        public Pessoa()
        {
        }

        public DateTime DataNascimento { get; set; }

        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public virtual ICollection<PessoasCursos> PessoasCursos { get; set; }

    }
}
