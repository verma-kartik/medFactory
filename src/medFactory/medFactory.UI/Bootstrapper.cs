using medFactory.UI.ViewModels;
using medFactory.UI.Views;
using Prism.DryIoc;
using Prism.Ioc;
using System.Windows;

namespace medFactory.UI
{
    public class Bootstrapper : PrismBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainWindow, MainWindowViewModel>();
            containerRegistry.RegisterForNavigation<LoadingPageView, LoadingPageViewModel>();
            containerRegistry.RegisterForNavigation<UserLoginView, UserLoginViewModel>();
            containerRegistry.RegisterForNavigation<DashboardView, DashboardViewModel>();
        }
    }
}
