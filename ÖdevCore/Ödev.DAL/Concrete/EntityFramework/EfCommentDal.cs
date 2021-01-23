using System.Collections.Generic;
using System.Linq;
using Ödev.Core.DataAccess.EntityFramework;
using Ödev.DAL.Abstract;
using Ödev.Entities.Concrete;
using Ödev.Entities.Concretee;

namespace Ödev.DAL.Concrete.EntityFramework
{
    public class EfCommentDal:EfEntityRepositoryBase<Comment,ProjeDbContext>,ICommentDal
    {
        public void IlanaGoreSil(int ilanId)
        {
            var context = new ProjeDbContext();

             var yorumlar= context.Comments.Where(a => a.AdsId == ilanId).ToList();
             if(yorumlar.Count>0){ context.Remove(yorumlar);}

            
        }
    }
}