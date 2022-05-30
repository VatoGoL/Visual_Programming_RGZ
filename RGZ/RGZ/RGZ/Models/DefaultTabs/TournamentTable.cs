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
    public class TournamentTable: DefaultTable
    {
        public TournamentTable(DbSet<Tournament>? dBS = null)
        {
            Header = "Tournament";
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("Id");
            DataColumns.Add("Name");

            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Tournament>? DBS { get; set; }
    }
}