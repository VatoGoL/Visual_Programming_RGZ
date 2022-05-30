using System;
using System.Collections.Generic;
using ReactiveUI;
using System.Reactive;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGZ.Models;

namespace RGZ.ViewModels
{
    public class JoinDBViewModel : ViewModelBase
    {
        public JoinDBViewModel(SecondWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            ButtonChangeTableFirst = ReactiveCommand.Create<MyTable, Unit>((tab) =>
            {
                FirstSelectedTab = tab;
                FirstSelectedField = "";
                return Unit.Default;
            });
            ButtonChangeTableSecond = ReactiveCommand.Create<MyTable, Unit>((tab) =>
            {
                SecondSelectedTab = tab;
                SecondSelectedField = "";
                return Unit.Default;
            });
            ButtonChangeJoinFirst = ReactiveCommand.Create<string, Unit>((str) =>
            {
                FirstSelectedField = str;
                return Unit.Default;
            });
            ButtonChangeJoinSecond = ReactiveCommand.Create<string, Unit>((str) =>
            {
                SecondSelectedField = str;
                return Unit.Default;
            });
        }
        public SecondWindowViewModel? MainContext { get; set; }
        MyTable firstSelectedTab;
        public MyTable FirstSelectedTab
        {
            get { return firstSelectedTab; }
            set { this.RaiseAndSetIfChanged(ref firstSelectedTab, value); }
        }
        MyTable secondSelectedTab;
        public MyTable SecondSelectedTab
        {
            get { return secondSelectedTab; }
            set { this.RaiseAndSetIfChanged(ref secondSelectedTab, value); }
        }
        string firstSelectedField;
        public string FirstSelectedField
        {
            get { return firstSelectedField; }
            set { this.RaiseAndSetIfChanged(ref firstSelectedField, value); }
        }
        string secondSelectedField;
        public string SecondSelectedField
        {
            get { return secondSelectedField; }
            set { this.RaiseAndSetIfChanged(ref secondSelectedField, value); }
        }
        public ReactiveCommand<MyTable, Unit> ButtonChangeTableFirst { get; }
        public ReactiveCommand<MyTable, Unit> ButtonChangeTableSecond { get; }
        public ReactiveCommand<string, Unit> ButtonChangeJoinFirst { get; }
        public ReactiveCommand<string, Unit> ButtonChangeJoinSecond { get; }
    }
}