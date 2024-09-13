using InscricaoApp.Domain.Entities;
using InscricaoApp.Domain.Interfaces;

namespace InscricaoApp.Api.Services
{
    public class AtividadeService
    {
        private readonly IAtividadeRepository _atividadeRepository;

        public AtividadeService(IAtividadeRepository atividadeRepository)
        {
            _atividadeRepository = atividadeRepository;
        }

        public async Task<IEnumerable<Atividade>> GetAtividadesAsync()
        {
            return await _atividadeRepository.GetAllAsync();
        }

        public async Task<Atividade> GetAtividadeByIdAsync(int id)
        {
            return await _atividadeRepository.GetByIdAsync(id);
        }

        public async Task AddAtividadeAsync(Atividade atividade)
        {
            await _atividadeRepository.AddAsync(atividade);
        }

        public async Task UpdateAtividadeAsync(Atividade atividade)
        {
            await _atividadeRepository.UpdateAsync(atividade);
        }

        public async Task DeleteAtividadeAsync(int id)
        {
            await _atividadeRepository.DeleteAsync(id);
        }
    }
}