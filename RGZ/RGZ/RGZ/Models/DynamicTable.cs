using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGZ.Models
{
    public class DynamicTable : MyTable
    {
        public DynamicTable(string h = "", List<object>? db = null, List<string>? dc = null) : base(h, dc)
        {
            ButtonVisible = true;
            ObjectList = db;
        }
        public Query BindedQuery { get; set; }
    }
}
