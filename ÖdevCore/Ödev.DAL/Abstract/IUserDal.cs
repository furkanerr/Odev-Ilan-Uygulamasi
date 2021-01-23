using Ödev.Core.DataAccess;
using Ödev.Entities.Concretee;


namespace Ödev.DAL.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
         User GetUserByMail(string mail);
    }
}