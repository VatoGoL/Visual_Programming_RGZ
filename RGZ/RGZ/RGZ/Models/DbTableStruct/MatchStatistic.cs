using System;
using System.Collections.Generic;

namespace RGZ.Models.DbTableStruct
{
    public partial class MatchStatistic
    {
        public long Id { get; set; }
        public long MatchId { get; set; }
        public string? OwnGoal { get; set; }
        public string? Goal { get; set; }
        public string? YellowCards { get; set; }
        public string? RedCards { get; set; }
        public string? Penalty { get; set; }
    }
}
