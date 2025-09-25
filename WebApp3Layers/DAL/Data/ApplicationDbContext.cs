using DAL.Data.Entities;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Biography> Biographies { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Author>()
                .HasOne(a => a.Biography)
                .WithOne(b => b.Author)
                .HasForeignKey<Biography>(b => b.AuthorId);
            builder.Entity<Company>()
             .HasMany(c => c.Employees)
             .WithOne(e => e.Company)
             .HasForeignKey(e => e.CompaniId);
            base.OnModelCreating(builder);
         
        }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
    }
}
