using Microsoft.EntityFrameworkCore;
using WebApplication11.Model;

namespace WebApplication11.Data
{
    public class PizzaContext:DbContext
    {
        //public PizzaContext(DbContextOptions<PizzaContext> options)
        //    : base(options)
        //{

        //}
        protected readonly IConfiguration Configuration;
        public PizzaContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<Pizza> Pizzas => Set<Pizza>();


    }
}
