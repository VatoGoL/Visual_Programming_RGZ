using System;
using System.Collections.Generic;

namespace RGZ.Models.DbTableStruct
{
    public partial class Match
    {
        public long Id { get; set; }
        public string? Score { get; set; }
        public byte[] DateTime { get; set; } = null!;
        public long StadiumId { get; set; }
        public long? StatisticsId { get; set; }
        public long TeamOneId { get; set; }
        public long TeamTwoId { get; set; }
        public long TournayId { get; set; }
    }
}
