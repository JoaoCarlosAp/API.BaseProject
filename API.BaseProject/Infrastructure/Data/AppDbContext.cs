using API.BaseProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.BaseProject.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Perfil> Perfis { get; set; }
    }
}
