using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace GameLibraryApp.Models
{
    public class Games
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter the name of the game!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the games's Genre")]
        public string Genre { get; set; }
        [Required(ErrorMessage = "Please enter the rounded cost of the game.")]
        [Range(0, 120, ErrorMessage = "Please enter the rounded cost of the game between 0 and 120.")]
        public int Cost { get; set; }
        [Required(ErrorMessage ="Please enter the platform that you play on Xbox, PC, Mobile...")]
        public string Platform {get; set;}



    }
}
