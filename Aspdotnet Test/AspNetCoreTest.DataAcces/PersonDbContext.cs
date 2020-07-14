using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AspNetCoreTest.DataAcces
{
    public class PersonDbContext : DbContext //dbase
    {
        public DbSet<Person> People { get; set; } //table
        public DbSet<Address> Address { get; set; } //table

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Initial Catalog=PersonTestDb;Integrated Security=True;");
        }
    }
}
