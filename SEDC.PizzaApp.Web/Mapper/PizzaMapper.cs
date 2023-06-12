using SEDC.PizzaApp.Web.Models.Domain;
using SEDC.PizzaApp.Web.Models.ViewModels;
using System.Runtime.CompilerServices;

namespace SEDC.PizzaApp.Web.Mapper
{
    public static class PizzaMapper
    {
        public static PizzaViewModel ToViewModel(this Pizza pizza)
        {
            return new PizzaViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,
                IsOnPromotion = pizza.IsOnPromotion,
                Price = pizza.Price
            };
        }

    }
}
