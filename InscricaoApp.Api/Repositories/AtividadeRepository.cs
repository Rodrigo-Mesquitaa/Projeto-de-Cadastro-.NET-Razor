using InscricaoApp.Api.Data;
using InscricaoApp.Domain.Entities;
using InscricaoApp.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InscricaoApp.Api.Repositories
{
    public class AtividadeRepository : IAtividadeRepository
    {
        private readonly ApplicationDbContext _context;

        public AtividadeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Atividade>> GetAllAsync()
        {
            return await _context.Atividades.ToListAsync();
        }

        public async Task<Atividade> GetByIdAsync(int id)
        {
            return await _context.Atividades.FindAsync(id);
        }

        public async Task AddAsync(Atividade atividade)
        {
            _context.Atividades.Add(atividade);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Atividade atividade)
        {
            _context.Atividades.Update(atividade);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var atividade = await GetByIdAsync(id);
            if (atividade != null)
            {
                _context.Atividades.Remove(atividade);
                await _context.SaveChangesAsync();
            }
        }

        internal async Task<IEnumerable<object>> GetAtividadesAsync()
        {
            throw new NotImplementedException();
        }
    }
}