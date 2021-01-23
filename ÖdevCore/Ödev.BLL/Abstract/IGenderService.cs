using System.Collections.Generic;
using Ödev.Entities.Concretee;

namespace Ödev.BLL.Abstract
{
    public interface IGenderService
    {
        List<Gender> GetAll();
        List<Gender> GetByCategory(int genderId);
        void Add(Gender gender);
        void Update(Gender gender);
        void Delete(int genderId);
        Gender GetById(int genderId);
    }
}