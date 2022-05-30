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
    public class MatchStageTable : DefaultTable
    {
        public MatchStageTable(DbSet<MatchStage>? dBS = null)
        {
            Header = "Match Stage";
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("Match Id");
            DataColumns.Add("Stage Id");


            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<MatchStage>? DBS { get; set; }
    }
}
