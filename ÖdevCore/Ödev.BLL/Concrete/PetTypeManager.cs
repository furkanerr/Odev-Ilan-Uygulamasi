using System;
using System.Collections.Generic;
using Ödev.BLL.Abstract;
using Ödev.DAL.Abstract;
using Ödev.Entities.Concretee;

namespace Ödev.BLL.Concrete
{
    public  class PetTypeManager : IPetTypeService
    {
        private readonly IPetTypeDal _petTypeDal;

        public PetTypeManager(IPetTypeDal petTypeDal)
        {
            _petTypeDal = petTypeDal;
        }

        public List<PetType> GetAll()
        {
            return _petTypeDal.GetList();
        }

        public List<PetType> GetByCategory(int petTypes)
        {
            return _petTypeDal.GetList(p => p.Id == petTypes);
        }

        public void Add(PetType petType)
        {
            _petTypeDal.Add(petType);
        }

        public void Update(PetType petType)
        {
            _petTypeDal.Update(petType);
        }

        public void Delete(int petTypeId)
        {
            _petTypeDal.Delete(new PetType{Id = petTypeId});
        }

        public PetType GetById(int petTypeId)
        {
            return _petTypeDal.Get(u => u.Id == petTypeId);
        }

       
    }
}