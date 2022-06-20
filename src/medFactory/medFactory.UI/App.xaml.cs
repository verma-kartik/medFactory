using medFactory.UI.ViewModels;
using medFactory.UI.Views;
using Prism.DryIoc;
using Prism.Ioc;
using System.Windows;


namespace medFactory.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var bootstrapper = new Bootstrapper();
            bootstrapper.Run();
        }
    }
}
