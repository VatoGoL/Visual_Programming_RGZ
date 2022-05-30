using System;
using System.Collections.Generic;

namespace RGZ.Models.DbTableStruct
{
    public partial class Player
    {
        public long Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string RoleOnTheField { get; set; } = null!;
        public long? TeamId { get; set; }
    }
}
