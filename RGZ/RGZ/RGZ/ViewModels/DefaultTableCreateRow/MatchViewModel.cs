using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGZ.Models.DbTableStruct;

namespace RGZ.ViewModels.DefaultTableCreateRow
{
    public class MatchViewModel : ViewModelBase
    {
        public MatchViewModel(SecondWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            Matchs = new Match();
        }
        public Match Matchs { get; set; }
        public SecondWindowViewModel? MainContext { get; set; }
    }
}