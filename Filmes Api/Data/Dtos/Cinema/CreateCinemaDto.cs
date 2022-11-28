using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmes_Api.Data.Dtos
{
    public class CreateCinemaDto
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }
        public int EnderecoId { get; set; }

    }
}
