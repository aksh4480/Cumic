using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CumicEntities
{
  public  class Product:BaseEntity
    {
        public Category Category { get; set; }
        public decimal Price { get; set; }
    }
}
