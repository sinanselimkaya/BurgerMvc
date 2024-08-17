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
   public class UserService: IUserService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IMapper _mapper;

        public UserService(IRepository<User> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<List<UserDto>> GetAllUsers()
        {
            var users = await _userRepository.GetAllAsync();
            return _mapper.Map<List<UserDto>>(users);
        }

        public async Task<UserDto> Login(string email, string password)
        {
            var users = await _userRepository.GetAllAsync();
            var user = users.FirstOrDefault(x => x.Email == email && x.Password == password);
            return _mapper.Map<UserDto>(user);
        }

        public async Task Register(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            await _userRepository.AddAsync(user);
        }
    }

}
