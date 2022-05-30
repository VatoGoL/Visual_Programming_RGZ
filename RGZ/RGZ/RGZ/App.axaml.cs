using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using RGZ.ViewModels;
using RGZ.Views;

namespace RGZ
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new SecondWindow
                {
                    //MainWindowViewModel
                    DataContext = new SecondWindowViewModel(),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
