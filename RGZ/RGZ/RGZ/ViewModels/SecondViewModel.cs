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
    public class SecondViewModel : ViewModelBase
    {
        public SecondViewModel(SecondWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            ButtonDeleteQuery = ReactiveCommand.Create<Query, Unit>((query) =>
            {
                MainContext.Queries.Remove(query);
                MainContext.Tabs.Remove(query.BindedTable);
                if (QueryDescription == query.Description)
                    QueryDescription = "";
                return Unit.Default;
            });
            ButtonShowQuery = ReactiveCommand.Create<Query, Unit>((query) =>
            {
                QueryDescription = query.Description;
                return Unit.Default;
            });
        }
        string queryDescription = "";
        public string QueryDescription
        {
            get { return queryDescription; }
            set { this.RaiseAndSetIfChanged(ref queryDescription, value); }
        }
        public ReactiveCommand<Query, Unit> ButtonDeleteQuery { get; }
        public ReactiveCommand<Query, Unit> ButtonShowQuery { get; }
        public SecondWindowViewModel? MainContext { get; set; }
    }
}
