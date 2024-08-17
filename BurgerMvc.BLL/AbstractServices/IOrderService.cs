using BurgerMvc.BLL.Dtos;
using BurgerMvc.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMvc.BLL.AbstractServices
{
    public interface IOrderService
    {
        Task AddMenu(MenuItemDto menuItemDto);
        Task DeleteMenu(int menuItemId);
        Task UpdateMenu(int menuItemId,MenuItemDto menuItemDto);
        Task<List<MenuItemDto>> GetAllMenu();
        Task DeleteExtra(int extraId);
        Task UpdateExtra(int extraId, ExtraIngredientDto extraIngredientDto);
        Task<List<ExtraIngredientDto>> GetAllExtra();
        Task AddExtra(ExtraIngredientDto extraIngredientDto);
    }
}
