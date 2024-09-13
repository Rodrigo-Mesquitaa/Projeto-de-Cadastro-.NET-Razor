using InscricaoApp.Api.Services;
using InscricaoApp.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace InscricaoApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AtividadesController : ControllerBase
    {
        private readonly AtividadeService _atividadeService;

        public AtividadesController(AtividadeService atividadeService)
        {
            _atividadeService = atividadeService;
        }

        // GET: api/atividades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Atividade>>> GetAtividades()
        {
            var atividades = await _atividadeService.GetAtividadesAsync();
            return Ok(atividades);
        }

        // GET: api/atividades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Atividade>> GetAtividade(int id)
        {
            var atividade = await _atividadeService.GetAtividadeByIdAsync(id);

            if (atividade == null)
            {
                return NotFound();
            }

            return Ok(atividade);
        }

        // POST: api/atividades
        [HttpPost]
        public async Task<ActionResult<Atividade>> PostAtividade(Atividade atividade)
        {
            await _atividadeService.AddAtividadeAsync(atividade);
            return CreatedAtAction(nameof(GetAtividade), new { id = atividade.Id }, atividade);
        }

        // PUT: api/atividades/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAtividade(int id, Atividade atividade)
        {
            if (id == atividade.Id)
            {
                await _atividadeService.UpdateAtividadeAsync(atividade);
                return NoContent();
            }

            return BadRequest();
        }

        // DELETE: api/atividades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAtividade(int id)
        {
            await _atividadeService.DeleteAtividadeAsync(id);
            return NoContent();
        }
    }
}