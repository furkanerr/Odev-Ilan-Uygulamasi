using System.Linq;
using Ödev.Core.DataAccess.EntityFramework;
using Ödev.DAL.Abstract;
using Ödev.Entities.Concrete;
using Ödev.Entities.Concretee;

namespace Ödev.DAL.Concrete.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<User,ProjeDbContext>,IUserDal
    {
       


        public User GetUserByMail(string mail)
        {
            var _context = new ProjeDbContext();
           return _context.Users.FirstOrDefault(u => u.Mail == mail);
        }
    }
}