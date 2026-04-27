using Microsoft.EntityFrameworkCore;

namespace dev_reveste01_backend_2026.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<SolicitacaoTroca> SolicitacoesTroca { get; set; }
    }
}