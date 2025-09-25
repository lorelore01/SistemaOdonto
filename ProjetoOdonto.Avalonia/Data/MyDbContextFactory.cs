using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ProjetoOdonto.Avalonia.Data
{
    public class MyDbContextFactory : IDesignTimeDbContextFactory<MyDbContext>
    {
        public MyDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
            _ = optionsBuilder.UseNpgsql("Host=localhost;Database=meubanco;Username=postgres;Password=pgbenkyou");

            return new MyDbContext(optionsBuilder.Options);
        }
    }
}
