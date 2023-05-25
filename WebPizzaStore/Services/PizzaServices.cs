using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using WebPizzaStore.Context;
using WebPizzaStore.Interface;
using WebPizzaStore.Models;

namespace WebPizzaStore.Services
{
    public class PizzaServices:IRepo<int,Pizza>
    {
        private readonly PizzaContext context;
        public PizzaServices(PizzaContext _context)
        {
            context = _context;

        }
        public Pizza Add(Pizza item)
        {
            if (context.Pizza.Contains(item))
            {
                return null;
            }
            context.Pizza.Add(item);
            context.SaveChanges();
            return item;
        }
        public Pizza Delete(int key)
        {
            var pizza = Get(key);
            if (pizza != null)
            {
                context.Remove(pizza);
                context.SaveChanges();
                return pizza;
            }
            return null;
        }

        public Pizza Get(int key)
        {
            Pizza pizza = context.Pizza.SingleOrDefault(p => p.id == key);
            if (pizza == null)
            {
                return null;
            }
            return pizza;
        }

        public ICollection<Pizza> GetAll()
        {
            List<Pizza> pizzas = context.Pizza.ToList();
            if (pizzas.Count > 0)
            {
                return pizzas;
            }
            return null;
        }

        public Pizza Update(Pizza item)
        {
            var pizza = Get(item.id);
            if (pizza != null)
            {
                pizza.name = item.name;
                pizza.price = item.price;
                pizza.quantity = item.quantity;
                pizza.type = item.type;
                context.SaveChanges();
                return pizza;
            }
            return null;
        }
    }
}
