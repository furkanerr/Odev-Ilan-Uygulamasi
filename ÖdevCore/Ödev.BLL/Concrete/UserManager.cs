using System.Collections.Generic;
using Ödev.BLL.Abstract;
using Ödev.DAL.Abstract;
using Ödev.Entities.Concretee;

namespace Ödev.BLL.Concrete
{
    public class UserManager:IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetAll()
        {
            return _userDal.GetList();
        }

        public List<User> GetByCategory(int userId)
        {
            throw new System.NotImplementedException();
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }

        public void Delete(int userId)
        {
            _userDal.Delete(new User{Id = userId});
        }

        public User GetById(int userId)
        {
            return _userDal.Get(u => u.Id == userId);
        }

        public User GetUserByMail(string mail)
        {
            return _userDal.GetUserByMail(mail);
        }
    }
}