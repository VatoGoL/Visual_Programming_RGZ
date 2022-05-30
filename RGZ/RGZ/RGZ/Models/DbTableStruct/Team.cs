using System;
using System.Collections.Generic;

namespace RGZ.Models.DbTableStruct
{
    public partial class Team
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
