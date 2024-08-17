namespace BurgerMvc.Models
{
    public class UserViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Photo { get; set; }
        public IFormFile? PhotoUrl { get; set; }
        public DateTime Birthdate { get; set; }
        public bool IsAdmin { get; set; }
        public List<OrderViewModel> OrderViewModels { get; set; }
    }
}
