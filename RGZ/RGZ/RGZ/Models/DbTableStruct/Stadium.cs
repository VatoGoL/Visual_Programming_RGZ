using System;
using System.Collections.Generic;

namespace RGZ.Models.DbTableStruct
{
    public partial class Stadium
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string CityLocation { get; set; } = null!;
    }
}
