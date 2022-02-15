using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace DomainCore.Models
{
    public class CommentDTO
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [StringLength(300, MinimumLength =2, ErrorMessage = "Недопустиая длина комментария!")]
        public string Review { get; set; }
    }
}
