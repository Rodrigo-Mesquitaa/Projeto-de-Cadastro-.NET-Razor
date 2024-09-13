using InscricaoApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InscricaoApp.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Participante> Participantes { get; set; }
        public DbSet<Pacote> Pacotes { get; set; }
        public DbSet<Atividade> Atividades { get; set; }
    }
}