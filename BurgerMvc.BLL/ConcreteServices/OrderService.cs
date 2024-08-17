using AutoMapper;
using BurgerMvc.BLL.AbstractServices;
using BurgerMvc.BLL.Dtos;
using BurgerMvc.DAL.AbstractRepository;
using BurgerMvc.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMvc.BLL.ConcreteServices
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<MenuItem> _menuRepository;


        private readonly IMapper _mapper;
        private readonly IRepository<ExtraIngredient> _extraRepository;

        public OrderService(IRepository<MenuItem> menuRepository, IMapper mapper,IRepository<ExtraIngredient> extraRepository)
        {
            _menuRepository = menuRepository;
            _mapper = mapper;
            _extraRepository = extraRepository;
        }

        public async Task AddMenu(MenuItemDto menuItemDto)
        {
            var menuItem = _mapper.Map<MenuItem>(menuItemDto);
            await _menuRepository.AddAsync(menuItem);
        }

        public async Task AddExtra(ExtraIngredientDto extraIngredientDto)
        {
           var extra = _mapper.Map<ExtraIngredient>(extraIngredientDto);
            await _extraRepository.AddAsync(extra);   
        }

        public async Task DeleteExtra(int extraId)
        {
            await _extraRepository.DeleteAsync(extraId);
        }

        public async Task DeleteMenu(int menuItemId)
        {
            await _menuRepository.DeleteAsync(menuItemId);
        }

        public async Task<List<ExtraIngredientDto>> GetAllExtra()
        {
            var extraIngredients = await _extraRepository.GetAllAsync();
            return _mapper.Map<List<ExtraIngredientDto>>(extraIngredients);
        }

        public async Task<List<MenuItemDto>> GetAllMenu()
        {
            var menus = await _menuRepository.GetAllAsync();
            return _mapper.Map<List<MenuItemDto>>(menus);
        }

        public async Task UpdateExtra(int extraId, ExtraIngredientDto extraIngredientDto)
        {
            var extra = await _extraRepository.GetByIdAsync(extraId);
            extra.Name = extraIngredientDto.Name;
            extra.Price = extraIngredientDto.Price;
            extra.Photo = extraIngredientDto.Photo;

            await _extraRepository.UpdateAsync(extra);
        }

        public async Task UpdateMenu(int menuItemId, MenuItemDto menuItemDto)
        {
            var menu = await _menuRepository.GetByIdAsync(menuItemId);
            menu.Title = menuItemDto.Title;
            menu.Content = menuItemDto.Content;
            menu.Price = menuItemDto.Price;
            menu.Photo= menuItemDto.Photo;

            await _menuRepository.UpdateAsync(menu);
        }
    }
}
