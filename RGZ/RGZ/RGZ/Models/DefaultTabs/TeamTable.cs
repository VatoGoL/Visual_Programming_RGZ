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
    public class TeamTable : DefaultTable
    {
        public TeamTable(DbSet<Team>? dBS = null)
        {
            Header = "Team";
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("Id");
            DataColumns.Add("Name");

            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Team>? DBS { get; set; }
    }
}