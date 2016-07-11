using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firee.Domain.SysUser
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Unit { get; set; }
        public decimal Quantity { get; set; }
        public bool Available { get; set; }
        public decimal Price { get; set; }
        public bool Active { get; set; }

        public Supplier Supplier { get; set; }
    }
}
