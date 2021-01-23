using System.Collections.Generic;
using Ödev.Core.DataAccess;
using Ödev.Entities.Concrete;

namespace Ödev.DAL.Abstract
{
    public interface ICommentDal:IEntityRepository<Comment>
    {
        void IlanaGoreSil(int ilanId);

    }
}