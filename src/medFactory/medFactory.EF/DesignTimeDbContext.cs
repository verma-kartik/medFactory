using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace medFactory.EF
{
    public class DesignTimeDbContext : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[]? args = null)
        {
            var options = new DbContextOptionsBuilder<DatabaseContext>();
            options.UseSqlServer("Server=localhost,1433;Database = medfactory;User Id = SA;Password = medFactory@1",
                b => b.MigrationsAssembly("medFactory.EF"));

            return new DatabaseContext(options.Options);
        }
    }
}