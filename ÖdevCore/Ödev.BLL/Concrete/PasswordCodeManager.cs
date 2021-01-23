using System.Collections.Generic;
using Ödev.BLL.Abstract;
using Ödev.DAL.Abstract;
using Ödev.Entities.Concrete;
using Ödev.Entities.Concretee;

namespace Ödev.BLL.Concrete
{
   

    public class PasswordCodeManager:IPasswordCodeService
    {
        private IPasswordCodeDal _passwordCodeDal;

        public PasswordCodeManager(IPasswordCodeDal passwordCodeDal)
        {
            _passwordCodeDal = passwordCodeDal;
        }

        public List<PasswordCode> GetAll()
        {
            return _passwordCodeDal.GetList();
        }

        public List<PasswordCode> GetByCategory(int PasswordCodeId)
        {
            throw new System.NotImplementedException();
        }

        public void Add(PasswordCode passwordCode)
        {
           _passwordCodeDal.Add(passwordCode);
        }

        public void Update(PasswordCode passwordCode)
        {
           _passwordCodeDal.Update(passwordCode);
        }

        public void Delete(int PasswordCodeId)
        {
            _passwordCodeDal.Delete(new PasswordCode{Id = PasswordCodeId});
           
        }

        public PasswordCode GetById(int PasswordCodeId)
        {
             return _passwordCodeDal.Get(c=>c.Id==PasswordCodeId);
        }

        public void UserVeKodEkle(User user, string code)
        {
            _passwordCodeDal.UserVeKodEkle(user,code);
        }
    }
}