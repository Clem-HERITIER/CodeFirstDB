using CodeFirstDB.Model;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstDB
{
    public class WikiBeerContext : DbContext
    {
        public DbSet<BeerEntity> Beers { get; set; }
        public DbSet<BreweryEntity> Brewerys { get; set; }
        public DbSet<BeerColorEntity> BeerColors { get; set; }
        public DbSet<BeerStyleEntity> BeerStyles { get; set; }
        public DbSet<CountryEntity> Countrys { get; set; }
        public DbSet<IngredientEntity> Ingredients { get; set; }
        public DbSet<HopEntity> Hops { get; set; }
        public DbSet<AdditiveEntity> Additives { get; set; }
        public DbSet<CerealEntity> Cereals { get; set; }
        public DbSet<BeerIngredientEntity> BeerIngredients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=WikiBeer");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }

}
