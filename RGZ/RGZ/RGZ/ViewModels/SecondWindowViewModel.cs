using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ReactiveUI;
using System.Linq;
using System.Reactive.Linq;
using RGZ.Models;
using RGZ.Models.DbTableStruct;
using RGZ.Models.DefaultTabs;

namespace RGZ.ViewModels
{
    public class SecondWindowViewModel : ViewModelBase
    {
        public SecondWindowViewModel()
        {
            CreateContext();
            CreateTabs();
            CreateQueries();
            Content = Fv = new MainWindowViewModel(this);
            Sv = new SecondViewModel(this);
        }
        ViewModelBase content;
        public ViewModelBase Content
        {
            get { return content; }
            set { this.RaiseAndSetIfChanged(ref content, value); }
        }
        public void Change()
        {
            if (Content == Fv)
                Content = Sv;
            else if (Content == Sv)
                Content = Fv;
            else throw new InvalidOperationException();
        }

        ObservableCollection<MyTable> tabs;
        public ObservableCollection<MyTable> Tabs
        {
            get { return tabs; }
            set { this.RaiseAndSetIfChanged(ref tabs, value); }
        }

        ObservableCollection<Query> queries;
        public ObservableCollection<Query> Queries
        {
            get { return queries; }
            set { this.RaiseAndSetIfChanged(ref queries, value); }
        }

        public MainWindowViewModel Fv { get; }
        public SecondViewModel Sv { get; }

        RGZContext data;

        public RGZContext Data
        {
            get { return data; }
            set { this.RaiseAndSetIfChanged(ref data, value); }
        }
        private void CreateContext()
        {
            Data = new RGZContext();
        }

        private void CreateTabs()
        {
            Tabs = new ObservableCollection<MyTable>();
            Tabs.Add(new MatchTable(Data.Matches));
            Tabs.Add(new MatchStageTable(Data.MatchStages));
            Tabs.Add(new MatchStatisticTable(Data.MatchStatistics));
            Tabs.Add(new PlayerTable(Data.Players));
            Tabs.Add(new PlayerStatisticsForTheMatchTable(Data.PlayerStatisticsForTheMatches));
            //опечатка в названии бд
            Tabs.Add(new StadiumTable(Data.Stadia));
            Tabs.Add(new TeamTable(Data.Teams));
            Tabs.Add(new TournamentTable(Data.Tournaments));
            Tabs.Add(new TournamentStageTable(Data.TournamentStages));
        }
        private void CreateQueries()
        {
            Queries = new ObservableCollection<Query>();
        }
    }
}
