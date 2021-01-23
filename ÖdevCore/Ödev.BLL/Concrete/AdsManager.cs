using System.Collections.Generic;
using Ödev.BLL.Abstract;
using Ödev.DAL.Abstract;
using Ödev.Entities.Concretee;

namespace Ödev.BLL.Concrete
{
    public class AdsManager:IAdsService
    {
        private readonly IAdsDal _adsDal;

        public AdsManager(IAdsDal adsDal)
        {
            _adsDal = adsDal;
        }

        public List<Ads> GetAll()
        {
            return _adsDal.GetList();
        }

        public List<Ads> GetByCategory(int categoryId)
        {
            return _adsDal.GetList(a => a.CategoryId == categoryId );
        }

        public void Add(Ads ads)
        {
            _adsDal.Add(ads);
        }

        public void Update(Ads ads)
        {
            _adsDal.Update(ads);
        }

        public void Delete(int adsId)
        {
            _adsDal.Delete(new Ads{Id = adsId});
        }

        public Ads GetById(int adsId)
        {
            return _adsDal.Get(u => u.Id == adsId);
        }

        public List<Ads> İlanlarinKategorisiVePetCinsleri()
        {
            return _adsDal.İlanlarinKategorisiVePetCinsleri();
        }

        public List<Ads> İlanlarinKategorisiVePetTipi(int categoryId,int petBreedId,int petTypes)
        {
            return _adsDal.İlanlarinKategorisiVePetTipi(categoryId,petBreedId,petTypes);
        }

        public List<Ads> AdsByUserId(int UserId)
        {
            return _adsDal.AdsByUserId(UserId);
        }

        public List<Ads> AdsDetails(int AdsId)
        {
            return _adsDal.AdsDetails(AdsId);
        }
    }
}