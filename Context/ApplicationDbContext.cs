using MCVmma.Models;
using Microsoft.EntityFrameworkCore;

namespace MCVmma.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Usuario> UsuarioDb { get; set; }
        public DbSet<Roles> RolDb { get; set; }
    }
}
