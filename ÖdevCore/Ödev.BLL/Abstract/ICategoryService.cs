using System.Collections.Generic;
using Ödev.Entities.Concretee;

namespace Ödev.BLL.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        List<Category> GetByCategory(int categoryId);
        void Add(Category category);
        void Update(Category category);
        void Delete(int categoryId);
        Category GetById(int categoryId);
    }
}