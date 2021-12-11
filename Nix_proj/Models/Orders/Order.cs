using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_proj.Models.Orders
{
    class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public List<int> ProductsIds { get; set; }
        public string OrderPrice { get; set; }
        public string Sale { get; set; }
    }
}
