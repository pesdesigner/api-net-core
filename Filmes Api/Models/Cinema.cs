﻿using System.ComponentModel.DataAnnotations;

namespace Filmes_Api.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório")]
        public string Nome { get; set; }
    }
}