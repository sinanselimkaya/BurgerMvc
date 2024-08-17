using BurgerMvc.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMvc.BLL.Dtos
{
    public class OrderDto:BaseDto
    {
        public int UserId { get; set; }
        public UserDto UserDto { get; set; }
        public List<OrdersMenuDto> OrdersMenuDtos { get; set; }
        public List<OrdersExtraDto> OrdersExtraDtos{ get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsOrderConfirmed { get; set; }
    }
}
