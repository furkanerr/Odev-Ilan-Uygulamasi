using Ödev.Core.DataAccess.EntityFramework;
using Ödev.DAL.Abstract;
using Ödev.Entities.Concrete;
using Ödev.Entities.Concretee;

namespace Ödev.DAL.Concrete.EntityFramework
{
    public class EfPasswordCode:EfEntityRepositoryBase<PasswordCode,ProjeDbContext>,IPasswordCodeDal
    {
        public void UserVeKodEkle(User user, string code)
        {
            var context = new ProjeDbContext();
            context.Add(new PasswordCode{UserID= user.Id, Code=code});
            context.SaveChanges();

        }
    }
}