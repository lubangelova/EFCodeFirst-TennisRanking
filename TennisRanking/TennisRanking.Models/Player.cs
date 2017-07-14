using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisRanking.Models
{
    public class Player
    {   
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual Ranking Ranking { get; set; }

        public virtual ICollection<Tournament> Tournaments { get; set; }

    }
}
