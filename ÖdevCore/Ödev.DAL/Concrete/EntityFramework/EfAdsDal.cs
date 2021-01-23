using System.Collections.Generic;
using System.Linq;
using Ödev.Core.DataAccess.EntityFramework;
using Ödev.DAL.Abstract;
using Ödev.Entities.Concrete;

using Ödev.Entities.Concretee;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;


namespace Ödev.DAL.Concrete.EntityFramework
{
    public class EfAdsDal:EfEntityRepositoryBase<Ads,ProjeDbContext>,IAdsDal
    {

        public List<Ads> İlanlarinKategorisiVePetCinsleri()
        {
            var context = new ProjeDbContext();
            
            var IlanlarveKategorileri = context.Adses.Include(a => a.Category)
                .Include(a=>a.PetBreed).ToList();
                return IlanlarveKategorileri;
            

        }

        public List<Ads> İlanlarinKategorisiVePetTipi(int categoryId,int petBreedId,int petTypes)
        {
            var context = new ProjeDbContext();

            var IlanlarveKategorileri = context.Adses.Include(a => a.Category)
                .Include(a=>a.PetType).Include(a=>a.PetBreed).Where(a=>a.CategoryId==categoryId && a.PetBreed.Id==petBreedId &&a.PetType.Id==petTypes ).ToList();
            return IlanlarveKategorileri;
        }

        public List<Ads> AdsByUserId(int UserId)
        {
            var context = new ProjeDbContext();
            var İlanlar = context.Adses.Where(a => a.UsersId == UserId).Include(a=>a.Category).ToList();
            return İlanlar;
        }

        public List<Ads> AdsDetails(int AdsId)
        {
            var context = new ProjeDbContext();
            var İlanlar = context.Adses.Where(a => a.Id == AdsId).Include(a => a.Category).Include(a => a.City)
                .Include(a => a.PetBreed).Include(a => a.Gender)
                .Include(a => a.Users).Include(a=>a.Comments).ToList();
            return İlanlar;
        }

        
    }
        
    
}