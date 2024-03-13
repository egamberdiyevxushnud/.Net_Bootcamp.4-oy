using Medium.Domain.Entity.Model;
using Microsoft.EntityFrameworkCore;

namespace Medium.Application.Abstractions
{
    public interface IApplicationDbContext
    {

        public DbSet<User> Users { get; set; }

        Task SavaChagesAsync(CancellationToken cancellationToken = default);
    }
}
