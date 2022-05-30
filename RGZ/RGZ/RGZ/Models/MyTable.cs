using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace RGZ.Models
{
    public class MyTable
    {
        public MyTable(string h = "", List<string>? dataColumns = null, List<object>? objectList = null)
        {
            Header = h;
            DataColumns = dataColumns;
            ObjectList = objectList;
        }
        public string Header { get; set; }
        public bool ButtonVisible { get; set; }
        public List<object>? ObjectList { get; set; }
        public List<string>? DataColumns { get; set; }
    }
}
