using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGZ.Models.DbTableStruct;

namespace RGZ.ViewModels.DefaultTableCreateRow
{
    public class PlayerViewModel : ViewModelBase
    {
        public PlayerViewModel(SecondWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            Players = new Player();
        }
        public Player Players { get; set; }
        public SecondWindowViewModel? MainContext { get; set; }
    }
}