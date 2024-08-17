using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMvc.DAL.Entities
{
     public class User:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Photo { get; set; }
        public DateTime Birthdate { get; set; }
        public bool IsAdmin { get; set; }
        public List<Order> Orders { get; set; }

    }
}
