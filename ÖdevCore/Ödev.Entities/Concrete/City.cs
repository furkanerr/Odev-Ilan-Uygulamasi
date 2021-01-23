using System.Collections.Generic;
using Ödev.Core.Entities;

namespace Ödev.Entities.Concretee
{
    public class City:IEntity
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public List<Ads> Adses { get; set; }
    }
}