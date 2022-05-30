using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ReactiveUI;
using System.Reactive;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGZ.Models;

namespace RGZ.ViewModels
{
    public class SelectDBViewModel : ViewModelBase
    {
        public SelectDBViewModel(SecondWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            ButtonChangeTable = ReactiveCommand.Create<MyTable, Unit>((tab) =>
            {
                SelectedTab = tab;
                
                return Unit.Default;
            });
            
        }
        public SecondWindowViewModel? MainContext { get; set; }
        MyTable selectedTab;
        public MyTable SelectedTab
        {
            get { return selectedTab; }
            set { this.RaiseAndSetIfChanged(ref selectedTab, value); }
        }
      
        string where = @"";
        public string Where
        {
            get { return where; }
            set { this.RaiseAndSetIfChanged(ref where, value); }
        }
        public ReactiveCommand<MyTable, Unit> ButtonChangeTable { get; }

    }
}
