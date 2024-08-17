using AutoMapper;
using BurgerMvc.BLL.Dtos;
using BurgerMvc.Models;

namespace BurgerMvc.Mapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserDto,UserViewModel >().ReverseMap();
            CreateMap<ExtraIngredientDto, ExtraIngredientViewModel>().ReverseMap();
            CreateMap<MenuItemDto,MenuItemViewModel>().ReverseMap();
            CreateMap<OrderDto,OrderViewModel>().ReverseMap();
            CreateMap<OrdersExtraDto,OrdersExtraViewModel>().ReverseMap();
            CreateMap<OrdersMenuDto,OrdersMenuViewModel>().ReverseMap();

        }
    }
}
