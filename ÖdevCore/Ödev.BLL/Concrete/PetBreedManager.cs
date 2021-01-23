using System.Collections.Generic;
using Ödev.BLL.Abstract;
using Ödev.DAL.Abstract;
using Ödev.Entities.Concretee;

namespace Ödev.BLL.Concrete
{
    public class PetBreedManager:IPetBreedService
    {
        private readonly IPetBreedDal _petBreedDal;

        public PetBreedManager(IPetBreedDal petBreedDal)
        {
            _petBreedDal = petBreedDal;
        }

        public List<PetBreed> GetAll()
        {
            return _petBreedDal.GetList();
        }

        public List<PetBreed> GetByCategory(int petTypeId)
        {
            return _petBreedDal.GetList(p=>p.PetTypes.Id==petTypeId);
        }

        public void Add(PetBreed petBreed)
        {
            _petBreedDal.Add(petBreed);
        }

        public void Update(PetBreed petBreed)
        {
            _petBreedDal.Update(petBreed);
        }

        public void Delete(int petBreedId)
        {
            _petBreedDal.Delete(new PetBreed{Id = petBreedId});
        }

        public PetBreed GetById(int petBreedId)
        {
            return _petBreedDal.Get(u => u.Id == petBreedId);
        }
    }
}