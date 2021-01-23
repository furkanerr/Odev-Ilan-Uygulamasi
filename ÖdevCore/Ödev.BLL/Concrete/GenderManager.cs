using System.Collections.Generic;
using Ödev.BLL.Abstract;
using Ödev.DAL.Abstract;
using Ödev.Entities.Concretee;

namespace Ödev.BLL.Concrete
{
    public class GenderManager:IGenderService
    {
        private readonly IGenderDal _genderDal;

        public GenderManager(IGenderDal genderDal)
        {
            _genderDal = genderDal;
        }

        public List<Gender> GetAll()
        {
            return _genderDal.GetList();
        }

        public List<Gender> GetByCategory(int userId)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Gender gender)
        {
            _genderDal.Add(gender);
        }

        public void Update(Gender gender)
        {
            _genderDal.Update(gender);
        }

        public void Delete(int genderId)
        {
            _genderDal.Delete(new Gender{Id = genderId});
        }

        public Gender GetById(int genderId)
        {
            return _genderDal.Get(u => u.Id == genderId);
        }
    }
}