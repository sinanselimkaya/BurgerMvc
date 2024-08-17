using AutoMapper;
using BurgerMvc.BLL.AbstractServices;
using BurgerMvc.BLL.ConcreteServices;
using BurgerMvc.BLL.Dtos;
using BurgerMvc.DAL.Entities;
using BurgerMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMvc.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;
        private readonly IOrderCustomerService _orderCustomerService;
        private readonly IUserService _userService;

        public OrderController(IOrderService orderService, IMapper mapper, IOrderCustomerService orderCustomerService,IUserService userService)
        {
            _orderService = orderService;
            _mapper = mapper;
            _orderCustomerService = orderCustomerService;
            _userService = userService;
        }

        public async Task<IActionResult> Admin()
        {
            var menus = await _orderService.GetAllMenu();
            var allmenus = _mapper.Map<List<MenuItemViewModel>>(menus);
            var extras = await _orderService.GetAllExtra();
            var extra = _mapper.Map<List<ExtraIngredientViewModel>>(extras);
            ViewBag.Extras = extra;
            return View(allmenus);

        }

        [HttpGet]
        public IActionResult MenuAdd()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MenuAdd(MenuItemViewModel menuItemViewModel)
        {
            if (menuItemViewModel.PhotoUrl != null)
            {
                var fileName = Path.GetFileName(menuItemViewModel.PhotoUrl.FileName);
                var filePath = Path.Combine("wwwroot", "Images", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await menuItemViewModel.PhotoUrl.CopyToAsync(stream);
                }

                menuItemViewModel.Photo = fileName;
            }
            var menu = _mapper.Map<MenuItemDto>(menuItemViewModel);
            await _orderService.AddMenu(menu);
            return RedirectToAction("Admin");
        }

        [HttpPost]
        public async Task<IActionResult> MenuDelete(int menuItemId)
        {
            await _orderService.DeleteMenu(menuItemId);
            return RedirectToAction("Admin");
        }

        [HttpGet]
        public async Task<IActionResult> MenuUpdate(int menuItemId)
        {
            var menus = await _orderService.GetAllMenu();
            var menu = menus.FirstOrDefault(x => x.Id == menuItemId);
            var menuMap = _mapper.Map<MenuItemViewModel>(menu);
            return View(menuMap);
        }

        [HttpPost]
        public async Task<IActionResult> MenuUpdate(int menuItemId,IFormFile Photo, MenuItemDto menuItemDto)
        {
            if (Photo != null)
            {
                var fileName = Path.GetFileName(Photo.FileName);
                var filePath = Path.Combine("wwwroot", "Images", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await Photo.CopyToAsync(stream);
                }
            }
            menuItemDto.Photo = Photo.FileName;
            await _orderService.UpdateMenu(menuItemId, menuItemDto);
            return RedirectToAction("Admin");
        }

        [HttpGet]
        public IActionResult ExtraAdd()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ExtraAdd(ExtraIngredientViewModel extraIngredientViewModel)
        {
            if (extraIngredientViewModel.PhotoUrl != null)
            {
                var fileName = Path.GetFileName(extraIngredientViewModel.PhotoUrl.FileName);
                var filePath = Path.Combine("wwwroot", "Images", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await extraIngredientViewModel.PhotoUrl.CopyToAsync(stream);
                }

                extraIngredientViewModel.Photo = fileName;
            }
            var extra = _mapper.Map<ExtraIngredientDto>(extraIngredientViewModel);
            await _orderService.AddExtra(extra);
            return RedirectToAction("Admin");
        }
        [HttpPost]
        public async Task<IActionResult> ExtraDelete(int extraId)
        {
            await _orderService.DeleteExtra(extraId);
            return RedirectToAction("Admin");
        }

        [HttpGet]
        public async Task<IActionResult> ExtraUpdate(int extraId)
        {
            var extras = await _orderService.GetAllExtra();
            var extra = extras.FirstOrDefault(x => x.Id == extraId);
            var extraMap = _mapper.Map<ExtraIngredientViewModel>(extra);
            return View(extraMap);
        }

        [HttpPost]
        public async Task<IActionResult> ExtraUpdate(int extraId, IFormFile Photo, ExtraIngredientDto extraIngredientDto)
        {
            if (Photo != null)
            {
                var fileName = Path.GetFileName(Photo.FileName);
                var filePath = Path.Combine("wwwroot", "Images", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await Photo.CopyToAsync(stream);
                }
            }
            extraIngredientDto.Photo = Photo.FileName;
            await _orderService.UpdateExtra(extraId, extraIngredientDto);
            return RedirectToAction("Admin");
        }

        [HttpGet]
        public async Task<IActionResult> GetByOrdersForUser()
        {
            var orders = await _orderCustomerService.GetAllOrder();
            var order = orders.Where(x => x.IsOrderConfirmed == true).OrderByDescending(x => x.ModifiedDate);
            var ordermap = _mapper.Map<List<OrderViewModel>>(order);
            return View(ordermap);
        }

        [HttpGet]
        public async Task<IActionResult> OrderDetail(int orderId, int userId)
        {
            var users = await _userService.GetAllUsers();
            var user = users.FirstOrDefault(x => x.Id == userId);
            var mapUser = _mapper.Map<UserViewModel>(user);

            var ordersMenus = await _orderCustomerService.GetAllOrdersMenu();
            var orderMenus = ordersMenus.Where(x => x.OrderId == orderId).ToList();
            var mapOrderMenus = _mapper.Map<List<OrdersMenuViewModel>>(orderMenus);
            ViewBag.Ordersmenus = mapOrderMenus;

            var ordersExtras = await _orderCustomerService.GetAllOrdersExtra();
            var orderExtras = ordersExtras.Where(x => x.OrderId == orderId).ToList();
            var mapOrderExtras = _mapper.Map<List<OrdersExtraViewModel>>(orderExtras);
            ViewBag.Ordersextras = mapOrderExtras;

            var menus = await _orderService.GetAllMenu();
            var mappMenus = _mapper.Map<List<MenuItemViewModel>>(menus);
            ViewBag.Menus = mappMenus;

            var extras = await _orderService.GetAllExtra();
            var mapExtras = _mapper.Map<List<ExtraIngredientViewModel>>(extras);
            ViewBag.Extras = mapExtras;

            return View(mapUser);
        }
    }
}
