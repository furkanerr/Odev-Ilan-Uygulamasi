using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Ödev.Core.Entities;
using Ödev.Entities.Concrete;

namespace Ödev.Entities.Concretee
{
    public class User:IEntity
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Ad")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Soyad")]
        public string Surname { get; set; }
        [Required]
        [Display(Name = "E-Mail")]
        public string Mail { get; set; }
        [Required]
        [Display(Name = "Şifre")]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Şehir")]
        public int CityId { get; set; }
        public string District { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Ads> Ads { get; set; }
    }
}