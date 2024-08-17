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
    public class OrderCustomerService : IOrderCustomerService
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IMapper _mapper;
        private readonly IRepository<OrdersExtra> _ordersExtraRepository;
        private readonly IRepository<OrdersMenu> _ordersMenuRepository;

        public OrderCustomerService(IRepository<Order> orderRepository, IMapper mapper, IRepository<OrdersExtra> ordersExtraRepository, IRepository<OrdersMenu> ordersMenuRepository)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _ordersExtraRepository = ordersExtraRepository;
            _ordersMenuRepository = ordersMenuRepository;
        }

        public async Task<List<OrdersExtraDto>> GetAllOrdersExtra()
        {
            var ordersExtras = await _ordersExtraRepository.GetAllAsync();
            return _mapper.Map<List<OrdersExtraDto>>(ordersExtras);
        }

        public async Task<List<OrdersMenuDto>> GetAllOrdersMenu()
        {
            var ordersmenus = await _ordersMenuRepository.GetAllAsync();
            return _mapper.Map<List<OrdersMenuDto>>(ordersmenus);
        }
        public async Task<int> OrderAdd(OrderDto orderDto)
        {
            var order = _mapper.Map<Order>(orderDto);
         
            await _orderRepository.AddAsync(order);
            return order.Id;
        }

        public async Task OrdersExtraAdd(OrdersExtraDto ordersExtraDto)
        {
            var ordersExtra = _mapper.Map<OrdersExtra>(ordersExtraDto);
            await _ordersExtraRepository.AddAsync(ordersExtra);
        }

        public async Task OrdersExtraDelete(int ordersExtraId)
        {
            await _ordersExtraRepository.DeleteAsync(ordersExtraId);
        }

        public async Task OrdersMenuAdd(OrdersMenuDto ordersMenuDto)
        {
            var ordersMenu = _mapper.Map<OrdersMenu>(ordersMenuDto);
            await _ordersMenuRepository.AddAsync(ordersMenu);
        }

        public async Task OrdersMenuDelete(int ordersMenuId)
        {
            await _ordersMenuRepository.DeleteAsync(ordersMenuId);
        }

        public async Task OrderUpdateTotal(int orderId, OrderDto orderDto)
        {
            var order = await _orderRepository.GetByIdAsync(orderId);
            order.TotalPrice=orderDto.TotalPrice;
            order.IsOrderConfirmed = orderDto.IsOrderConfirmed;

            await _orderRepository.UpdateAsync(order);
        }
        public async Task<List<OrderDto>> GetAllOrder()
        {
            var orders = await _orderRepository.GetAllAsync();
            return _mapper.Map<List<OrderDto>>(orders);
        }
    }
}
