using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGZ.Models.DbTableStruct;

namespace RGZ.ViewModels.DefaultTableCreateRow
{
    public class MatchStatisticViewModel : ViewModelBase
    {
        public MatchStatisticViewModel(SecondWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            MatchStatistics = new MatchStatistic();
        }
        public MatchStatistic MatchStatistics { get; set; }
        public SecondWindowViewModel? MainContext { get; set; }
    }
}