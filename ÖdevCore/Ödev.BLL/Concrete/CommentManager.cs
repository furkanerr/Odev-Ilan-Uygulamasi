using System.Collections.Generic;
using Ödev.BLL.Abstract;
using Ödev.DAL.Abstract;
using Ödev.Entities.Concrete;

namespace Ödev.BLL.Concrete
{
    public class CommentManager:ICommentService
    {
        private ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> GetAll()
        {
            return _commentDal.GetList();
        }

        public List<Comment> GetByCategory(int commendId)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Comment commend)
        {
            _commentDal.Add(commend);
        }

        public void Update(Comment commend)
        {
            _commentDal.Update(commend);
        }

        public void Delete(int commendId)
        {
           _commentDal.Delete(new Comment{Id = commendId});
        }

        public Comment GetById(int commendId)
        {
            return _commentDal.Get(c=>c.Id==commendId);
        }

        public void IlanaGoreSil(int ilanId)
        {
             _commentDal.IlanaGoreSil(ilanId);
        }
    }
}