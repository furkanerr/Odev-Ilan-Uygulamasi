using System.Collections;
using System.Collections.Generic;
using Ödev.Entities.Concretee;

namespace ÖdevUI.Models
{
    public class AdsAddViewModel
    {
        public Ads Ads { get; set; }
        public List<Category> AdsCategory { get; set; }
        public List<PetBreed> PetBreed { get; internal set; }
        public List<PetType> PetType { get; internal set; }
        public List<City> City { get; internal set; }
        public List<Gender> Gender { get; set; }
        public User User { get; internal set; }

        
    }
}