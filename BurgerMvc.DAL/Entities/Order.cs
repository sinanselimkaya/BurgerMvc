using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BurgerMvc.DAL.Entities.Enum;

namespace BurgerMvc.DAL.Entities
{
    public class Order:BaseEntity
    {
      
        public int? UserId { get; set; }
        public User? User { get; set; }
        public List<OrdersMenu> OrdersMenus { get; set; }
        public List<OrdersExtra>? OrdersExtras{ get; set; }
        public decimal? TotalPrice { get; set; }
        public bool IsOrderConfirmed { get; set; } = false;
    }
}
