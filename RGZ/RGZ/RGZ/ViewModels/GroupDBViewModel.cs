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
    public class GroupDBViewModel : ViewModelBase
    {
        public GroupDBViewModel(SecondWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            ButtonChangeTable = ReactiveCommand.Create<MyTable, Unit>((tab) =>
            {
                SelectedTab = tab;
                SelectedField = "";
                return Unit.Default;
            });
            ButtonChangeGROUPBY = ReactiveCommand.Create<string, Unit>((str) =>
            {
                SelectedField = str;
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
        string selectedField;
        public string SelectedField
        {
            get { return selectedField; }
            set { this.RaiseAndSetIfChanged(ref selectedField, value); }
        }
        public ReactiveCommand<MyTable, Unit> ButtonChangeTable { get; }
        public ReactiveCommand<string, Unit> ButtonChangeGROUPBY { get; }
    }
}
