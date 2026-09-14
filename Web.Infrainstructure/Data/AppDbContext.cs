using Microsoft.EntityFrameworkCore;
using Web.Dommain.Entities;

namespace Web.Infrainstructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
                
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<AccountPlan> AccountPlans { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountPlan>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Type).IsRequired();
                entity.Property(e => e.AcceptsLaunches).IsRequired();
                
                entity.HasOne<AccountPlan>()
                      .WithMany()
                     //.HasForeignKey()
                      .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
