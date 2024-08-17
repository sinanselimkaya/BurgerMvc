using BurgerMvc.BLL.Dtos;

namespace BurgerMvc.Models
{
    public class OrdersExtraViewModel:BaseViewModel
    {
        public int OrderId { get; set; }
        public OrderViewModel OrderViewModel{ get; set; }
        public int ExtraIngredientId { get; set; }
        public ExtraIngredientViewModel ExtraIngredientViewModel { get; set; }
        public int Quantity { get; set; }
    }
}
