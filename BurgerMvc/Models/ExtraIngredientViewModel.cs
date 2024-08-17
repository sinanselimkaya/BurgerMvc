using BurgerMvc.DAL.Entities;

namespace BurgerMvc.Models
{
    public class ExtraIngredientViewModel:BaseViewModel
    {
        public string? Photo { get; set; }
        public IFormFile? PhotoUrl { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<OrdersExtraViewModel> OrdersExtraViewModels { get; set; }
    }
}
