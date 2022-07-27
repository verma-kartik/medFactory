using medFactory.UI.ViewModels;
using medFactory.UI.Views;
using Prism.DryIoc;
using Prism.Ioc;
using System.Windows;
using medFactory.EF.Contracts;
using medFactory.EF.Repository;
using medFactory.Services.Contracts;
using medFactory.Services.Services;

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
            containerRegistry.RegisterScoped<IUnitOfWork, UnitOfWork>();
            containerRegistry.RegisterScoped <IServiceManager, ServiceManager>();
            
            containerRegistry.RegisterForNavigation<MainWindow, MainWindowViewModel>();
            containerRegistry.RegisterForNavigation<LoadingPageView, LoadingPageViewModel>();
            containerRegistry.RegisterForNavigation<UserLoginView, UserLoginViewModel>();

            containerRegistry.RegisterForNavigation<DashboardView, DashboardViewModel>();
            containerRegistry.RegisterForNavigation<DashboardMenuBarView, DashboardMenuBarViewModel>();
            containerRegistry.RegisterForNavigation<RibbonView, RibbonViewModel>();
            containerRegistry.RegisterForNavigation<DashboardContentView, DashboardContentViewModel>();
            containerRegistry.RegisterForNavigation<DashboardEditingBaseView, DashboardEditingBaseViewModel>();


            containerRegistry.RegisterForNavigation<AddCustomerView, AddCustomerViewModel>();
            containerRegistry.RegisterForNavigation<CustomerView, CustomerViewModel>();

            containerRegistry.RegisterForNavigation<ManufacturerView, ManufacturerViewModel>();
            containerRegistry.RegisterForNavigation<AddManufacturerView, AddManufacturerViewModel>();

            containerRegistry.RegisterForNavigation<SupplierView, SupplierViewModel>();
            containerRegistry.RegisterForNavigation<AddSupplierView, AddSupplierViewModel>();



        }
    }
}
