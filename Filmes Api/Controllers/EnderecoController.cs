using AutoMapper;
using Filmes_Api.Data;
using Filmes_Api.Data.Dtos;
using Filmes_Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Filmes_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public EnderecoController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        [HttpPost]
        public IActionResult AdicionarEndereco([FromBody] CreateEnderecoDto EnderecoDto)
        {
            Endereco Endereco = _mapper.Map<Endereco>(EnderecoDto);
            _context.Enderecos.Add(Endereco);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperarEnderecosPorId), new { Id = Endereco.Id }, Endereco);
        }

        [HttpGet]

        public IActionResult RecuperarEnderecos()
        {
            return Ok(_context.Enderecos);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarEnderecosPorId(int id)
        {
            Endereco Endereco = _context.Enderecos.FirstOrDefault(Endereco => Endereco.Id == id);

            if(Endereco != null)
            {
                ReadEnderecoDto EnderecoDto = _mapper.Map<ReadEnderecoDto>(Endereco);

                return Ok(EnderecoDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaEndereco(int id, [FromBody] UpdateEnderecoDto EnderecoDto)
        {
            Endereco Endereco = _context.Enderecos.FirstOrDefault(Endereco => Endereco.Id == id);
            if(Endereco == null)
            {
                return NotFound();
            }
            _mapper.Map(EnderecoDto, Endereco);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult ExcluirEndereco(int id)
        {
            Endereco Endereco = _context.Enderecos.FirstOrDefault(Endereco => Endereco.Id == id);
            if (Endereco == null)
            {
                return NotFound();
            }
            _context.Remove(Endereco);
            _context.SaveChanges();

            return NoContent();
        }

    }
}
