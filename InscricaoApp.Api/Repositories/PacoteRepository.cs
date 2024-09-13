using InscricaoApp.Api.Data;
using InscricaoApp.Domain.Entities;
using InscricaoApp.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InscricaoApp.Api.Repositories
{
    public class PacoteRepository : IPacoteRepository
    {
        private readonly ApplicationDbContext _context;

        public PacoteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Pacote>> GetAllAsync()
        {
            return await _context.Pacotes.ToListAsync();
        }

        public async Task<Pacote> GetByIdAsync(int id)
        {
            return await _context.Pacotes.FindAsync(id);
        }

        public async Task AddAsync(Pacote pacote)
        {
            _context.Pacotes.Add(pacote);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Pacote pacote)
        {
            _context.Pacotes.Update(pacote);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var pacote = await GetByIdAsync(id);
            if (pacote != null)
            {
                _context.Pacotes.Remove(pacote);
                await _context.SaveChangesAsync();
            }
        }
    }
}