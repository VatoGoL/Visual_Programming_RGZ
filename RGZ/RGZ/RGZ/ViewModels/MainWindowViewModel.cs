using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using System.Reactive;
using RGZ.Models;

namespace RGZ.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(SecondWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            ButtonDeleteTab = ReactiveCommand.Create<MyTable, Unit>((tab) =>
            {
                if (tab is DynamicTable)
                {
                    MainContext.Queries.Remove((tab as DynamicTable).BindedQuery);
                }
                MainContext.Tabs.Remove(tab);
                return Unit.Default;
            });
        }
        public ReactiveCommand<MyTable, Unit> ButtonDeleteTab { get; }

        public SecondWindowViewModel? MainContext { get; set; }
        bool buttonsEnabled = true;
        public bool ButtonsEnabled
        {
            get { return buttonsEnabled; }
            set { this.RaiseAndSetIfChanged(ref buttonsEnabled, value); }
        }
    }
}