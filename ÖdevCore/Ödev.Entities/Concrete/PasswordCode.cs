using System.ComponentModel.DataAnnotations;
using Ödev.Core.Entities;
using Ödev.Entities.Concretee;

namespace Ödev.Entities.Concrete
{
    public class PasswordCode:IEntity
    {
        public int Id { get; set; }

        //[StringLength(6)]
        public string Code { get; set; }

        public User user { get; set; }

        public int UserID { get; set; }
        
    }
}