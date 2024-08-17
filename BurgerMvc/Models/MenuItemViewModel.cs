namespace BurgerMvc.Models
{
    public class MenuItemViewModel:BaseViewModel
    {
        public string? Photo { get; set; }
        public IFormFile? PhotoUrl { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public decimal Price { get; set; }
        public List<OrdersMenuViewModel> OrdersMenuViewModels { get; set; }

    }
}
