using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public  class ProductDetailDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public string CategoryName { get; set; }

    }
}
