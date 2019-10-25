using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJ162Project.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public int MinimumPlayers { get; set; }
        public int MaximumPlayers { get; set; }
    }
}
