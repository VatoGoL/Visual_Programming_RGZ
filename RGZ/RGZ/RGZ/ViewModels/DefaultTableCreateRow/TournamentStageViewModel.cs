using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGZ.Models.DbTableStruct;

namespace RGZ.ViewModels.DefaultTableCreateRow
{
    public class TournamentStageViewModel : ViewModelBase
    {
        public TournamentStageViewModel(SecondWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            TournamentStages = new TournamentStage();
        }
        public TournamentStage TournamentStages { get; set; }
        public SecondWindowViewModel? MainContext { get; set; }
    }
}