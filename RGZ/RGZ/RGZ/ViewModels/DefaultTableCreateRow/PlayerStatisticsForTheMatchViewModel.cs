using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGZ.Models.DbTableStruct;

namespace RGZ.ViewModels.DefaultTableCreateRow
{
    public class PlayerStatisticsForTheMatchViewModel : ViewModelBase
    {
        public PlayerStatisticsForTheMatchViewModel(SecondWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            PlayerStatisticsForTheMatchs = new PlayerStatisticsForTheMatch();
        }
        public PlayerStatisticsForTheMatch PlayerStatisticsForTheMatchs { get; set; }
        public SecondWindowViewModel? MainContext { get; set; }
    }
}
