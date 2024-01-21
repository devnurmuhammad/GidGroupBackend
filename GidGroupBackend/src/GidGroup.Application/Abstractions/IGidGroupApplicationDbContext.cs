using GidGroup.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GidGroup.Application.Abstractions
{
    public interface IGidGroupApplicationDbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Recall> Recalls { get; set; }
        public DbSet<GetCatalog> GetCatalogs { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
