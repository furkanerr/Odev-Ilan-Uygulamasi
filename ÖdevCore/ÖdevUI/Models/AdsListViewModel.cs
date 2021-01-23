using System.Collections.Generic;
using Ödev.Entities.Concrete;
using Ödev.Entities.Concretee;
using Microsoft.EntityFrameworkCore.Query;
using X.PagedList;

namespace ÖdevUI.Models
{
    public class AdsListViewModel  
    {
      
        public List<Ads> IlanlarVeKategoriler { get; set; }
        public List<Ads> IlanlarKategorilerVePetTipleri { get; set; }

        public int PageCount { get; set; }
        public int PageSize { get; internal set; }
        public int CurrentCategory { get; internal set; }
        public int CurrentPage { get; internal set; }
        public List<PetType> PetTypes { get; internal set; }
        public List<Ads> AdsDetails { get; set; }
        public Comment Comment { get; set; }
        public List<Ads> AdsByUser { get; set; }
        public Ads ModelForComment { get; set; }
    }
}