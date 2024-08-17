using BurgerMvc.DAL.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMvc.DAL.Entities
{
    public class OrdersExtra:BaseEntity
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ExtraIngredientId { get; set; }
        public ExtraIngredient ExtraIngredient { get; set; }
        public int Quantity { get; set; }
    }
}
