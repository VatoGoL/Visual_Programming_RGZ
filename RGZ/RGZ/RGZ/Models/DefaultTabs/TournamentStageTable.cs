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
    public class TournamentStageTable : DefaultTable
    {
        public TournamentStageTable(DbSet<TournamentStage>? dBS = null)
        {
            Header = "Tournament Stage";
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("Id");
            DataColumns.Add("Stage Name");

            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<TournamentStage>? DBS { get; set; }
    }
}