using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGZ.Models.DbTableStruct;

namespace RGZ.ViewModels.DefaultTableCreateRow
{
    public class TeamViewModel : ViewModelBase
    {
        public TeamViewModel(SecondWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            Teams = new Team();
        }
        public Team Teams { get; set; }
        public SecondWindowViewModel? MainContext { get; set; }
    }
}