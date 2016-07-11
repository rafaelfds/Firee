using System;
using System.Collections.Generic;

namespace Firee.Domain.SysUser
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime StockUpdate { get; set; }
        public bool Active { get; set; }
        public IList<Product> Products { get; set; }
    }
}
