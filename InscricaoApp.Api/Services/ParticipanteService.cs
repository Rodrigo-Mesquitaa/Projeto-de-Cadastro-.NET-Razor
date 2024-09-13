using InscricaoApp.Api.DTOs;
using InscricaoApp.Domain.Entities;
using InscricaoApp.Domain.Interfaces;

namespace InscricaoApp.Api.Services
{
    public class ParticipanteService
    {
        private readonly IParticipanteRepository _participanteRepository;

        public ParticipanteService(IParticipanteRepository participanteRepository)
        {
            _participanteRepository = participanteRepository;
        }

        public async Task<IEnumerable<Participante>> GetAllAsync()
        {
            return await _participanteRepository.GetAllAsync();
        }

        public async Task<Participante> GetByIdAsync(int id)
        {
            return await _participanteRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Participante participante)
        {
            await _participanteRepository.AddAsync(participante);
        }

        public async Task UpdateAsync(Participante participante)
        {
            await _participanteRepository.UpdateAsync(participante);
        }

        public async Task DeleteAsync(int id)
        {
            await _participanteRepository.DeleteAsync(id);
        }

        internal async Task AddParticipanteAsync(ParticipanteDto participanteDto)
        {
            throw new NotImplementedException();
        }

        internal async Task<IEnumerable<ParticipanteDto>> GetParticipantesAsync()
        {
            throw new NotImplementedException();
        }
    }
}