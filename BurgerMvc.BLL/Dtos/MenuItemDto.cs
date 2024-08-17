using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMvc.BLL.Dtos
{
    public class MenuItemDto:BaseDto
    {
        public string? Photo { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public decimal Price { get; set; }
        public List<OrdersMenuDto> OrdersMenuDtos { get; set; }

    }
}
