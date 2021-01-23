using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ödev.Entities.Concrete;
using Ödev.Entities.Concretee;

namespace ÖdevUI.Models
{
    public class CommentAddViewModel
    {
        public Comment Comment { get; set; }
        public Ads Ads { get; set; }
    }
}