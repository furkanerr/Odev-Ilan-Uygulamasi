using System.Collections.Generic;
using Ödev.Core.Entities;

namespace Ödev.Entities.Concretee
{
    public class PetBreed:IEntity
    {
        public int Id { get; set; }
        public string Breed { get; set; }
        public List<Ads> Adses { get; set; }
        public PetType PetTypes { get; set; }
    }
}