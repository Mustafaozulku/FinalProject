using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProdactName { get; set; }
        public short UnitsİnStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
