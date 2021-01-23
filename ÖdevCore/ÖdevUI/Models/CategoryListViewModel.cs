using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ödev.Entities.Concretee;

namespace ÖdevUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public List<PetType> PetTypes { get; set; }
        public int CurrentCategory { get; internal set; }
     
    }
}
