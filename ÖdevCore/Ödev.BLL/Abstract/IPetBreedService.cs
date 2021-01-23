using System.Collections.Generic;
using Ödev.Entities.Concretee;

namespace Ödev.BLL.Abstract
{
    public interface IPetBreedService
    {
        List<PetBreed> GetAll();
        List<PetBreed> GetByCategory(int petBreedId);
        void Add(PetBreed petBreed);
        void Update(PetBreed petBreed);
        void Delete(int petBreedId);
        PetBreed GetById(int petBreedId);
    }
}