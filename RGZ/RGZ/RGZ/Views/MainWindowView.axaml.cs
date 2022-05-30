 using Avalonia;
using Avalonia.Interactivity;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using RGZ.Models;
using RGZ.Models.DbTableStruct;
using Microsoft.EntityFrameworkCore;
using RGZ.ViewModels;
using RGZ.ViewModels.DefaultTableCreateRow;
using RGZ.Views.DefaultTableCreateRow;
using RGZ.Models.DefaultTabs;

namespace RGZ.Views
{
    public partial class MainWindowView : UserControl
    {
        public MainWindowView()
        {

            InitializeComponent();
            this.Find<DataGrid>("DataTable").AutoGeneratingColumn += dataGrid_AutoGeneratingColumn;
            this.Find<DataGrid>("DataTable").PropertyChanged += dataGrid_PropertyChanged;
            this.FindControl<TabControl>("DataTabs").SelectionChanged += tabControl_SelectionChanged;
            this.FindControl<Button>("CreateNew").Click += button_CreateNew_Click;
            this.FindControl<Button>("Delete").Click += button_Delete_Click;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        private void changeDataGridItems()
        {
            object? selectedTab;
            selectedTab = this.FindControl<TabControl>("DataTabs").SelectedItem;
            if (selectedTab != null)
            {
                if (selectedTab is DynamicTable)
                {
                    var selectedItems = (selectedTab as DynamicTable).ObjectList;
                    if (selectedItems != null)
                        this.Find<DataGrid>("DataTable").Items = selectedItems;
                }
                else
                {
                    if (selectedTab is MatchTable)
                    {
                        var selectedItems = (selectedTab as MatchTable).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is MatchStageTable)
                    {
                        var selectedItems = (selectedTab as MatchStageTable).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is MatchStatisticTable)
                    {
                        var selectedItems = (selectedTab as MatchStatisticTable).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is PlayerTable)
                    {
                        var selectedItems = (selectedTab as PlayerTable).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is PlayerStatisticsForTheMatchTable)
                    {
                        var selectedItems = (selectedTab as PlayerStatisticsForTheMatchTable).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is StadiumTable)
                    {
                        var selectedItems = (selectedTab as StadiumTable).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is TeamTable)
                    {
                        var selectedItems = (selectedTab as TeamTable).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is TournamentTable)
                    {
                        var selectedItems = (selectedTab as TournamentTable).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is TournamentStageTable)
                    {
                        var selectedItems = (selectedTab as TournamentStageTable).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else throw new System.ArgumentException();
                }
            }
        }
        private void refreshDataGridItems()
        {
            this.Find<DataGrid>("DataTable").Items = null;
            changeDataGridItems();
        }
        private void tabControl_SelectionChanged(object? sender,
           SelectionChangedEventArgs e)
        {
            changeDataGridItems();
        }
        private void dataGrid_AutoGeneratingColumn(object? sender,
        DataGridAutoGeneratingColumnEventArgs e)
        {
            var tab = (this.FindControl<TabControl>("DataTabs").SelectedItem as MyTable);
            if (tab is DynamicTable) (this.DataContext as MainWindowViewModel).ButtonsEnabled = false;
            else (this.DataContext as MainWindowViewModel).ButtonsEnabled = true;
            if (!tab.DataColumns.Contains(e.Column.Header.ToString()))
                e.Column.IsVisible = false;
        }
        private void dataGrid_PropertyChanged(object? sender, AvaloniaPropertyChangedEventArgs e)
        {
            if (this.DataContext is not null)
                if (this.FindControl<TabControl>("DataTabs").SelectedItem is not DynamicTable)
                    (this.DataContext as MainWindowViewModel).MainContext.Data.SaveChanges();
        }

        async private void button_CreateNew_Click(object? sender, RoutedEventArgs e)
        {
            object? selectedTab;
            selectedTab = this.FindControl<TabControl>("DataTabs").SelectedItem;
            Window window;
            if (selectedTab != null)
            {
                if (selectedTab is MatchTable)
                {
                    window = new MatchView((this.DataContext as MainWindowViewModel).MainContext);
                }
                else if (selectedTab is MatchStageTable)
                {
                    window = new MatchStageView((this.DataContext as MainWindowViewModel).MainContext);
                }
                else if (selectedTab is MatchStatisticTable)
                {
                    window = new MatchStatisticView((this.DataContext as MainWindowViewModel).MainContext);
                }
                else if (selectedTab is PlayerTable)
                {
                    window = new PlayerView((this.DataContext as MainWindowViewModel).MainContext);
                }
                else if (selectedTab is PlayerStatisticsForTheMatchTable)
                {
                    window = new PlayerStatisticsForTheMatchView((this.DataContext as MainWindowViewModel).MainContext);
                }
                else if (selectedTab is StadiumTable)
                {
                    window = new StadiumView((this.DataContext as MainWindowViewModel).MainContext);
                }
                else if (selectedTab is TeamTable)
                {
                    window = new TeamView((this.DataContext as MainWindowViewModel).MainContext);
                }
                else if (selectedTab is TournamentTable)
                {
                    window = new TournamentView((this.DataContext as MainWindowViewModel).MainContext);
                }
                else if (selectedTab is TournamentStageTable)
                {
                    window = new TournamentStageView((this.DataContext as MainWindowViewModel).MainContext);
                }
                else throw new System.ArgumentException();
                await window.ShowDialog((Window)this.VisualRoot);
                refreshDataGridItems();
            }
        }
        private void button_Delete_Click(object? sender, RoutedEventArgs e)
        {
            object? selectedTab;
            selectedTab = this.FindControl<TabControl>("DataTabs").SelectedItem;
            var dgItem = this.Find<DataGrid>("DataTable").SelectedItem;
            if (selectedTab != null && dgItem != null)
            {
                if (selectedTab is MatchTable)
                {
                    (selectedTab as MatchTable).DBS.Remove(dgItem as Match);
                }
                else if (selectedTab is MatchStageTable)
                {
                    (selectedTab as MatchStageTable).DBS.Remove(dgItem as MatchStage);
                }
                else if (selectedTab is MatchStatisticTable)
                {
                    (selectedTab as MatchStatisticTable).DBS.Remove(dgItem as MatchStatistic);
                }
                else if (selectedTab is PlayerTable)
                {
                    (selectedTab as PlayerTable).DBS.Remove(dgItem as Player);
                }
                else if (selectedTab is PlayerStatisticsForTheMatchTable)
                {
                    (selectedTab as PlayerStatisticsForTheMatchTable).DBS.Remove(dgItem as PlayerStatisticsForTheMatch);
                }
                else if (selectedTab is StadiumTable)
                {
                    (selectedTab as StadiumTable).DBS.Remove(dgItem as Stadium);
                }
                else if (selectedTab is TournamentTable)
                {
                    (selectedTab as TournamentTable).DBS.Remove(dgItem as Tournament);
                }
                else if (selectedTab is TournamentStageTable)
                {
                    (selectedTab as TournamentStageTable).DBS.Remove(dgItem as TournamentStage);
                }
                else if (selectedTab is TeamTable)
                {
                    (selectedTab as TeamTable).DBS.Remove(dgItem as Team);
                }
                else throw new System.ArgumentException();
                (this.DataContext as MainWindowViewModel).MainContext.Data.SaveChanges();
                refreshDataGridItems();
            }
        }
    }
}
