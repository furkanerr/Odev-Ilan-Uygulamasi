using System.Collections.Generic;
using Ödev.Entities.Concretee;

namespace Ödev.BLL.Abstract
{
    public interface IPetTypeService
    {
        List<PetType> GetAll();
        List<PetType> GetByCategory(int petBreedId);
        void Add(PetType petBreed);
        void Update(PetType petBreed);
        void Delete(int petBreedId);
        PetType GetById(int petBreedId);
        
    }
}