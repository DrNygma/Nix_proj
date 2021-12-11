using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_proj.Models.Comments
{
    class Comments
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }
        public string Review { get; set; }
    }
}
