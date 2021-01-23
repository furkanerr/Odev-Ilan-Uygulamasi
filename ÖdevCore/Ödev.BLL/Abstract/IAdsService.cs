using System.Collections.Generic;
using Ödev.Entities.Concretee;

namespace Ödev.BLL.Abstract
{
    public interface IAdsService
    {
        List<Ads> GetAll();
        List<Ads> GetByCategory(int adsId);
        void Add(Ads ads);
        void Update(Ads ads);
        void Delete(int adsId);
        Ads GetById(int adsId);
        public List<Ads> İlanlarinKategorisiVePetCinsleri();
        public List<Ads> İlanlarinKategorisiVePetTipi(int CategoryId,int petBreedId,int petTypes);
        public List<Ads> AdsByUserId(int UserId);
        public List<Ads> AdsDetails(int AdsId);

    }
}