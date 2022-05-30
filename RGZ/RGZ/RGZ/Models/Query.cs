using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGZ.Models
{
    public class Query
    {
        public Query(string n = "", string d = "", DynamicTable? bd = null)
        {
            Name = n;
            Description = d;
            BindedTable = bd;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public DynamicTable? BindedTable { get; set; }
    }
}
