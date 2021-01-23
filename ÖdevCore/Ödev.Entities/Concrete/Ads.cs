using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ödev.Core.Entities;
using Ödev.Entities.Concrete;

using Microsoft.AspNetCore.Http;

namespace Ödev.Entities.Concretee
{
    public class Ads:IEntity
    {
        public int Id { get; set; }
      
       
        [Display(Name = "Pet Tipi")]
        public int PetTypeId { get; set; }
       
        [Display(Name = "Tür")]
        public int PetBreedId { get; set; }
       
        [Display(Name = "Şehir")]
        public int CityId { get; set; }  
        
        [Display(Name = "Cinsiyet")]
       
        public int GenderId { get; set; }
        
        [Display(Name = "İlan Kategorisi")]
        
        public int CategoryId { get; set; }
       

        public int UsersId { get; set; }
      
        public string PetName { get; set; }
       
        public string PetAge { get; set; }
       
        [Display(Name = "İlan Açıklaması")]
       
        public string AdText { get; set; }
      
        public string District { get; set; }

        public string PetPhoto { get; set; }
        
        [NotMapped] 
        public IFormFile CoverPhoto { get; set; }

        public List<Comment> Comments { get; set; }
        public User Users { get; set; }
        public Category Category { get; set; }
        public City City { get; set; }
        public Gender Gender { get; set; }
        public PetBreed PetBreed { get; set; }
        public PetType PetType { get; set; }

        

    }
}



