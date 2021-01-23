using System.Collections.Generic;
using Ödev.Core.Entities;

namespace Ödev.Entities.Concretee
{
    public class Gender:IEntity
    {
        public int Id { get; set; }
        public string Sex { get; set; }

        public List<Ads> Adses { get; set; }


    }
}