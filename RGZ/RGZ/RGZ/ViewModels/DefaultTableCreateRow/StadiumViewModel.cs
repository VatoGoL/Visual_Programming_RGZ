using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGZ.Models.DbTableStruct;

namespace RGZ.ViewModels.DefaultTableCreateRow
{
    public class StadiumViewModel : ViewModelBase
    {
        public StadiumViewModel(SecondWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            Stadiums = new Stadium();
        }
        public Stadium Stadiums { get; set; }
        public SecondWindowViewModel? MainContext { get; set; }
    }
}