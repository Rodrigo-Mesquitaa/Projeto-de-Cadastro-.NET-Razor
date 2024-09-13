using InscricaoApp.Api.DTOs;
using InscricaoApp.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace InscricaoApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantesController : ControllerBase
    {
        private readonly ParticipanteService _participanteService;

        public ParticipantesController(ParticipanteService participanteService)
        {
            _participanteService = participanteService;
        }

        [HttpGet]
        public async Task<IEnumerable<ParticipanteDto>> GetParticipantesAsync()
        {
            return await _participanteService.GetParticipantesAsync();
        }

        [HttpPost]
        public async Task<ActionResult> AddParticipanteAsync(ParticipanteDto participanteDto)
        {
            await _participanteService.AddParticipanteAsync(participanteDto);
            return Ok();
        }
    }
}