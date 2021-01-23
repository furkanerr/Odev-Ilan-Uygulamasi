using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Ödev.Core.DataAccess.EntityFramework;
using Ödev.DAL.Abstract;
using Ödev.Entities.Concrete;
using Ödev.Entities.Concretee;
using Microsoft.EntityFrameworkCore;

namespace Ödev.DAL.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,ProjeDbContext>,ICategoryDal
    {
        

    }
}