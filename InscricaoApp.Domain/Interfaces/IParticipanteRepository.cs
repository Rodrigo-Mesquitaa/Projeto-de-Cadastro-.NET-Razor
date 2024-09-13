using InscricaoApp.Domain.Entities;

namespace InscricaoApp.Domain.Interfaces
{
    public interface IParticipanteRepository
    {
        Task<IEnumerable<Participante>> GetParticipantesAsync();
        Task<Participante> GetParticipanteByIdAsync(int id);
        Task AddParticipanteAsync(Participante participante);
        Task UpdateParticipanteAsync(Participante participante);
        Task DeleteParticipanteAsync(int id);
        Task UpdateAsync(Participante participante);
        Task AddAsync(Participante participante);
        Task<Participante> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task<IEnumerable<Participante>> GetAllAsync();
    }
}