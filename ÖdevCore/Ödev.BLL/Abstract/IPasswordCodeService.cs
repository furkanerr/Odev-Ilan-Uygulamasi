using System.Collections.Generic;
using Ödev.Entities.Concrete;
using Ödev.Entities.Concretee;

namespace Ödev.BLL.Abstract
{
    public interface IPasswordCodeService
    {
        List<PasswordCode> GetAll();
        List<PasswordCode> GetByCategory(int PasswordCodeId);
        void Add(PasswordCode passwordCode);
        void Update(PasswordCode passwordCode);
        void Delete(int PasswordCodeId);
        PasswordCode GetById(int PasswordCodeId);
        void UserVeKodEkle(User user, string code);
    }
}