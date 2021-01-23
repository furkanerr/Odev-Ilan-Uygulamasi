using System.Collections.Generic;
using Ödev.Core.DataAccess.EntityFramework;
using Ödev.DAL.Abstract;
using Ödev.Entities.Concrete;
using Ödev.Entities.Concretee;
using Microsoft.EntityFrameworkCore;

namespace Ödev.DAL.Concrete.EntityFramework
{
    public class EfPetBreedDal:EfEntityRepositoryBase<PetBreed,ProjeDbContext>, IPetBreedDal
    {
       
    }
}