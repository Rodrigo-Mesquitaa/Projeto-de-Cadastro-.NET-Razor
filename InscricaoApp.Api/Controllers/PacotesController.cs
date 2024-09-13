using InscricaoApp.Api.Services;
using InscricaoApp.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace InscricaoApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacotesController : ControllerBase
    {
        private readonly PacoteService _pacoteService;

        public PacotesController(PacoteService pacoteService)
        {
            _pacoteService = pacoteService;
        }

        // GET: api/pacotes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pacote>>> GetPacotes()
        {
            var pacotes = await _pacoteService.GetPacotesAsync();
            return Ok(pacotes);
        }

        // GET: api/pacotes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pacote>> GetPacote(int id)
        {
            var pacote = await _pacoteService.GetPacoteByIdAsync(id);

            if (pacote == null)
            {
                return NotFound();
            }

            return Ok(pacote);
        }

        // POST: api/pacotes
        [HttpPost]
        public async Task<ActionResult<Pacote>> PostPacote(Pacote pacote)
        {
            await _pacoteService.AddPacoteAsync(pacote);
            return CreatedAtAction(nameof(GetPacote), new { id = pacote.Id }, pacote);
        }

        // PUT: api/pacotes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPacote(int id, Pacote pacote)
        {
            if (id != pacote.Id)
            {
                return BadRequest();
            }

            await _pacoteService.UpdatePacoteAsync(pacote);
            return NoContent();
        }

        // DELETE: api/pacotes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePacote(int id)
        {
            await _pacoteService.DeletePacoteAsync(id);
            return NoContent();
        }
    }
}