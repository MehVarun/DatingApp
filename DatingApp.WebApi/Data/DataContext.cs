using DatingApp.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.WebApi.Data
{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Value> Values { get; set; }
    }
}