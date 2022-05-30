using System;
using System.Collections.Generic;

namespace RGZ.Models.DbTableStruct
{
    public partial class PlayerStatisticsForTheMatch
    {
        public long Id { get; set; }
        public long? PlayerId { get; set; }
        public long MatchId { get; set; }
        public long? GoalsScored { get; set; }
    }
}
