using InscricaoApp.Domain.Entities;

namespace InscricaoApp.Domain.Interfaces
{
    public interface IPacoteRepository
    {
        Task<IEnumerable<Pacote>> GetAllAsync();
        Task<Pacote> GetByIdAsync(int id);
        Task AddAsync(Pacote pacote);
        Task UpdateAsync(Pacote pacote);
        Task DeleteAsync(int id);
    }
}