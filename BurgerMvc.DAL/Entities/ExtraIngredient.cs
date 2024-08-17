using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMvc.DAL.Entities
{
    public class ExtraIngredient:BaseEntity
    {
        public string? Photo { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<OrdersExtra> OrdersExtras { get; set; }

    }
}
