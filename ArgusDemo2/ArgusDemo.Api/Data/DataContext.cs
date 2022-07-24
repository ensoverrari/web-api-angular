using ArgusDemo.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace ArgusDemo.Api.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
