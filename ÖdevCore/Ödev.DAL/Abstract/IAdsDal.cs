using System.Collections.Generic;
using Ödev.Core.DataAccess;
using Ödev.Entities.Concretee;
using Microsoft.EntityFrameworkCore.Query;

namespace Ödev.DAL.Abstract
{
    public interface IAdsDal:IEntityRepository<Ads>
    {
        public List<Ads> İlanlarinKategorisiVePetCinsleri();
        public List<Ads> İlanlarinKategorisiVePetTipi(int categoryId,int petBreedId,int petTypes);

        public List<Ads> AdsByUserId(int UserId);
        public List<Ads> AdsDetails(int AdsId);

      


    }
}