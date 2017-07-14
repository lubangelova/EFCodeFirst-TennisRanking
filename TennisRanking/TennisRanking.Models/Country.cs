﻿using System.Collections.Generic;

namespace TennisRanking.Models
{
    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Tournament> Tournaments { get; set; }
    }
}