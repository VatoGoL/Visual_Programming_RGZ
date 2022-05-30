using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGZ.Models.DbTableStruct;

namespace RGZ.ViewModels.DefaultTableCreateRow
{
    public class MatchStageViewModel : ViewModelBase
    {
        public MatchStageViewModel(SecondWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            MatchStages = new MatchStage();
        }
        public MatchStage MatchStages { get; set; }
        public SecondWindowViewModel? MainContext { get; set; }
    }
}