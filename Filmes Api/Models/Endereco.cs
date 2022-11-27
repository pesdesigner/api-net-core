using System.ComponentModel.DataAnnotations;

namespace Filmes_Api.Models
{
    public class Endereco
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
