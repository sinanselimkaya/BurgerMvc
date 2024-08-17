using BurgerMvc.BLL.Dtos;
using BurgerMvc.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMvc.BLL.AbstractServices
{
    public interface IOrderCustomerService
    {
        Task<int> OrderAdd(OrderDto orderDto);
        Task OrdersMenuAdd(OrdersMenuDto ordersMenuDto);
        Task OrdersExtraAdd(OrdersExtraDto ordersExtraDto);
        Task<List<OrdersMenuDto>> GetAllOrdersMenu();
        Task<List<OrdersExtraDto>> GetAllOrdersExtra();
        Task OrdersMenuDelete(int ordersMenuId);
        Task OrdersExtraDelete(int ordersExtraId);
        Task OrderUpdateTotal(int orderId, OrderDto orderDto);
        Task<List<OrderDto>> GetAllOrder();
    }
}
