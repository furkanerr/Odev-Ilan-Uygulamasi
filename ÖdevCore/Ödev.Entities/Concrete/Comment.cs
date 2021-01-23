using System;
using System.ComponentModel.DataAnnotations;
using Ödev.Core.Entities;
using Ödev.Entities.Concretee;

namespace Ödev.Entities.Concrete
{
    public class Comment:IEntity
    {
        public int Id { get; set; }

        //[Required]
        //[Display(Name ="Yorum" )]
        public string Comments { get; set; }
        public int AdsId { get; set; }

        public int UserId { get; set; }
        public Ads Ads { get; set; }
        public User User { get; set; }

       
       



    }
}