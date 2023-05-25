using Microsoft.EntityFrameworkCore;
using WebPizzaStore.Models;

namespace WebPizzaStore.Context
{
    public class PizzaContext  : DbContext

    {
        public PizzaContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Pizza> Pizza { get; set; }
    }
}
