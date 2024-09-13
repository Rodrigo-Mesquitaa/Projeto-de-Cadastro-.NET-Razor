using InscricaoApp.Api.Data;
using InscricaoApp.Domain.Entities;
using InscricaoApp.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InscricaoApp.Api.Repositories
{
    public class ParticipanteRepository : IParticipanteRepository
    {
        private readonly ApplicationDbContext _context;

        public ParticipanteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Participante>> GetAllAsync()
        {
            return await _context.Participantes.Include(p => p.Pacote).ToListAsync();
        }

        public async Task<Participante> GetByIdAsync(int id)
        {
            return await _context.Participantes.Include(p => p.Pacote).FirstOrDefaultAsync(p => p.CodPar == id);
        }

        public async Task AddAsync(Participante participante)
        {
            _context.Participantes.Add(participante);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Participante participante)
        {
            _context.Participantes.Update(participante);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var participante = await GetByIdAsync(id);
            if (participante != null)
            {
                _context.Participantes.Remove(participante);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Participante>> GetParticipantesAsync()
        {
            return await GetAllAsync();
        }

        public async Task<Participante> GetParticipanteByIdAsync(int id)
        {
            return await GetByIdAsync(id);
        }

        public async Task AddParticipanteAsync(Participante participante)
        {
            await AddAsync(participante);
        }

        public async Task UpdateParticipanteAsync(Participante participante)
        {
            await UpdateAsync(participante);
        }

        public async Task DeleteParticipanteAsync(int id)
        {
            await DeleteAsync(id);
        }
    }
}