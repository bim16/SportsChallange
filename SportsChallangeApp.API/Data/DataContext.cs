using Microsoft.EntityFrameworkCore;
using SportsChallangeApp.API.Models;

namespace SportsChallangeApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Value> Values { get; set; }
    }
}