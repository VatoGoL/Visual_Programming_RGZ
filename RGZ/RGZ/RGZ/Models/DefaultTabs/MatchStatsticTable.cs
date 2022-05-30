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
    public class MatchStatisticTable : DefaultTable
    {
        public MatchStatisticTable(DbSet<MatchStatistic>? dBS = null)
        {
            Header = "Match Statistic";
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("Id");
            DataColumns.Add("Match Id");
            DataColumns.Add("Own Goal");
            DataColumns.Add("Goal");
            DataColumns.Add("Yellow Cards");
            DataColumns.Add("Red Cards");
            DataColumns.Add("Penalty");

            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<MatchStatistic>? DBS { get; set; }
    }
}