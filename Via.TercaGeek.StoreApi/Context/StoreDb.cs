using Microsoft.EntityFrameworkCore;
using Via.TercaGeek.StoreApi.Models;

namespace Via.TercaGeek.StoreApi.Context
{
    public class StoreDb: DbContext
    {
        public StoreDb(DbContextOptions<StoreDb> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany(e => e.Addresses)
                .WithOne()
                .HasForeignKey(e => e.ClientId)
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Client> Clients => Set<Client>();
    }
}
