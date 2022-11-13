using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmes_Api.Data.Dtos
{
    public class UpdateFilmeDto
    {
        [Required(ErrorMessage = "Título é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Diretor é obrigatório")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "Gênero: Máx 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "Tempo: Máx 600 minutos")]
        public int Duracao { get; set; }
    }
}
