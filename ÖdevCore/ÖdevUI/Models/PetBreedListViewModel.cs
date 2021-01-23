using System.Collections.Generic;
using Ödev.Entities.Concretee;

namespace ÖdevUI.ViewComponenet
{
    public class PetBreedListViewModel
    {
        public List<PetType> petTypes;

        public List<Category> Categories { get; internal set; }
        public List<PetBreed> PetBreeds { get; set; }
       
    }
}