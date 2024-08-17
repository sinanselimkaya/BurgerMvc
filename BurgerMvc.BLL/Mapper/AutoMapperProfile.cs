using AutoMapper;
using BurgerMvc.BLL.Dtos;
using BurgerMvc.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMvc.BLL.Mapper
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<ExtraIngredient,ExtraIngredientDto>().ReverseMap();
            CreateMap<MenuItem,MenuItemDto>().ReverseMap();
            CreateMap<Order,OrderDto>().ReverseMap();
            CreateMap<OrdersExtra,OrdersExtraDto>().ReverseMap();
            CreateMap<OrdersMenu,OrdersMenuDto>().ReverseMap();
            

        }
    }
}
