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
    public class PlayerStatisticsForTheMatchTable : DefaultTable
    {
        public PlayerStatisticsForTheMatchTable(DbSet<PlayerStatisticsForTheMatch>? dBS = null)
        {
            Header = "Player Statistics For The Match";
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("Id");
            DataColumns.Add("Palyer (Id)");
            DataColumns.Add("Match (Id)");
            DataColumns.Add("Goals Scored");

            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<PlayerStatisticsForTheMatch>? DBS { get; set; }
    }
}
