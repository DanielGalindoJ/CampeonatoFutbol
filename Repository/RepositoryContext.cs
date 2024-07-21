using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;
using Entities.Models.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace Repository
{
    public class RepositoryContext : IdentityDbContext<User>
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RoleConfiguration());


        }
        


    }
}