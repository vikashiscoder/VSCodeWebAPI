//using EFCore.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace CourseApi.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Country> CountryItem { get; set; }
    }
}