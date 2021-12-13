using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Nix_proj.Models.Comments
{
    class Comments
    {
        [Key]
        public Guid Id { get; set; }
        public int UserId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [StringLength(300, MinimumLength =2, ErrorMessage = "Недопустиая длина комментария!")]
        public string Review { get; set; }
    }
}
