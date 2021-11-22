using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GameLibraryApp.Models
{
    public class Ratings
    {
        [Key]
        [Required(ErrorMessage ="Please give your thoughts about the game.")]
        public string Rating { get; set; }

        [Required(ErrorMessage = "Please enter the a rating between 1 and 10 (10 being the best).")]
        [Range(0, 120, ErrorMessage = "Please enter a rating between 1 and 10 (10 being the best).")]
        public int RatingValue { get; set; }

        [ForeignKey("Name")]
        [Required(ErrorMessage = "Please enter the name of the game.")]
        public string Name { get; set; }
        public Games Games { get; set; }
    }
}
