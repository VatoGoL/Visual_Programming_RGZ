using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RGZ.Models
{
    public class DefaultTable : MyTable
    {
        public DefaultTable(string h = "", List<string>? dc = null) : base(h, dc)
        {
            ButtonVisible = false;
        }
        public DbSet<object>? DBS { get; set; }
    }
}
