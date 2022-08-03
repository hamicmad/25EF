using Microsoft.EntityFrameworkCore;


namespace _25EF
{
    public class PHContext : DbContext
    {
        public DbSet<Drug> Drugs => Set<Drug>();
        public DbSet<Stock> Stocks => Set<Stock>();
        public DbSet<Sale> Sales => Set<Sale>();


        public PHContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Pharmacydb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stock>().HasNoKey()
                                        .HasOne(s => s.Drug)
                                        .WithMany()
                                        .HasForeignKey(p => p.DrugName)
                                        .HasPrincipalKey(d => d.Name)
                                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Sale>().HasOne(s => s.Drug)
                                       .WithMany()
                                       .HasForeignKey(p => p.DrugName)
                                       .HasPrincipalKey(d => d.Name)
                                       .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
