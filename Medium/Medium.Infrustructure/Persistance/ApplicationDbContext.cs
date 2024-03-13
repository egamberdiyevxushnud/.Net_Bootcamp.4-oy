using Medium.Application.Abstractions;
using Medium.Domain.Entity.Model;
using Microsoft.EntityFrameworkCore;

namespace Medium.Infrustructure.Persistance
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.Migrate();

        }
        public DbSet<User> Users { get; set; }

        public Task SavaChagesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
