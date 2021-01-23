using System.Collections.Generic;
using Ödev.Entities.Concretee;

namespace Ödev.BLL.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        List<User> GetByCategory(int userId);
        void Add(User user);
        void Update(User user);
        void Delete(int userId);
        User GetById(int userId);
         User GetUserByMail(string mail);
    }
}