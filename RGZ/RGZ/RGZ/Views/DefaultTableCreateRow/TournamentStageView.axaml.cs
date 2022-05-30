using Avalonia;
using Avalonia.Interactivity;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using RGZ.ViewModels.DefaultTableCreateRow;
using RGZ.ViewModels;

namespace RGZ.Views.DefaultTableCreateRow
{
    public partial class TournamentStageView : Window
    {
        public TournamentStageView()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            this.FindControl<Button>("Confirm").Click += button_Confirm_Click;
            this.FindControl<Button>("Cancel").Click += button_Cancel_Click;
        }
        public TournamentStageView(SecondWindowViewModel? mainContext) : this()
        {
            this.DataContext = new TournamentStageViewModel(mainContext);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void button_Confirm_Click(object? sender, RoutedEventArgs e)
        {
            var dc = (this.DataContext as TournamentStageViewModel);
            dc.MainContext.Data.TournamentStages.Add(dc.TournamentStages);
            dc.MainContext.Data.SaveChanges();
            this.Close();
        }
        private void button_Cancel_Click(object? sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}