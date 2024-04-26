using Microsoft.EntityFrameworkCore;
using WebApiExamen2.Models;

namespace WebApiExamen2.Data
{
    public class CubosContext:DbContext
    {

        public CubosContext(DbContextOptions<CubosContext> options) : base(options) { }

        public DbSet<Cubo> Cubos { get; set; }
        public DbSet<UsuarioCubo> UsuariosCubos { get; set; }
        public DbSet<CompraCubo> ComprasCubos { get; set; }
        
    }
}
