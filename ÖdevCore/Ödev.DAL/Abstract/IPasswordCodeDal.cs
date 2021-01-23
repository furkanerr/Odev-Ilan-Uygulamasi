using Ödev.Core.DataAccess;
using Ödev.Entities.Concrete;
using Ödev.Entities.Concretee;


namespace Ödev.DAL.Abstract
{
    public interface IPasswordCodeDal:IEntityRepository<PasswordCode>
    {
        void UserVeKodEkle(User user, string code);

    }
}