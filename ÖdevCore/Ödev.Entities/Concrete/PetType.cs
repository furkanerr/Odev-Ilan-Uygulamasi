using System.Collections.Generic;
using Ödev.Core.Entities;

namespace Ödev.Entities.Concretee
{
    public class PetType:IEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public List<Ads> Adses { get; set; }
        public List<PetBreed> PetBreeds { get; set; }
    }
}