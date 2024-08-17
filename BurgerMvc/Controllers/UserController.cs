using AutoMapper;
using BurgerMvc.BLL.AbstractServices;
using BurgerMvc.BLL.Dtos;
using BurgerMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMvc.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserViewModel userViewModel)
        {
            if (userViewModel.PhotoUrl != null)
            {
                var fileName = Path.GetFileName(userViewModel.PhotoUrl.FileName);
                var filePath = Path.Combine("wwwroot", "Images", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await userViewModel.PhotoUrl.CopyToAsync(stream);
                }
                userViewModel.Photo = fileName;
            }
                var userDto = _mapper.Map<UserDto>(userViewModel);
                await _userService.Register(userDto);
                return RedirectToAction("Login");
            
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            var userDto = await _userService.Login(email, password);
            if (userDto != null)
            {
                var userViewModel = _mapper.Map<UserViewModel>(userDto);

                HttpContext.Session.SetInt32("UserId", userViewModel.Id);
                HttpContext.Session.SetString("Email", userViewModel.Email);
                HttpContext.Session.SetString("IsAdmin", userViewModel.IsAdmin.ToString());

                if (userViewModel.IsAdmin == true)
                {
                    return RedirectToAction("Admin", "Order", userViewModel);

                }
                return RedirectToAction("Index", "OrderCustomer", userViewModel);
            }
            ViewData["Error"] = "E-posta veya şifre yanlış.";
            return View();
        }
        public async Task<IActionResult> Profille()
        {
            var userlogin = HttpContext.Session.GetInt32("UserId");

            var users = await _userService.GetAllUsers();
            var user = users.FirstOrDefault(x => x.Id == userlogin);
            var mapUser = _mapper.Map<UserViewModel>(user);

            return View(mapUser);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear(); //Kullanıcı çıkış yaptığında o kullanıcının giriş bilgileri sıfırlansın.
            return RedirectToAction("Login");
        }
    }
}

