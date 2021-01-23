using Ödev.Entities.Concretee;
using Microsoft.EntityFrameworkCore;

namespace Ödev.Entities.Concrete
{
    public class ProjeDbContext:DbContext
    {
        
        public DbSet<User> Users { get; set; }
        public DbSet<PetBreed> PetBreeds { get; set; }
        public DbSet<PetType> PetTypes { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Ads> Adses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PasswordCode> PasswordCodes { get; set; }
        public DbSet<Comment> Comments { get; set; }

       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
           optionsBuilder.UseSqlServer(@"database");
            
        }
        

    }
}