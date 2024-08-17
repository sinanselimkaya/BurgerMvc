using BurgerMvc.BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMvc.BLL.AbstractServices
{
    public interface IUserService
    {
        Task Register(UserDto userDto);
        Task<UserDto> Login(string email, string password);
        Task<List<UserDto>> GetAllUsers();
    }
}
