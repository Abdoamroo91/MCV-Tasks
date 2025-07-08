using Microsoft.EntityFrameworkCore;
using MyApp.Models;
using WebApplication1.Models;
namespace MyApp.Data

{
    public class MyAppContext : DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }


    }
}