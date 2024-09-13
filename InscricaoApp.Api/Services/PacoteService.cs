using InscricaoApp.Domain.Entities;
using InscricaoApp.Domain.Interfaces;

namespace InscricaoApp.Api.Services
{
    public class PacoteService
    {
        private readonly IPacoteRepository _pacoteRepository;

        public PacoteService(IPacoteRepository pacoteRepository)
        {
            _pacoteRepository = pacoteRepository;
        }

        public async Task<IEnumerable<Pacote>> GetPacotesAsync()
        {
            return await _pacoteRepository.GetAllAsync();
        }

        public async Task<Pacote> GetPacoteByIdAsync(int id)
        {
            return await _pacoteRepository.GetByIdAsync(id);
        }

        public async Task AddPacoteAsync(Pacote pacote)
        {
            await _pacoteRepository.AddAsync(pacote);
        }

        public async Task UpdatePacoteAsync(Pacote pacote)
        {
            await _pacoteRepository.UpdateAsync(pacote);
        }

        public async Task DeletePacoteAsync(int id)
        {
            await _pacoteRepository.DeleteAsync(id);
        }
    }
}