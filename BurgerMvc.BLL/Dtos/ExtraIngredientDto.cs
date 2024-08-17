using BurgerMvc.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMvc.BLL.Dtos
{
    public class ExtraIngredientDto:BaseDto
    {
        public string Photo { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<OrdersExtraDto> OrdersExtraDtos { get; set; }

    }
}
