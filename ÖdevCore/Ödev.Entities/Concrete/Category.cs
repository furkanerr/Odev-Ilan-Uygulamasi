using System.Collections.Generic;
using Ödev.Core.Entities;

namespace Ödev.Entities.Concretee
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public List<Ads> Adses { get; set; }

    }
}