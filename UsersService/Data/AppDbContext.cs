
using Microsoft.EntityFrameworkCore;
using UsersService.Entities;

namespace UsersService.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-MTLK40A;Database=ShauryaTechosoft;Integrated Security=True;");
        }
    }
}


