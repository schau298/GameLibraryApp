using GameLibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameLibraryApp.ViewModel
{
    public class GamesViewModel
    {
        public List<Games> Games { get; set; }
        public List<Creator> Creator { get; set; }
        public List<Ratings> Ratings { get; set; }
    }
}
