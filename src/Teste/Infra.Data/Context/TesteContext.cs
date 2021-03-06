using System.Linq;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Context
{
    public class TesteContext: DbContext
    {
        public TesteContext(DbContextOptions<TesteContext> options) : base(options)
        {
        }


        public DbSet<Customer> Customer { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Phone> Phone { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TesteContext).Assembly);

            foreach (var relation in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relation.DeleteBehavior = DeleteBehavior.Restrict;
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

    }
}