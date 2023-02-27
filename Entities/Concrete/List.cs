using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class List : IEntity
    {
        public int ListId { get; set; }
        public string ListName { get; set; }

        //tamamlanmamış liste ilk başta false durumdadır. liste tamamlandı olarak işaretlendiğinde admin görebilir.
        public bool IsCompleted { get; set; } = false;

        [Required(ErrorMessage = "Date created is required")]
        public DateTime CreationDate { get; set; }
        
        [Required(ErrorMessage = "Date Completion is required")]
        public DateTime CompletionDate { get; set; }

        public ICollection<Product> Products { get; set; }



    }
}
