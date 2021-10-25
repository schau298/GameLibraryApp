using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameLibraryApp.Models
{
    public class Games
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter the name of the game!")]
        [Display(Name = "Name")]
        [StringLength(50)]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Letters and Numbers allowed.")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Please enter the games's Genre")]
        [StringLength(40)]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only alphabetic letters are allowed.")]
        [Column("Gameplay Type")]
        public string Genre { get; set; }
        
        [Required(ErrorMessage = "Please enter the rounded cost of the game.")]
        [Range(0, 120, ErrorMessage = "Please enter the rounded cost of the game between 0 and 150.")]
        [DataType(DataType.Currency)]
        public int Cost { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage ="Please enter the platform that you play on Xbox, PC, Mobile...")]
        public string Platform {get; set;}
       
        [ForeignKey("CreatorId")]
        [Required(ErrorMessage ="Please enter the name of the developer who created the game.")]
        public string CreatorId { get; set; }
        public Creator Creator { get; set; }


    }
}
