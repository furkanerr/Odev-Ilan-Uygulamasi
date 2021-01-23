using System.Collections.Generic;
using Ödev.Entities.Concretee;

namespace Ödev.BLL.Abstract
{
    public interface ICityService
    {
        List<City> GetAll();
        List<City> GetByCategory(int cityId);
        void Add(City city);
        void Update(City city);
        void Delete(int cityId);
        City GetById(int cityId);
    }
}