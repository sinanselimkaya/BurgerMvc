using BurgerMvc.BLL.Dtos;

namespace BurgerMvc.Models
{
    public class OrdersMenuViewModel:BaseViewModel
    {
        public int OrderId { get; set; }
        public OrderViewModel OrderViewModel { get; set; }
        public int MenuItemId { get; set; }
        public MenuItemViewModel MenuItemViewModel { get; set; }
        public int Quantity { get; set; }
        public Size Size { get; set; }
    }
}
