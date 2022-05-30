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
    public class PlayerTable : DefaultTable
    {
        public PlayerTable(DbSet<Player>? dBS = null)
        {
            Header = "Player";
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("Id");
            DataColumns.Add("First Name");
            DataColumns.Add("Last Name");
            DataColumns.Add("Role On The Field");
            DataColumns.Add("Team (Id)");

            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Player>? DBS { get; set; }
    }
}