using BurgerMvc.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMvc.BLL.Dtos
{
    public class OrdersMenuDto:BaseDto
    {
        public int OrderId { get; set; }
        public OrderDto OrderDto { get; set; }
        public int MenuItemId { get; set; }
        public MenuItemDto MenuItemDto { get; set; }
        public int Quantity { get; set; }
        public Size Size { get; set; }
    }
}
