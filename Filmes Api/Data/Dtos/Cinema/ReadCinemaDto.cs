using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filmes_Api.Models;

namespace Filmes_Api.Data.Dtos
{
    public class ReadCinemaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
    }
}
