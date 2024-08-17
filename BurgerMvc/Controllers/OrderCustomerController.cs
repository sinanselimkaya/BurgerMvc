using AutoMapper;
using BurgerMvc.BLL.AbstractServices;
using BurgerMvc.BLL.Dtos;
using BurgerMvc.DAL.Entities;
using BurgerMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BurgerMvc.Controllers
{
    public class OrderCustomerController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;
        private readonly IOrderCustomerService _orderCustomerService;

        public OrderCustomerController(IOrderService orderService, IMapper mapper, IOrderCustomerService orderCustomerService)
        {
            _orderService = orderService;
            _mapper = mapper;
            _orderCustomerService = orderCustomerService;
        }

        public async Task<IActionResult> Index()
        {
            var menus = await _orderService.GetAllMenu();
            var allmenus = _mapper.Map<List<MenuItemViewModel>>(menus);
            var extras = await _orderService.GetAllExtra();
            var mapExtras = _mapper.Map<List<ExtraIngredientViewModel>>(extras);
            ViewBag.Extras = mapExtras;
            return View(allmenus);
        }
        public async Task<IActionResult> OrderCart()
        {
            var menus = await _orderService.GetAllMenu();
            var mappmenus = _mapper.Map<List<MenuItemViewModel>>(menus);
            ViewBag.Menus = mappmenus;

            var extras = await _orderService.GetAllExtra();
            var extra = _mapper.Map<List<ExtraIngredientViewModel>>(extras);
            ViewBag.Extras = extra;

            var orderactive = HttpContext.Session.GetInt32("OrderId");

            var ordersMenus = await _orderCustomerService.GetAllOrdersMenu();
            var menuwhere = ordersMenus.Where(x => x.OrderId == orderactive);
            ViewBag.OrdersMenus = _mapper.Map<List<OrdersMenuViewModel>>(menuwhere);

            var ordersExtras = await _orderCustomerService.GetAllOrdersExtra();
            var extraWhere = ordersExtras.Where(x => x.OrderId == orderactive);
            ViewBag.OrdersExtras = _mapper.Map<List<OrdersExtraViewModel>>(extraWhere);
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> OrderAdd()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> OrderAdd(OrderViewModel orderViewModel)
        {
            var order = _mapper.Map<OrderDto>(orderViewModel);
            var orderId = await _orderCustomerService.OrderAdd(order);
            if (orderId != 0)
            {
                HttpContext.Session.SetInt32("OrderId", orderId);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> OrdersMenuAdd(int menuId)
        {
            ViewBag.MenuId = menuId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> OrdersMenuAdd(OrdersMenuViewModel orderMenuViewModel)
        {
            var ordersMenu = _mapper.Map<OrdersMenuDto>(orderMenuViewModel);
            await _orderCustomerService.OrdersMenuAdd(ordersMenu);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> OrdersExtraAdd(int extraId)
        {
            ViewBag.ExtraId = extraId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> OrdersExtraAdd(OrdersExtraViewModel ordersExtraViewModel)
        {
            var ordersExtra = _mapper.Map<OrdersExtraDto>(ordersExtraViewModel);
            await _orderCustomerService.OrdersExtraAdd(ordersExtra);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> OrdersMenuDelete(int ordersMenuId)
        {
            await _orderCustomerService.OrdersMenuDelete(ordersMenuId);
            return RedirectToAction("OrderCart");
        }

        [HttpPost]
        public async Task<IActionResult> OrdersExtraDelete(int ordersExtraId)
        {
            await _orderCustomerService.OrdersExtraDelete(ordersExtraId);
            return RedirectToAction("OrderCart");
        }

        [HttpGet]
        public async Task<IActionResult> OrderUpdate(int orderId, decimal total)
        {
            ViewBag.Total = total;
            var orders = await _orderCustomerService.GetAllOrder();
            var order = orders.FirstOrDefault(x => x.Id == orderId);
            var ordermap = _mapper.Map<OrderViewModel>(order);
            return View(ordermap);
        }

        [HttpPost]
        public async Task<IActionResult> OrderUpdate(int orderId, OrderDto orderDto)
        {
            await _orderCustomerService.OrderUpdateTotal(orderId, orderDto);
            HttpContext.Session.Remove("OrderId");

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> GetByOrdersForUser()
        {
            var userlogin = HttpContext.Session.GetInt32("UserId");

            var orders = await _orderCustomerService.GetAllOrder();
            var order = orders.Where(x => x.IsOrderConfirmed == true && x.UserId == userlogin).OrderByDescending(x=>x.ModifiedDate);
            var ordermap = _mapper.Map<List<OrderViewModel>>(order);
            return View(ordermap);
        }

        [HttpGet]
        public async Task<IActionResult> OrderDetail(int orderId)
        {
            var ordersMenus = await _orderCustomerService.GetAllOrdersMenu();
            var orderMenus =  ordersMenus.Where(x=>x.OrderId== orderId).ToList();
            var mapOrderMenus = _mapper.Map<List<OrdersMenuViewModel>>(orderMenus);
            ViewBag.Ordersmenus = mapOrderMenus;

            var ordersExtras = await _orderCustomerService.GetAllOrdersExtra();
            var orderExtras = ordersExtras.Where(x=>x.OrderId==orderId).ToList();
            var mapOrderExtras = _mapper.Map<List<OrdersExtraViewModel>>(orderExtras);
            ViewBag.Ordersextras = mapOrderExtras;

            var menus = await _orderService.GetAllMenu();            
            var mappMenus = _mapper.Map<List<MenuItemViewModel>>(menus);
            ViewBag.Menus = mappMenus;

            var extras = await _orderService.GetAllExtra();
            var mapExtras = _mapper.Map<List<ExtraIngredientViewModel>>(extras);
            ViewBag.Extras = mapExtras;
            return View();
        }
    }
}
