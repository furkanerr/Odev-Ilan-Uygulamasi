﻿using Ödev.Core.DataAccess.EntityFramework;
using Ödev.DAL.Abstract;
using Ödev.Entities.Concrete;
using Ödev.Entities.Concretee;


namespace Ödev.DAL.Concrete
{
    public class EfCityDal:EfEntityRepositoryBase<City,ProjeDbContext>,ICityDal
    {
        
    }
}