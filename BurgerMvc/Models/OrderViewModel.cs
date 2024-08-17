using BurgerMvc.BLL.Dtos;
using BurgerMvc.DAL.Entities;
using BurgerMvc.DAL.Entities.Enum;
using BurgerMvc.Models.Enum;
using System.Drawing;

namespace BurgerMvc.Models
{
    public class OrderViewModel : BaseViewModel
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public List<OrdersMenuViewModel> OrdersMenuViewModels { get; set; }        
        public List<OrdersExtraViewModel> OrdersExtraViewModels{ get; set; }        
        public decimal TotalPrice { get; set; }
        public bool IsOrderConfirmed { get; set; }
    }
}
