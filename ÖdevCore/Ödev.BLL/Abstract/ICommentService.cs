using System.Collections.Generic;
using Ödev.Entities.Concrete;

namespace Ödev.BLL.Abstract
{
    public interface ICommentService
    {
        List<Comment> GetAll();
        List<Comment> GetByCategory(int commendId);
        void Add(Comment commend);
        void Update(Comment commend);
        void Delete(int commendId);
        Comment GetById(int commendId);
        void IlanaGoreSil(int ilanId);
    }
}