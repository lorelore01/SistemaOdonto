using Microsoft.EntityFrameworkCore;
using ProjetoOdonto.Avalonia.Models;

namespace ProjetoOdonto.Avalonia.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
    }
}
