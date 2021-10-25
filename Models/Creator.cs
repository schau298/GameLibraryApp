using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameLibraryApp.Models
{
    public class Creator
    {
        [Key]
        public string CreatorId { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage ="Please enter a game developer.")]
        public string Name { get; set; }
    }
}
