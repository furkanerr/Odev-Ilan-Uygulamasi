using System.Collections.Generic;
using Ödev.Entities.Concretee;

namespace ÖdevUI.Models
{
    public class UserUpdateViewModel
    {
        public User User { get; set; }
        public List<City> City { get; set; }
    }
}