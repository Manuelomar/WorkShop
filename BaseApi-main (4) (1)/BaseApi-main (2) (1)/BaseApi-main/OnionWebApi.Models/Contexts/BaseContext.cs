using Microsoft.EntityFrameworkCore;
using OnionWebApi.Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnionWebApi.Models.Contexts
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> contextOptions) : base(contextOptions)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Loans> Loans{ get; set; }
        public DbSet<Pay> Pay { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Loans>()
                .HasOne(m => m.Debtor)
                .WithMany(t => t.DebtorLoans)
                .IsRequired().HasForeignKey(m => m.DebtorId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Loans>()
                .HasOne(m => m.Creditor)
                .WithMany(t => t.CreditorLoans)
                .IsRequired().HasForeignKey(m => m.CreditorId)
                .OnDelete(DeleteBehavior.NoAction);


            foreach (var type in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(IBaseEntity).IsAssignableFrom(type.ClrType))
                    modelBuilder.SetSoftDeleteFilter(type.ClrType);
            }
          
        }
    }
}
