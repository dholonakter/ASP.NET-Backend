using WebApplication11.Model;

namespace WebApplication11.Data
{
    public static class IntializerDB
    {
        public  static void Initialize(PizzaContext context)
        {
            if (context.Pizzas.Any()){
                return;

            }
            var pizzas = new Pizza[]
            {
                new Pizza
                {
                    Name="Pizza1",
                    IsGlutenFree=false
                },
                new Pizza
                {
                    Name="Pizza2",
                    IsGlutenFree=false
                },
                 new Pizza
                {
                    Name="Pizza3",
                    IsGlutenFree=false
                },
                  new Pizza
                {
                    Name="Pizza4",
                    IsGlutenFree=false
                }

            };
            context.Pizzas.AddRange(pizzas);
            context.SaveChanges();

        }
    }
}
