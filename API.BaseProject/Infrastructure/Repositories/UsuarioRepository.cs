using API.BaseProject.Domain.Entities;
using API.BaseProject.Domain.Interfaces;
using API.BaseProject.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace API.BaseProject.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _context;

        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Usuario?> GetByIdAsync(int id) =>
            await _context.Usuarios.Include(u => u.Contas).ThenInclude(c => c.Perfis).FirstOrDefaultAsync(u => u.Id == id);

        public async Task<IEnumerable<Usuario>> GetAllAsync() =>
            await _context.Usuarios.ToListAsync();

        public async Task AddAsync(Usuario usuario)
        {
            await _context.Usuarios.AddAsync(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                await _context.SaveChangesAsync();
            }
        }
    }
}
