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
    public class MatchTable : DefaultTable
    {
        public MatchTable(DbSet<Match>? dBS = null)
        {
            Header = "Match";
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("Id");
            DataColumns.Add("Score");
            DataColumns.Add("Date Time");
            DataColumns.Add("Stadium (Id)");
            DataColumns.Add("Statistics (Id)");
            DataColumns.Add("Team One (Id)");
            DataColumns.Add("Team Two (Id)");
            DataColumns.Add("Tournay (Id)");
            
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Match>? DBS { get; set; }
    }
}