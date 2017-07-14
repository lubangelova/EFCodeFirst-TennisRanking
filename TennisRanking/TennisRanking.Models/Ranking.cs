using System.Collections;
using System.Collections.Generic;

namespace TennisRanking.Models
{
    public class Ranking
    {
        public int Id { get; set; }

        public int CurrentRanking { get; set; }

        public virtual ICollection<Player> Players { get; set; }

    }
}