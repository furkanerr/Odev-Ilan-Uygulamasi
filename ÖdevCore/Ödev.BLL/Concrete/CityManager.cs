using System.Collections.Generic;
using Ödev.BLL.Abstract;
using Ödev.DAL.Abstract;
using Ödev.Entities.Concretee;

namespace Ödev.BLL.Concrete
{
    public class CityManager:ICityService
    {
        private readonly ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public List<City> GetAll()
        {
            return _cityDal.GetList();
        }

        public List<City> GetByCategory(int cityId)
        {
            return _cityDal.GetList(a => a.Id == cityId);
        }

        public void Add(City city)
        {
            _cityDal.Add(city);
        }

        public void Update(City city)
        {
            _cityDal.Update(city);
        }

        public void Delete(int cityId)
        {
            _cityDal.Delete(new City{Id = cityId});
        }

        public City GetById(int cityId)
        {
            return _cityDal.Get(u => u.Id == cityId);
        }
    }
}