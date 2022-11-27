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
    public class CinemaController : ControllerBase
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public CinemaController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        [HttpPost]
        public IActionResult AdicionarCinema([FromBody] CreateCinemaDto CinemaDto)
        {
            Cinema Cinema = _mapper.Map<Cinema>(CinemaDto);
            _context.Cinemas.Add(Cinema);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperarCinemasPorId), new { Id = Cinema.Id }, Cinema);
        }

        [HttpGet]

        public IActionResult RecuperarCinemas()
        {
            return Ok(_context.Cinemas);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarCinemasPorId(int id)
        {
            Cinema Cinema = _context.Cinemas.FirstOrDefault(Cinema => Cinema.Id == id);

            if(Cinema != null)
            {
                ReadCinemaDto CinemaDto = _mapper.Map<ReadCinemaDto>(Cinema);

                return Ok(CinemaDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaCinema(int id, [FromBody] UpdateCinemaDto CinemaDto)
        {
            Cinema Cinema = _context.Cinemas.FirstOrDefault(Cinema => Cinema.Id == id);
            if(Cinema == null)
            {
                return NotFound();
            }
            _mapper.Map(CinemaDto, Cinema);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult ExcluirCinema(int id)
        {
            Cinema Cinema = _context.Cinemas.FirstOrDefault(Cinema => Cinema.Id == id);
            if (Cinema == null)
            {
                return NotFound();
            }
            _context.Remove(Cinema);
            _context.SaveChanges();

            return NoContent();
        }

    }
}
