using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGZ.Models.DbTableStruct;

namespace RGZ.ViewModels.DefaultTableCreateRow
{
    public class TournamentViewModel : ViewModelBase
    {
        public TournamentViewModel(SecondWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            Tournaments = new Tournament();
        }
        public Tournament Tournaments { get; set; }
        public SecondWindowViewModel? MainContext { get; set; }
    }
}