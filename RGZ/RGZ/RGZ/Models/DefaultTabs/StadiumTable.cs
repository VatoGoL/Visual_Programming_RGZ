using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RGZ.Models;
using RGZ.Models.DbTableStruct;

namespace RGZ.Models.DefaultTabs
{
    public class StadiumTable : DefaultTable
    {
        public StadiumTable(DbSet<Stadium>? dBS = null)
        {
            Header = "Stadium";
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("Id");
            DataColumns.Add("Name");
            DataColumns.Add("City Location");

            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Stadium>? DBS { get; set; }
    }
}
