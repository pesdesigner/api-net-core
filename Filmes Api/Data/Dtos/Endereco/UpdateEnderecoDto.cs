using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmes_Api.Data.Dtos
{
    public class UpdateEnderecoDto
    {

        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Logradouro é obrigatório")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "Bairro é obrigatório")]
        public string Bairro { get; set; }
        public int Numero { get; set; }

    }
}
