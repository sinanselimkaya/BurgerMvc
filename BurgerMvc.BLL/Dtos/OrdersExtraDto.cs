using BurgerMvc.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMvc.BLL.Dtos
{
    public class OrdersExtraDto:BaseDto
    {
        public int OrderId { get; set; }
        public OrderDto OrderDto { get; set; }
        public int ExtraIngredientId { get; set; }
        public ExtraIngredientDto ExtraIngredientDto { get; set; }
        public int Quantity { get; set; }
    }
}
